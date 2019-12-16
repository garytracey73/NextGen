using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CourseInstance> CourseInstances { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
