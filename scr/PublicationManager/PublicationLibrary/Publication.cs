using System;
using System.Collections.Generic;
using System.Text;

namespace Jr.PublicationLibrary
{
    public class Publication
    {
        public int Year { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        

        public int Id { get; internal set; }
    }
}
