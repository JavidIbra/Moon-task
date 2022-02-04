using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask2_Moon.Models.Entity
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Img { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
