using AutoMapper;
using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepositories;
using System;

namespace E4Progress.DAL.Repositories
{
    public class Office_ApplicationRepository : Repository<Office_Application>, IOffice_ApplicationRepository
    {
        private E4ProgressDBContext _context;
        private IMapper _mapper;

        public Office_ApplicationRepository(E4ProgressDBContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Update(Office_Application office_Application)
        {
            throw new NotImplementedException();
        }
    }
}
