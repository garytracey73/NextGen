﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<CourseInstance> CourseInstances { get; set; }
    }
}
