using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class UserRolesViewModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public RoleViewModel  role { get; set; }
    }
}
