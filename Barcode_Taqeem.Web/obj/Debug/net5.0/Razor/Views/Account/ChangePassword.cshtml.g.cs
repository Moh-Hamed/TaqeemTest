#pragma checksum "E:\7-3-2021\version 3\Barcode_Taqeem\Barcode_Taqeem.Web\Views\Account\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094ea6b0f0b13ad716aa9608ea3a75517e06b661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ChangePassword), @"mvc.1.0.view", @"/Views/Account/ChangePassword.cshtml")]
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
#nullable restore
#line 1 "E:\7-3-2021\version 3\Barcode_Taqeem\Barcode_Taqeem.Web\Views\_ViewImports.cshtml"
using Barcode_Taqeem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\7-3-2021\version 3\Barcode_Taqeem\Barcode_Taqeem.Web\Views\_ViewImports.cshtml"
using Barcode_Taqeem.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094ea6b0f0b13ad716aa9608ea3a75517e06b661", @"/Views/Account/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f97b45c088697fccf319e7dbd9b3beda4b40d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-forgot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\7-3-2021\version 3\Barcode_Taqeem\Barcode_Taqeem.Web\Views\Account\ChangePassword.cshtml"
  
    ViewData["Title"] = "ChangePassword";
    Layout = "~/Views/Shared/_TaqeemLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- start: FORGOT -->\r\n<div class=\"row\">\r\n    <div class=\"main-login col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-4 col-md-offset-4\">\r\n\r\n        <!-- start: FORGOT BOX -->\r\n        <div class=\"box-forgot\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094ea6b0f0b13ad716aa9608ea3a75517e06b6614202", async() => {
                WriteLiteral(@"
                <fieldset>
                    <legend>
                        ?????????? ???????? ????????
                    </legend>

                    <div class=""form-group"">
                        <span class=""input-icon"">
                            <input type=""text"" class=""form-control"" name=""OldPassword"" placeholder=""???????? ???????? ?????????????? *"">
                        </span>
                    </div>
                    <div class=""form-group"">
                        <span class=""input-icon"">
                            <input type=""text"" class=""form-control"" name=""NewPassword"" placeholder=""???????? ???????? ?????????????? *"">
                        </span>
                    </div>
                    <div class=""form-group"">
                        <span class=""input-icon"">
                            <input type=""text"" class=""form-control"" name=""NewPassword"" placeholder=""?????????? ???????? ???????? ?????????????? *"">
                        </span>
                    </div>
                    <div class=""form-acti");
                WriteLiteral(@"ons"">
                        <button type=""submit"" class=""btn btn-primary pull-right"">
                            ?????????? <i class=""fa fa-arrow-circle-left""></i>
                        </button>
                    </div>
                </fieldset>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <!-- end: FORGOT BOX -->\r\n    </div>\r\n</div>\r\n\r\n<!-- start: FOOTER -->\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
