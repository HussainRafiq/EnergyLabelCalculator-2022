#pragma checksum "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48f15a1eb3df0ed0617de6a0aed4fb1bb8ba617b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\_ViewImports.cshtml"
using Multilingual.ASPNETCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\_ViewImports.cshtml"
using Multilingual.ASPNETCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48f15a1eb3df0ed0617de6a0aed4fb1bb8ba617b", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e61f021c354de39099bd65983eaa22633a4e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
   ViewData["Title"] = "Login"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
  if (ViewBag.Companies != null)
             {
               

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                foreach (DataRow dr in ViewBag.Companies.Rows)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div");
            BeginWriteAttribute("id", " id=\"", 273, "\"", 298, 2);
            WriteAttributeValue("", 278, "CompanyBox_", 278, 11, true);
#nullable restore
#line 8 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
WriteAttributeValue("", 289, dr["ID"], 289, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"CompanyBox\" style=\"display:none; text-align:center\">\n                     <img");
            BeginWriteAttribute("src", "  src=\"", 385, "\"", 411, 2);
            WriteAttributeValue("", 392, "/", 392, 1, true);
#nullable restore
#line 9 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
WriteAttributeValue("", 393, dr["CompanyLogo"], 393, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\"  class=\"col-md-2 col-sm-4\"/>\n                    \n                 </div>\n");
#nullable restore
#line 12 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(" <style>\r\n     .select2-container--default .select2-selection--single {\r\n         background-color: transparent !important;\r\n         border: none !important;\r\n     }\n </style>\n<div class=\"text-center\">\n   \n    <h2 class=\"display-4\">");
#nullable restore
#line 22 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                     Write(localizer["Welcome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <div class=\"row\">\n        <div class=\"col-3\">\n\n        </div>\n        <div class=\"col-6\">\n");
#nullable restore
#line 28 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
             if (ViewBag.Error != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-danger\">");
#nullable restore
#line 30 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                          Write(localizer[ViewBag.Error]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>            ");
#nullable restore
#line 30 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
             if (TempData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-success\">");
#nullable restore
#line 33 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                           Write(localizer[TempData["Success"].ToString()]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 33 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48f15a1eb3df0ed0617de6a0aed4fb1bb8ba617b8591", async() => {
                WriteLiteral(@"
                <div class=""input-group mb-3  rounded-pill bg-white shadow-sm"">
                    <select name=""CompanyID"" onchange=""$('.CompanyBox').hide(); if (this.value.toString() != '0') { $('#CompanyBox_' + this.value).show(); }"" class=""Company-Select form-control border-0 rounded-pill bg-white shadow-sm"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48f15a1eb3df0ed0617de6a0aed4fb1bb8ba617b9195", async() => {
#nullable restore
#line 37 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                     Write(localizer["SelectCompany"]);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\n");
#nullable restore
#line 38 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                         if (ViewBag.Companies != null)
                        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
             foreach (DataRow dr in ViewBag.Companies.Rows)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48f15a1eb3df0ed0617de6a0aed4fb1bb8ba617b11158", async() => {
#nullable restore
#line 42 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                             Write(dr["CompanyName"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
           WriteLiteral(dr["ID"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 42 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\n                </div>\n                <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n                    <input type=\"Email\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1982, "\"", 2015, 1);
#nullable restore
#line 46 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
WriteAttributeValue("", 1996, localizer["Email"], 1996, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Email\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\n                </div>\n                <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n                    <input type=\"Password\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2247, "\"", 2283, 1);
#nullable restore
#line 49 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
WriteAttributeValue("", 2261, localizer["Password"], 2261, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Password\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\n                </div>\n                <div style=\"text-align:right\">\n                    <a href=\"\\Home\\ForgotPassword\">");
#nullable restore
#line 52 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                              Write(localizer["ForgotPassword"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n                </div>\n                <br />\n                <button type=\"submit\" class=\"btn btn-dark\">");
#nullable restore
#line 55 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                      Write(localizer["LoginButtonTitle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <br />\n            <a href=\"/Home/Register\" class=\"btn btn-dark\">");
#nullable restore
#line 59 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Login.cshtml"
                                                     Write(localizer["RegisterButtonTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </div>\n        <div class=\"col-3\">\n\n        </div>\n    </div>\n    \n</div>\n<script>\n    $(document).ready(function () {\n        $(document).ready(function () {\r\n            $(\'.Company-Select\').select2();\r\n        });\n    });\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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
