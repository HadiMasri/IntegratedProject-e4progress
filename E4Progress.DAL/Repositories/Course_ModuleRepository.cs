using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    public class Course_ModuleRepository : Repository<Course_Module>, ICourse_ModuleRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Course_ModuleRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Course_Module> GetModulesWithCourse()
        {
            return _context.Course_Modules
                .Include(c => c.Course)
                .ToList();
        }

        public void Update(Course_Module course_Module)
        {
            var objFromDb = _context.Course_Modules.FirstOrDefault(cm => cm.Id == course_Module.Id);
            if (objFromDb != null)
            {
                objFromDb.CourseId = course_Module.CourseId;
                objFromDb.Title = course_Module.Title;
                objFromDb.Sortorder = course_Module.Sortorder;
                objFromDb.Course = course_Module.Course;
            }
        }
    }
}
