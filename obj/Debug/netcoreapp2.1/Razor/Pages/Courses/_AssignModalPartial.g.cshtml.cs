#pragma checksum "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38adbb3360f5337964c6b038c2c7facdb31d6a7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContactManager.Pages.Courses.Pages_Courses__AssignModalPartial), @"mvc.1.0.view", @"/Pages/Courses/_AssignModalPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Courses/_AssignModalPartial.cshtml", typeof(ContactManager.Pages.Courses.Pages_Courses__AssignModalPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38adbb3360f5337964c6b038c2c7facdb31d6a7f", @"/Pages/Courses/_AssignModalPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5547a5a6348150b781e5418615fa3aec46bd0856", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses__AssignModalPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactManager.Models.AssignmentModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AssignModalPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 599, true);
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""add-course"" tabindex=""-1"" role=""dialog"" aria-labelledby=""assignCourseLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""assignCourseLabel"">Assign Course</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(645, 1359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1b113c3899b4820be2cd4c1aaef73a0", async() => {
                BeginContext(689, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(712, 31, false);
#line 14 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
               Write(Html.HiddenFor(x => x.CourseId));

#line default
#line hidden
                EndContext();
                BeginContext(743, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(766, 33, false);
#line 15 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
               Write(Html.HiddenFor(x => x.CourseName));

#line default
#line hidden
                EndContext();
                BeginContext(799, 426, true);
                WriteLiteral(@"
                    
                    <table id=""courses-table"" class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    Usename
                                </th>
                                <th>Assign</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 27 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                             for (int i = 0; i < Model.Users.Count; i++)
                            {

#line default
#line hidden
                BeginContext(1330, 66, true);
                WriteLiteral("                            <tr>\r\n                                ");
                EndContext();
                BeginContext(1397, 40, false);
#line 30 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                           Write(Html.HiddenFor(x => x.Users[i].Username));

#line default
#line hidden
                EndContext();
                BeginContext(1437, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1472, 38, false);
#line 31 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                           Write(Html.HiddenFor(x => x.Users[i].UserId));

#line default
#line hidden
                EndContext();
                BeginContext(1510, 76, true);
                WriteLiteral("\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(1587, 53, false);
#line 33 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Users[i].Username));

#line default
#line hidden
                EndContext();
                BeginContext(1640, 115, true);
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(1756, 54, false);
#line 36 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                               Write(Html.CheckBoxFor(modelItem => Model.Users[i].Assigned));

#line default
#line hidden
                EndContext();
                BeginContext(1810, 76, true);
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 39 "C:\Users\garyt\Downloads\starter2.1\starter2.1\Pages\Courses\_AssignModalPartial.cshtml"
                            }

#line default
#line hidden
                BeginContext(1917, 80, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2004, 312, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" data-save=""modal"">Save</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactManager.Models.AssignmentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591