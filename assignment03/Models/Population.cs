using System;
using System.Collections.Generic;

namespace assignment03.Models
{
    public partial class Population
    {
        /*
        public Population()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }
        */

        public int ID { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public int? TotalPopulation { get; set; }
    }
}
