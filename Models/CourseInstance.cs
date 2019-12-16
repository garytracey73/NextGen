using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class CourseInstance
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public double Progress { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
