using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContactManager.Data.ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public IndexModel(ContactManager.Data.ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }



        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Course.Include(x=>x.Category).ToListAsync();
        }   

        public PartialViewResult OnGetAssignModalPartial(int courseId)
        {
            // this handler returns _ContactModalPartial

            var course = _context.Course.FirstOrDefault(x => x.Id == courseId);
            var availableUsers = _userManager.Users.ToList();

            AssignmentModel assignmentModel = new AssignmentModel { CourseId = courseId, CourseName = course.Name, Users = new List<AssignmentUser>() };

            foreach (var item in availableUsers)
            {
                assignmentModel.Users.Add(new AssignmentUser { Assigned = false, Username = item.UserName, UserId = item.Id });
            }

            return new PartialViewResult
            {
                ViewName = "_AssignModalPartial",
                ViewData = new ViewDataDictionary<AssignmentModel>(ViewData, assignmentModel)
            };
        }

        public async Task OnPostAssignModalPartial(AssignmentModel model)
        {
            //Contacts.Add(model);

            foreach (var item in model.Users.Where(x=>x.Assigned))
            {
                CourseInstance instance = new CourseInstance();
                instance.CourseId = model.CourseId;
                instance.Progress = 0;
                instance.UserId = item.UserId;

                _context.CourseInstance.Add(instance);
            }

            _context.SaveChanges();

            Courses = await _context.Course.Include(x => x.Category).ToListAsync();
        }
    }
}