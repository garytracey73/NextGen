#pragma checksum "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c000f8060d54b1cabafc72dd4a2bf71647e2a9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.CourseAssignments.Pages_CourseAssignments_Index), @"mvc.1.0.razor-page", @"/Pages/CourseAssignments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CourseAssignments/Index.cshtml", typeof(ContactManager.Pages.CourseAssignments.Pages_CourseAssignments_Index), null)]
namespace ContactManager.Pages.CourseAssignments
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\_ViewImports.cshtml"
using ContactManager;

#line default
#line hidden
#line 3 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\_ViewImports.cshtml"
using ContactManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c000f8060d54b1cabafc72dd4a2bf71647e2a9fd", @"/Pages/CourseAssignments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5547a5a6348150b781e5418615fa3aec46bd0856", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CourseAssignments_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml"
  
    ViewData["Title"] = "Course Assignments";

#line default
#line hidden
            BeginContext(120, 304, true);
            WriteLiteral(@"<h2>Course Assignments</h2>

<table id=""course-assignments-table"" class=""table"">
    <thead>
        <tr>
            <th>
                Couse Name
            </th>
            <th>
                Progress
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml"
         foreach (var item in Model.CourseAssignments)
        {

#line default
#line hidden
            BeginContext(491, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(552, 46, false);
#line 25 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Course.Name));

#line default
#line hidden
            EndContext();
            BeginContext(598, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(666, 43, false);
#line 28 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Progress));

#line default
#line hidden
            EndContext();
            BeginContext(709, 227, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"button\" class=\"btn btn-primary\">\r\n                        Launch Course\r\n                    </button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\CourseAssignments\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(947, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(991, 128, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () {\r\n            $(\"#course-assignments-table\").DataTable();\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(1122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NextGenTraining.Pages.CourseAssignments.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NextGenTraining.Pages.CourseAssignments.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NextGenTraining.Pages.CourseAssignments.IndexModel>)PageContext?.ViewData;
        public NextGenTraining.Pages.CourseAssignments.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
