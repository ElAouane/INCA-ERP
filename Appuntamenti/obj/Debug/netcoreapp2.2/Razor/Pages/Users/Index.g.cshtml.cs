#pragma checksum "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Appuntamenti.Pages.Users.Pages_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Users/Index.cshtml", typeof(Appuntamenti.Pages.Users.Pages_Users_Index), null)]
namespace Appuntamenti.Pages.Users
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef", @"/Pages/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9b2a1352c85765b9f9b1fbe96816d2a549cb488", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Users/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Appuntamenti.TagHelpers.PageLinkTagHelper __Appuntamenti_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(145, 4243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef8546", async() => {
                BeginContext(181, 226, true);
                WriteLiteral("\r\n        <br /> <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <h2 class=\"text-info\">Users List</h2>\r\n            </div>\r\n            <div class=\"col-md-6 text-right\">\r\n                ");
                EndContext();
                BeginContext(407, 133, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef9174", async() => {
                    BeginContext(488, 48, true);
                    WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp;Create New User");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(540, 307, true);
                WriteLiteral(@"
            </div>
        </div>

        <div style=""height:60px;"" class=""container"">
            <div class=""row"">
                <div class=""col-md-11"">
                    <div class=""row"" style=""padding-top:10px;"">
                        <div class=""col-md-4"">
                            ");
                EndContext();
                BeginContext(848, 108, false);
#line 24 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", placeholder = "Name..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(956, 110, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-4\">\r\n                            ");
                EndContext();
                BeginContext(1067, 114, false);
#line 27 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchSurname", new { htmlAttributes = new { @class = "form-control", placeholder = "Surname..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1181, 110, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-4\">\r\n                            ");
                EndContext();
                BeginContext(1292, 111, false);
#line 30 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control", placeholder = "E-mail..." } }));

#line default
#line hidden
                EndContext();
                BeginContext(1403, 807, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-md-1"">
                    <div class=""row"" style=""padding-top:10px; padding-right:20px;"">
                        <button type=""submit"" name=""submit"" value=""Search"" class=""btn btn-success form-control"">
                            <i class=""fas fa-search fa-1x""></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <br />
        <div class=""container "">
            <table class=""table table-striped border"">
                <thead class=""thead-light"">
                    <tr>
                        <th>
                            <i class=""fas fa-user""></i>
                            ");
                EndContext();
                BeginContext(2211, 59, false);
#line 51 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ActiveUsers[0].Name));

#line default
#line hidden
                EndContext();
                BeginContext(2270, 148, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            <i class=\"fas fa-user\"></i>\r\n                            ");
                EndContext();
                BeginContext(2419, 62, false);
#line 55 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ActiveUsers[0].Surname));

#line default
#line hidden
                EndContext();
                BeginContext(2481, 152, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            <i class=\"fas fa-envelope\"></i>\r\n                            ");
                EndContext();
                BeginContext(2634, 60, false);
#line 59 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.UsersListVM.ActiveUsers[0].Email));

#line default
#line hidden
                EndContext();
                BeginContext(2694, 160, true);
                WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n\r\n\r\n");
                EndContext();
#line 67 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                 foreach (var item in Model.UsersListVM.ActiveUsers)
                {

#line default
#line hidden
                BeginContext(2943, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3028, 31, false);
#line 71 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(3059, 95, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3155, 34, false);
#line 76 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Surname));

#line default
#line hidden
                EndContext();
                BeginContext(3189, 95, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3285, 32, false);
#line 81 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                       Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3317, 130, true);
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td></td>\r\n\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(3447, 187, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef17361", async() => {
                    BeginContext(3539, 91, true);
                    WriteLiteral("\r\n                                <i class=\"fas fa-edit\"></i>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 87 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
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
                BeginContext(3634, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3664, 179, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef20075", async() => {
                    BeginContext(3743, 96, true);
                    WriteLiteral("\r\n                                <i class=\"far fa-trash-alt\"></i>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 90 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
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
                BeginContext(3843, 60, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 95 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(3922, 103, true);
                WriteLiteral("                <tr>\r\n                    <td colspan=\"5\" class=\"text-right\">\r\n                        ");
                EndContext();
                BeginContext(4025, 253, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab3cead8fddbeaefe5bb81adeffcfb3e7a645ef23181", async() => {
                    BeginContext(4244, 28, true);
                    WriteLiteral("\r\n\r\n                        ");
                    EndContext();
                }
                );
                __Appuntamenti_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Appuntamenti.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__Appuntamenti_TagHelpers_PageLinkTagHelper);
#line 98 "C:\Users\Hamza\Desktop\INCA-ERP\INCA-ERP\Appuntamenti\Pages\Users\Index.cshtml"
__Appuntamenti_TagHelpers_PageLinkTagHelper.PageModel = Model.UsersListVM.PaginationInfo;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Appuntamenti_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Appuntamenti_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Appuntamenti_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Appuntamenti_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4278, 103, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n       \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4388, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Appuntamenti.Pages.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Appuntamenti.Pages.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Appuntamenti.Pages.Users.IndexModel>)PageContext?.ViewData;
        public Appuntamenti.Pages.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
