#pragma checksum "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c29ef81c042ff7cfd6545b6e83ec57d8be64d49b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Appuntamenti.Pages.AdminTask.Pages_AdminTask_Tasks), @"mvc.1.0.razor-page", @"/Pages/AdminTask/Tasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminTask/Tasks.cshtml", typeof(Appuntamenti.Pages.AdminTask.Pages_AdminTask_Tasks), null)]
namespace Appuntamenti.Pages.AdminTask
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\_ViewImports.cshtml"
using Appuntamenti;

#line default
#line hidden
#line 3 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\_ViewImports.cshtml"
using Appuntamenti.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29ef81c042ff7cfd6545b6e83ec57d8be64d49b", @"/Pages/AdminTask/Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b2a1352c85765b9f9b1fbe96816d2a549cb488", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminTask_Tasks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
  
    ViewData["Title"] = "Tasks";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 225, true);
            WriteLiteral("\r\n<br/>\r\n<br />\r\n<div class=\"container border\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h2 class=\"text-info\">Task Name</h2>\r\n        </div>\r\n        <div class=\"col-md-6 text-right\">\r\n            ");
            EndContext();
            BeginContext(368, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29ef81c042ff7cfd6545b6e83ec57d8be64d49b6553", async() => {
                BeginContext(418, 43, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp;Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(465, 88, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n\r\n    <br />\r\n    <div>\r\n");
            EndContext();
#line 24 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
         if (Model.AdminTasks.Count == 0)
        {

#line default
#line hidden
            BeginContext(607, 110, true);
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            No Admin Task Available.\r\n        </div>\r\n");
            EndContext();
#line 29 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(753, 178, true);
            WriteLiteral("            <table class=\"table table-striped\">\r\n                <thead class=\"thead-light\">\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(932, 46, false);
#line 36 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                       Write(Html.DisplayNameFor(m => m.AdminTasks[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(978, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1070, 53, false);
#line 39 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                       Write(Html.DisplayNameFor(m => m.AdminTasks[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1215, 46, false);
#line 42 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                       Write(Html.DisplayNameFor(m => m.AdminTasks[0].Date));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 121, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n");
            EndContext();
#line 47 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                 foreach(var item in Model.AdminTasks)
                {

#line default
#line hidden
            BeginContext(1457, 61, true);
            WriteLiteral("             <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1519, 31, false);
#line 51 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1618, 38, false);
#line 54 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
               Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 68, true);
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
            EndContext();
            BeginContext(1725, 31, false);
#line 57 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
               Write(Html.DisplayFor(m => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 151, true);
            WriteLiteral("\r\n                 </td>\r\n                <td style=\"width:150px;\">\r\n                    <div class=\"btn-group\" role=\"group\">\r\n                        ");
            EndContext();
            BeginContext(1907, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29ef81c042ff7cfd6545b6e83ec57d8be64d49b12213", async() => {
                BeginContext(1990, 83, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2077, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2103, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29ef81c042ff7cfd6545b6e83ec57d8be64d49b14782", async() => {
                BeginContext(2189, 83, true);
                WriteLiteral("\r\n                            <i class=\"fas fa-list\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2276, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2302, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c29ef81c042ff7cfd6545b6e83ec57d8be64d49b17354", async() => {
                BeginContext(2381, 88, true);
                WriteLiteral("\r\n                            <i class=\"far fa-trash-alt\"></i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2473, 73, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n             </tr>\r\n");
            EndContext();
#line 73 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
                }

#line default
#line hidden
            BeginContext(2565, 22, true);
            WriteLiteral("            </table>\r\n");
            EndContext();
#line 75 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\AdminTask\Tasks.cshtml"
        }

#line default
#line hidden
            BeginContext(2598, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Appuntamenti.Pages.AdminTask.TasksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Appuntamenti.Pages.AdminTask.TasksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Appuntamenti.Pages.AdminTask.TasksModel>)PageContext?.ViewData;
        public Appuntamenti.Pages.AdminTask.TasksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591