using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetcorewithoutMVC.Core
{
    public class Accommodation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public AccommodationType AccommodationType { get; set; }
    }
}
