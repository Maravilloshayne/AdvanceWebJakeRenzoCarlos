#pragma checksum "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3e384777232ae54da4acc69c0174e73c89eecc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_UpdatePrice), @"mvc.1.0.view", @"/Views/Category/UpdatePrice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/UpdatePrice.cshtml", typeof(AspNetCore.Views_Category_UpdatePrice))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e384777232ae54da4acc69c0174e73c89eecc7", @"/Views/Category/UpdatePrice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51d30643385243c48d8165a70d126021241b7da7", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_UpdatePrice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvanceWebJakeRenzoCarlos.Web.ViewModels.Categories.UpdatePriceViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/categories/update-price"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml"
  
    ViewData["Title"] = "UpdateContent";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(183, 28, true);
            WriteLiteral("\r\n<br />\r\n<h3>Update Price \"");
            EndContext();
            BeginContext(212, 10, false);
#line 8 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml"
             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(222, 65, true);
            WriteLiteral("\"</h3>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(287, 487, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e5b0ccefc24824a09e522a7c100c14", async() => {
                BeginContext(347, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(362, 24, false);
#line 13 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(386, 52, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"CategoryId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 438, "\"", 461, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml"
WriteAttributeValue("", 446, Model.ParentId, 446, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(462, 177, true);
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"Price\">Price</label>\r\n                <textarea id=\"price\" name=\"Price\" style=\"height:800px;width:700px;\">");
                EndContext();
                BeginContext(640, 11, false);
#line 17 "C:\Users\Shayne Maravillo\source\repos\AdvanceWebJakeRenzoCarlos\AdvanceWebJakeRenzoCarlos.Web\Views\Category\UpdatePrice.cshtml"
                                                                               Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(651, 116, true);
                WriteLiteral("</textarea>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(774, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvanceWebJakeRenzoCarlos.Web.ViewModels.Categories.UpdatePriceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591