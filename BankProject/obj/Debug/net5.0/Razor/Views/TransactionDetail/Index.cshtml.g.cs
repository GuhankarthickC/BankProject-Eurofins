#pragma checksum "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d00edbc79ed5e591427e5af36015afb6fbe7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TransactionDetail_Index), @"mvc.1.0.view", @"/Views/TransactionDetail/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\BankProj\Views\_ViewImports.cshtml"
using BankProj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\BankProj\Views\_ViewImports.cshtml"
using BankProj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d00edbc79ed5e591427e5af36015afb6fbe7c4", @"/Views/TransactionDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6575fb88346730d0c2409e0370e19673122dc5c", @"/Views/_ViewImports.cshtml")]
    public class Views_TransactionDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankProj.BankApplication.TransactionDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TransactionDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d00edbc79ed5e591427e5af36015afb6fbe7c44223", async() => {
                WriteLiteral("\r\n    <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" name=\"id\" aria-label=\"Search\">\r\n    <button id=\"myselection\" class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
 if (Model.MadeBy == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-md-center\">Kindly enter a valid Transaction ID</h4>\r\n");
#nullable restore
#line 13 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
}
else if (Model.TransactionId == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text-md-center\">Result Not Found</h4>\r\n");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"myDiv\">\r\n        <h1>");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
       Write(Model.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
                            Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
                                        Write(Model.MadeBy);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
                                                      Write(Model.MadeTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
                                                                    Write(Model.TransactionAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\BankProj\Views\TransactionDetail\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankProj.BankApplication.TransactionDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
