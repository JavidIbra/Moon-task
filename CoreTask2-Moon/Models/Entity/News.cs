using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask2_Moon.Models.Entity
{
    public class News
    {
        public int Id { get; set; }

        public string Img { get; set; }
        public string Branch { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public string Comment { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }

    }
}
