using E4Progress.DAL.Entities;
using E4Progress.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.DAL.IRepositories
{
    public interface IContent_ThemeRepository : IRepository<Content_Theme>
    {

        void Update(Content_Theme content_Theme);
        
    }
}
