using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace E4Progress.DAL.Repositories
{
    class Course_Module_Topic_ElementRepository : Repository<Course_Module_Topic_Element>, ICourse_Module_Topic_ElementRepository
    {
        private readonly E4ProgressDBContext _context;
        private readonly IMapper _mapper;

        public Course_Module_Topic_ElementRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Course_Module_Topic_Element> GetElementsWithTopic()
        {
            return _context.Course_Module_Topic_Elements
                .Include(c => c.Course_Module_Topic)
                .ToList();
        }

        public void Update(Course_Module_Topic_Element course_Module_Topic_Element)
        {
            var objFromDb = _context.Course_Module_Topic_Elements.FirstOrDefault(cm => cm.Id == course_Module_Topic_Element.Id);
            if (objFromDb != null)
            {
                objFromDb.Content_ElementId = course_Module_Topic_Element.Content_ElementId;
                objFromDb.Content_Element_Type = course_Module_Topic_Element.Content_Element_Type;
                objFromDb.Content_Element_TypeId = course_Module_Topic_Element.Content_Element_TypeId;
                objFromDb.Course_Module_Topic = course_Module_Topic_Element.Course_Module_Topic;
                objFromDb.Course_Module_TopicId = course_Module_Topic_Element.Course_Module_TopicId;
                objFromDb.Difficulty_Level = course_Module_Topic_Element.Difficulty_Level;
                objFromDb.Difficulty_LevelId = course_Module_Topic_Element.Difficulty_LevelId;
            }
        }
    }
}