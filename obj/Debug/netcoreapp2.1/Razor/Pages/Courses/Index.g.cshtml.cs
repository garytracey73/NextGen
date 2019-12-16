#pragma checksum "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9aa002dad61e5b0148ac744c2f9d5cd4520e33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Courses.Pages_Courses_Index), @"mvc.1.0.razor-page", @"/Pages/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Courses/Index.cshtml", typeof(ContactManager.Pages.Courses.Pages_Courses_Index), null)]
namespace ContactManager.Pages.Courses
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9aa002dad61e5b0148ac744c2f9d5cd4520e33", @"/Pages/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5547a5a6348150b781e5418615fa3aec46bd0856", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
  
    ViewData["Title"] = "Courses";

#line default
#line hidden
            BeginContext(100, 276, true);
            WriteLiteral(@"<h2>Courses</h2>

<table id=""courses-table"" class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Category
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
         foreach (var item in Model.Courses) {

#line default
#line hidden
            BeginContext(424, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(473, 39, false);
#line 25 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(568, 48, false);
#line 28 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(616, 168, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div id=\"modal-placeholder\"></div>\r\n                <button type=\"button\" class=\"btn btn-primary\" data-course-id=");
            EndContext();
            BeginContext(785, 7, false);
#line 32 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(792, 36, true);
            WriteLiteral(" data-toggle=\"ajax-modal\" data-url=\"");
            EndContext();
            BeginContext(829, 68, false);
#line 32 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
                                                                                                                    Write(Url.Page("Index", "AssignModalPartial", new { courseId = item.Id } ));

#line default
#line hidden
            EndContext();
            BeginContext(897, 99, true);
            WriteLiteral("\">\r\n                    Assign Users\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(999, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1043, 1039, true);
                WriteLiteral(@"
    
    <script>
        $(function () {

            var placeholderElement = $('#modal-placeholder');
            $(""#courses-table"").DataTable();

            $('button[data-toggle=""ajax-modal""]').click(function (event) {
                var url = $(this).data('url');
                $.get(url).done(function (data) {
                    placeholderElement.html(data)
                    placeholderElement.find('.modal').modal('show');
                });
            });

            placeholderElement.on('click', '[data-save=""modal""]', function (event) {
                event.preventDefault();
                var form = $(this).parents('.modal').find('form');
                var actionUrl = form.attr('action');
                var dataToSend = form.serialize();

                $.post(actionUrl, dataToSend).done(function (data) {
                    $('#add-course').modal('hide');
                    return false;
                });
            });
        });
    </script>
 ");
                WriteLiteral("   \r\n    \r\n    ");
                EndContext();
            }
            );
            BeginContext(2085, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactManager.Pages.Courses.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Courses.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactManager.Pages.Courses.IndexModel>)PageContext?.ViewData;
        public ContactManager.Pages.Courses.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
