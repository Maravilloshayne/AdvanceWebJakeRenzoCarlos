#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e66497d5a3cb71b7d1ba7efb76a7acd5fc32ac9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\_ViewImports.cshtml"
using AdvanceWebJakeRenzoCarlos.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\_ViewImports.cshtml"
using AdvanceWebJakeRenzoCarlos.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
using AdvanceWebJakeRenzoCarlos.Web.Infrastructures.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e66497d5a3cb71b7d1ba7efb76a7acd5fc32ac9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d30643385243c48d8165a70d126021241b7da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebJakeRenzoCarlos.Web.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Welcome to AdvanceWebWendhel";

#line default
#line hidden
            BeginContext(198, 101, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Users</h2>\r\n    <p>Here is a paged list of all the users</p>\r\n    ");
            EndContext();
            BeginContext(299, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7e0eacee7f54015a301b98ef130e068", async() => {
                BeginContext(343, 85, true);
                WriteLiteral("<button type=\"button\" class=\"btn\">Create User    <i class=\"fas fa-plus\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(432, 249, true);
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Email Address</th>\r\n                <th>Gender</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
              
                foreach (User user in Model.Users.Items)
                {

#line default
#line hidden
            BeginContext(774, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(829, 13, false);
#line 26 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                       Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(842, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(878, 17, false);
#line 27 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                       Write(user.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(895, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(931, 11, false);
#line 28 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                       Write(user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(942, 76, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1018, "\"", 1078, 6);
            WriteAttributeValue("", 1028, "confirmResetPassword(\'", 1028, 22, true);
#line 30 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1050, user.Id, 1050, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1058, "\',", 1058, 2, true);
            WriteAttributeValue(" ", 1060, "\'", 1061, 2, true);
#line 30 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1062, user.FullName, 1062, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1076, "\')", 1076, 2, true);
            EndWriteAttribute();
            BeginContext(1079, 127, true);
            WriteLiteral(" title=\"Reset Password\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-key\"></i></button></a>\r\n                            ");
            EndContext();
            BeginContext(1206, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970173531385492384c6319c5dcf1ecf", async() => {
                BeginContext(1270, 76, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-pen-square\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1215, "~/home/update-profile/", 1215, 22, true);
#line 31 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1237, user.Id, 1237, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1350, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                              
                                if (user.LoginStatus == AdvanceWebJakeRenzoCarlos.Web.Infrastructures.Data.Enums.LoginStatus.Active)
                                {

#line default
#line hidden
            BeginContext(1553, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1600, "\"", 1664, 6);
            WriteAttributeValue("", 1610, "confirmDeactivateAccount(\'", 1610, 26, true);
#line 35 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1636, user.Id, 1636, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1644, "\',", 1644, 2, true);
            WriteAttributeValue(" ", 1646, "\'", 1647, 2, true);
#line 35 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1648, user.FullName, 1648, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1662, "\')", 1662, 2, true);
            EndWriteAttribute();
            BeginContext(1665, 104, true);
            WriteLiteral(" title=\"Deactivate Account\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-lock\"></i></button></a>\r\n");
            EndContext();
#line 36 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1877, 47, true);
            WriteLiteral("                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1924, "\"", 1986, 6);
            WriteAttributeValue("", 1934, "confirmActivateAccount(\'", 1934, 24, true);
#line 39 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1958, user.Id, 1958, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1966, "\',", 1966, 2, true);
            WriteAttributeValue(" ", 1968, "\'", 1969, 2, true);
#line 39 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1970, user.FullName, 1970, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1984, "\')", 1984, 2, true);
            EndWriteAttribute();
            BeginContext(1987, 107, true);
            WriteLiteral(" title=\"Activate Account\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-lock-open\"></i></button></a>\r\n");
            EndContext();
#line 40 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2160, 39, true);
            WriteLiteral("                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2199, "\"", 2256, 6);
            WriteAttributeValue("", 2209, "confirmDeleteUser(\'", 2209, 19, true);
#line 42 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2228, user.Id, 2228, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2236, "\',", 2236, 2, true);
            WriteAttributeValue(" ", 2238, "\'", 2239, 2, true);
#line 42 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2240, user.FullName, 2240, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 2254, "\')", 2254, 2, true);
            EndWriteAttribute();
            BeginContext(2257, 158, true);
            WriteLiteral(" title=\"Delete User\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2449, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2842, "\"", 2872, 1);
#line 55 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2850, Model.Users.PageIndex, 2850, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2873, 354, true);
            WriteLiteral(@" class=""form-control"" style=""width:50px;"" onKeydown=""javascript: if(event.keyCode = 13 && isNaN(parseInt($(this).val())==false)) window.location='/home/index?pageIndex=' + (isNaN(parseInt($(this).val())) ? 1 : parseInt($(this).val()));"" /></li>
                            <li class=""page-item""><span class=""form-control-plaintext"">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(3228, 21, false);
#line 56 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Home\Index.cshtml"
                                                                                                       Write(Model.Users.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3249, 3741, true);
            WriteLiteral(@"&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><span aria-hidden=""true"">&laquo;</span></a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item""><a class=""page-link"" href=""#""><span aria-hidden=""true"">&raquo;</span></a></li>
                        </ul>
                    </nav>
                </td>
            </tr>
        </tfoot>

    </table>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-reset-password"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Reset Password</h5>
                <button type=""button"" class=""close");
            WriteLiteral(@""" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to reset the password of <span id=""modal-reset-password-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-reset-password-confirm""><button type=""button"" class=""btn btn-primary"">Reset Password</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-account-status"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title""><span class=""modal-account-status-label""></span> Account</h5>
                <button type=""button"" class=""close"" da");
            WriteLiteral(@"ta-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to <span class=""modal-account-status-label""></span> the account of <span id=""modal-account-status-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-account-status-confirm""><button type=""button"" class=""btn btn-primary""><span class=""modal-account-status-label""></span> Account</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-delete-user"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Delete User</h5>
                <button ");
            WriteLiteral(@"type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure you want to delete <span id=""modal-delete-user-username""></span>?</p>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" id=""modal-delete-user-confirm""><button type=""button"" class=""btn btn-primary"">Delete User</button></a>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(7011, 1330, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        function confirmResetPassword(userId, userName) {
            $(""#modal-reset-password-username"").html(userName);
            $(""#modal-reset-password-confirm"").attr(""href"", ""/home/reset-password/"" + userId);
            $(""#modal-reset-password"").modal(""show"");
        }

        function confirmActivateAccount(userId, userName) {
            $(""#modal-account-status-username"").html(userName);
            $("".modal-account-status-label"").html(""Activate"");
            $(""#modal-account-status-confirm"").attr(""href"", ""/home/change-status/Active/"" + userId);
            $(""#modal-account-status"").modal(""show"");
        }
        function confirmDeactivateAccount(userId, userName) {
            $(""#modal-account-status-username"").html(userName);
            $("".modal-account-status-label"").html(""Deactivate"");
            $(""#modal-account-status-confirm"").attr(""href"", ""/home/change-status/Locked/"" + userId);
            $(""#modal-account-status"").moda");
                WriteLiteral(@"l(""show"");
        }
        function confirmDeleteUser(userId, userName) {
            $(""#modal-delete-user-username"").html(userName);
            $(""#modal-delete-user-confirm"").attr(""href"", ""/home/delete/"" + userId);
            $(""#modal-delete-user"").modal(""show"");
        }


    </script>");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebJakeRenzoCarlos.Web.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
