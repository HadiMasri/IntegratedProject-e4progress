using System;
using System.Collections.Generic;
using System.Text;

namespace E4Progress.Shared.ViewModels
{
    public class Didactical_Model_LevelViewModel
    {
        public int Id { get; set; }
        public int Didactical_ModelId { get; set; }
        public Didactical_ModelViewModel Didactical_Model { get; set; }
        public string Name { get; set; }
        public int Sortorder { get; set; }
    }
}
