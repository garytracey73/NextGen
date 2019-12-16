using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using ContactManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace ContactManager.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            //if (!_signInManager.IsSignedIn(User)){
            //    RedirectToPage()
            //}
        }
    }
}
