#pragma checksum "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb05606de47fa7aa3561d9485f5bb22819639f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddUser), @"mvc.1.0.view", @"/Views/Admin/AddUser.cshtml")]
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
#line 1 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb05606de47fa7aa3561d9485f5bb22819639f2f", @"/Views/Admin/AddUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e61f021c354de39099bd65983eaa22633a4e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
   ViewData["Title"] = localizer["Admin"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    .select2-container--default .select2-selection--single {\n        background-color: transparent !important;\n        border: none !important;\n    }\n</style>\n<div class=\"row\">\n    <div class=\"col-lg-6\">\n");
#nullable restore
#line 13 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
         if (ViewBag.Data != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 15 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
Write(localizer["UpdateUser"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 15 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                  }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 18 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
Write(localizer["AddUser"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
#nullable restore
#line 18 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
         if (ViewBag.Error != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-danger\">");
#nullable restore
#line 21 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                  Write(localizer[ViewBag.Error]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 21 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
         if (ViewBag.Success != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-danger\">");
#nullable restore
#line 24 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                  Write(localizer[ViewBag.Success]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 24 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb05606de47fa7aa3561d9485f5bb22819639f2f7738", async() => {
                WriteLiteral("\n\n");
#nullable restore
#line 27 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
             if (ViewBag.Data != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"hidden\" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 855, "\"", 882, 1);
#nullable restore
#line 29 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 863, ViewBag.Data["ID"], 863, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 29 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n\n\n\n");
#nullable restore
#line 36 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                 if (ViewBag.Data != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1052, "\"", 1086, 1);
#nullable restore
#line 38 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1060, ViewBag.Data["FirstName"], 1060, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1096, "\"", 1133, 1);
#nullable restore
#line 38 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1110, localizer["FirstName"], 1110, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FirstName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\"> ");
#nullable restore
#line 38 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                                                                         }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"text\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1251, "\"", 1288, 1);
#nullable restore
#line 41 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1265, localizer["FirstName"], 1265, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FirstName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">");
#nullable restore
#line 41 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n\n");
#nullable restore
#line 45 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                 if (ViewBag.Data != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1550, "\"", 1583, 1);
#nullable restore
#line 47 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1558, ViewBag.Data["LastName"], 1558, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1593, "\"", 1629, 1);
#nullable restore
#line 47 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1607, localizer["LastName"], 1607, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"LastName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\"> ");
#nullable restore
#line 47 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                                                                      }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"text\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1746, "\"", 1782, 1);
#nullable restore
#line 50 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 1760, localizer["LastName"], 1760, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"LastName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">");
#nullable restore
#line 50 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n");
#nullable restore
#line 54 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                 if (ViewBag.Data != null)
                {
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"Email\"  required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2110, "\"", 2143, 1);
#nullable restore
#line 59 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 2124, localizer["Email"], 2124, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Email\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">");
#nullable restore
#line 59 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n");
#nullable restore
#line 62 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                 if (ViewBag.Data != null)
                { }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"Password\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2454, "\"", 2490, 1);
#nullable restore
#line 66 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 2468, localizer["Password"], 2468, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Password\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">");
#nullable restore
#line 66 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                                                                                                                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n");
#nullable restore
#line 69 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
             if (ViewBag.Companies != null)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
 foreach (DataRow dr in ViewBag.Companies.Rows)
{

#line default
#line hidden
#nullable disable
                WriteLiteral("<div");
                BeginWriteAttribute("id", " id=\"", 2704, "\"", 2729, 2);
                WriteAttributeValue("", 2709, "CompanyBox_", 2709, 11, true);
#nullable restore
#line 73 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 2720, dr["ID"], 2720, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"CompanyBox\" style=\"display:none; text-align:center\">\n    <img");
                BeginWriteAttribute("src", " src=\"", 2799, "\"", 2824, 2);
                WriteAttributeValue("", 2805, "/", 2805, 1, true);
#nullable restore
#line 74 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
WriteAttributeValue("", 2806, dr["CompanyLogo"], 2806, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"150\" class=\"col-md-2 col-sm-4\" />\n\n</div>");
#nullable restore
#line 76 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
       }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""input-group mb-3  rounded-pill bg-white shadow-sm"">
                <select name=""CompanyID"" onchange=""$('.CompanyBox').hide(); if (this.value.toString() != '0') { $('#CompanyBox_' + this.value).show(); }"" class=""Company-Select form-control border-0 rounded-pill bg-white shadow-sm"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb05606de47fa7aa3561d9485f5bb22819639f2f18920", async() => {
#nullable restore
#line 79 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
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
#line 80 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                     if (ViewBag.Companies != null)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
         foreach (DataRow dr in ViewBag.Companies.Rows)
        {

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb05606de47fa7aa3561d9485f5bb22819639f2f20826", async() => {
#nullable restore
#line 84 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
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
#line 84 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
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
#line 84 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\n            </div>\n            <div class=\"float-right\">\n                <button type=\"submit\" class=\"btn btn-primary\">\n");
#nullable restore
#line 89 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                     if (ViewBag.Data != null)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
   Write(localizer["UpdateUser"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                                 }
    else
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
Write(localizer["AddUser"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </button>\n            </div>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\AddUser.cshtml"
AddHtmlAttributeValue("", 708, Url.Action("AddUser","Admin"), 708, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n</div>\n<script>\n    $(document).ready(function () {\n        $(document).ready(function () {\n            $(\'.Company-Select\').select2();\n        });\n    });\n</script>");
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
