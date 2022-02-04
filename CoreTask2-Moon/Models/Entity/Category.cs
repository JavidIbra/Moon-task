using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask2_Moon.Models.Entity
{
    public class Category 
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Project> Projects { get; set; }

    }
}
