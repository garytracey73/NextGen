using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class AssignmentModel
    {
        public AssignmentModel()
        {
            Users = new List<AssignmentUser>();
        }
        public List<AssignmentUser> Users { get; set; }

        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }

    public class AssignmentUser {

        public string Username { get; set; }

        public bool Assigned { get; set; }

        public string UserId { get; set; }
    }

}
