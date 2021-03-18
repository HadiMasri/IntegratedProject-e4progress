using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    class Course_Module_TopicRepository : Repository<Course_Module_Topic>, ICourse_Module_TopicRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Course_Module_TopicRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Course_Module_Topic> GetTopicsWithModule()
        {
            return _context.Course_Module_Topics
                .Include(c => c.Course_Module)
                .ToList();
        }

        public void Update(Course_Module_Topic course_Module_Topic)
        {
            var objFromDb = _context.Course_Module_Topics.FirstOrDefault(cm => cm.Id == course_Module_Topic.Id);
            if (objFromDb != null)
            {
                objFromDb.Course_ModuleId = course_Module_Topic.Course_ModuleId;
                objFromDb.Title = course_Module_Topic.Title;
                objFromDb.Sortorder = course_Module_Topic.Sortorder;
                objFromDb.Course_Module = course_Module_Topic.Course_Module;
            }

        }
    }
}