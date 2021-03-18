using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class Content_ThemeRepository : Repository<Content_Theme>, IContent_ThemeRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Content_ThemeRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /*
        public IEnumerable<Content_Theme> GetModulesWithCourse()
        {
            return _context.Course_Modules
                .Include(c => c.Course)
                .ToList();
        }
        */

        public void Update(Content_Theme content_Theme)
        {
            var objFromDb = _context.Content_Themes.FirstOrDefault(cm => cm.Id == content_Theme.Id);
            if (objFromDb != null)
            {
                objFromDb.Id = content_Theme.Id;
                objFromDb.Name = content_Theme.Name;
                objFromDb.Content_Theme_Translations = objFromDb.Content_Theme_Translations;
            }
        }
    }
}
