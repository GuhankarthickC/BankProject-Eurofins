#pragma checksum "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1813eb7bc7b576cc9b1e82493c6612a2a7db7e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankInformation_Index), @"mvc.1.0.view", @"/Views/BankInformation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1813eb7bc7b576cc9b1e82493c6612a2a7db7e09", @"/Views/BankInformation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6575fb88346730d0c2409e0370e19673122dc5c", @"/Views/_ViewImports.cshtml")]
    public class Views_BankInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankProj.BankApplication.BankInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Credit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Debit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Debit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
  
    ViewData["Title"] = "Payment's Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e094912", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#myselection').on('change', function () {
                var demovalue = $(this).val();
                $("".myDiv"").hide();
                $(""#show"" + demovalue).show();
            });
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h2 class=\"text-md-center\">");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"form-group row\">\r\n    <label for=\"inputselect\" class=\"col-sm-3 col-form-label\">Enter the Type of Transaction</label>\r\n    <div class=\"col-sm-3\">\r\n        <select id=\"myselection\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e096769", async() => {
                WriteLiteral("Select Option");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e097746", async() => {
                WriteLiteral("Credit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e098917", async() => {
                WriteLiteral("Debit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
</div>
<div id=""showCredit"" class=""myDiv"" style=""display:none"">
    <div class=""row"">
        <div class=""col-4"">
            <h3 class=""text-center"">Your Account</h3>
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr><th scope=""row"">Account Number</th><td>");
#nullable restore
#line 41 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                          Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Bank Name</th><td>");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                     Write(Html.DisplayFor(model => model.BankName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Account Type</th><td> ");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                         Write(Html.DisplayFor(model => model.AccountType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">IFSC Code</th><td>");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                     Write(Html.DisplayFor(model => model.Ifsccode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Balance</th><td>");
#nullable restore
#line 45 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                   Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e0912314", async() => {
                WriteLiteral(@"
                <label for=""creditamount"" class=""control-label"">Enter the amount to be credited</label>
                <input id=""creditamount"" type=""number"" class=""form-control"" name=""creditamount"" /><br />
                <div class=""text-md-center"">
                    <input type=""submit"" value=""Credit"" class=""btn btn-warning"" onclick=""return alert('Amount credited successfully');"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<div id=""showDebit"" class=""myDiv"" style=""display:none"">
    <div class=""row"">
        <div class=""col-4"">
            <h3 class=""text-center"">Sender's Account</h3>
            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr><th scope=""row"">Account Number</th><td>");
#nullable restore
#line 66 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                          Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Bank Name</th><td>");
#nullable restore
#line 67 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                     Write(Html.DisplayFor(model => model.BankName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Account Type</th><td> ");
#nullable restore
#line 68 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                         Write(Html.DisplayFor(model => model.AccountType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">IFSC Code</th><td>");
#nullable restore
#line 69 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                     Write(Html.DisplayFor(model => model.Ifsccode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><th scope=\"row\">Balance</th><td>");
#nullable restore
#line 70 "C:\Users\Admin\source\repos\BankProj\Views\BankInformation\Index.cshtml"
                                                   Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <h3 class=\"text-center\">Receiver\'s Account</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1813eb7bc7b576cc9b1e82493c6612a2a7db7e0916505", async() => {
                WriteLiteral(@"
                <table class=""table"">
                    <thead class=""thead-dark"">
                        <tr><th scope=""row"">Account Number</th><td><input id=""accno"" type=""number"" class=""form-control"" name=""accno"" /></td></tr>
                        <tr><th scope=""row"">Bank Name</th><td><input id=""bankname"" type=""text"" class=""form-control"" name=""bankname"" /></td></tr>
                        <tr><th scope=""row"">IFSC Code</th><td><input id=""ifsc"" type=""text"" class=""form-control"" name=""ifsc"" /></td></tr>
                        <tr><th scope=""row"">Receiver's Name</th><td><input id=""receivername"" type=""text"" class=""form-control"" name=""receivername"" /></td></tr>
                        <tr><th scope=""row"">Amount to sent</th><td><input id=""debitamount"" type=""number"" class=""form-control"" name=""debitamount"" /></td></tr>
                    </thead>
                </table>
                <div class=""text-md-center"">
                    <input type=""submit"" value=""Send"" class=""btn btn-warning"" oncli");
                WriteLiteral("ck=\"return alert(\'Amount debited successfully\');\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankProj.BankApplication.BankInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
