using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NextGenTraining.Pages.CourseAssignments
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



        public IList<CourseInstance> CourseAssignments { get; set; }

        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            CourseAssignments = await _context.CourseInstance.Include(x => x.User).Include(x => x.Course).Where(x => x.UserId == user.Id).ToListAsync();
        }
    }
}