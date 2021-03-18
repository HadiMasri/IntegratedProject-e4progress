using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public CourseRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Update(Course courseToUpdate)
        {
            var objFromDb = _context.Courses.FirstOrDefault(s => s.Id == courseToUpdate.Id);
            var course = _mapper.Map<Course>(courseToUpdate);
            if (objFromDb != null)
            {
                objFromDb.Name = course.Name;
                objFromDb.Icon = course.Icon;
                objFromDb.Instruction_LanguageId = course.Instruction_LanguageId;
                objFromDb.UserInterface_LanguageId = course.UserInterface_LanguageId;
                objFromDb.Office_ApplicationId = course.Office_ApplicationId;
                objFromDb.Created_By = course.Created_By;
                objFromDb.Created_On = course.Created_On;
                objFromDb.ReplicationKey = course.ReplicationKey;
            }
        }
    }
}
