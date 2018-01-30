using System;
using System.Collections.Generic;
using System.Text;

namespace Jr.PublicationLibrary
{
    public class Magasine : Publication

    {
        public string EditionMonth { get; set; }
        public int SuscriptionPrice { get; set; }
       // public string MagasineInfo => $"{FullName} {EditionMonth} {SuscriptionPrice}";
    }
}
