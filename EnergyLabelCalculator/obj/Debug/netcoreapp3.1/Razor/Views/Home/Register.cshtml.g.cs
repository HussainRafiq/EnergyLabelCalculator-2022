#pragma checksum "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf9c609e0af90d667eae4e07ce0e3bbbdf00a7cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf9c609e0af90d667eae4e07ce0e3bbbdf00a7cf", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e61f021c354de39099bd65983eaa22633a4e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
   ViewData["Title"] = localizer["Register"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    #upload {
        opacity: 0;
    }

    #upload-label {
        position: absolute;
        top: 50%;
        left: 1rem;
        transform: translateY(-50%);
    }

    .image-area {
        border: 2px dashed rgba(255, 255, 255, 0.7);
        position: relative;
    }

        .image-area::before {
            content: '");
#nullable restore
#line 24 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                 Write(localizer["Uploadedimageresult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            color: #fff;
            font-weight: bold;
            text-transform: uppercase;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            font-size: 0.8rem;
            z-index: 1;
        }
    .image-area img {
        z-index: 2;
        position: relative;
    }
</style>
<style>
    .select2-container--default .select2-selection--single {
        background-color: transparent !important;
        border: none !important;
    }
</style>
<div class=""row"">

    <div class=""col-3"" style=""text-align:center""></div>
    <div class=""col-6"" style=""text-align:center"">

        <h3>");
#nullable restore
#line 51 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
       Write(localizer["Register"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 52 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
         if (ViewBag.Error != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-danger\">");
#nullable restore
#line 54 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                              Write(localizer[ViewBag.Error]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 54 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
         if (ViewBag.Success != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-danger\">");
#nullable restore
#line 57 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                              Write(localizer[ViewBag.Success]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 57 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf9c609e0af90d667eae4e07ce0e3bbbdf00a7cf8001", async() => {
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 61 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
             if (ViewBag.Companies != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                 foreach (DataRow dr in ViewBag.Companies.Rows)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("id", " id=\"", 1731, "\"", 1756, 2);
                WriteAttributeValue("", 1736, "CompanyBox_", 1736, 11, true);
#nullable restore
#line 65 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 1747, dr["ID"], 1747, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"CompanyBox\" style=\"display:none; text-align:center\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1847, "\"", 1872, 2);
                WriteAttributeValue("", 1853, "/", 1853, 1, true);
#nullable restore
#line 66 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 1854, dr["CompanyLogo"], 1854, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"150\" class=\"col-md-2 col-sm-4\" />\r\n\r\n                    </div>");
#nullable restore
#line 68 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""input-group mb-3  rounded-pill bg-white shadow-sm"">
                <select name=""CompanyID"" onchange=""$('.CompanyBox').hide(); if (this.value.toString() != '0') { $('#CompanyBox_' + this.value).show(); }"" class=""Company-Select form-control border-0 rounded-pill bg-white shadow-sm"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf9c609e0af90d667eae4e07ce0e3bbbdf00a7cf10687", async() => {
#nullable restore
#line 71 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
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
                WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                     if (ViewBag.Companies != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                         foreach (DataRow dr in ViewBag.Companies.Rows)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf9c609e0af90d667eae4e07ce0e3bbbdf00a7cf12710", async() => {
#nullable restore
#line 76 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
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
#line 76 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
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
                WriteLiteral("\r\n");
#nullable restore
#line 77 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                         }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\r\n\r\n\r\n\r\n\r\n                <input type=\"text\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2796, "\"", 2833, 1);
#nullable restore
#line 85 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 2810, localizer["FirstName"], 2810, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"FirstName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\r\n            </div>\r\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\r\n\r\n\r\n                <input type=\"text\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3060, "\"", 3096, 1);
#nullable restore
#line 90 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 3074, localizer["LastName"], 3074, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"LastName\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\r\n\r\n            </div>\r\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\r\n\r\n                <input type=\"Email\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3323, "\"", 3356, 1);
#nullable restore
#line 95 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 3337, localizer["Email"], 3337, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Email\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\r\n            </div>\r\n            <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\r\n\r\n                <input type=\"Password\" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3581, "\"", 3617, 1);
#nullable restore
#line 99 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
WriteAttributeValue("", 3595, localizer["Password"], 3595, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Password\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\r\n\r\n            </div>\r\n\r\n            <div class=\"float-right\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">\r\n\r\n                    ");
#nullable restore
#line 106 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
               Write(localizer["Register"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>
    <div class=""col-3"" style=""text-align:center""></div>
</div>
<script>
    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {

                $('#imageResult').css(""width"", 200);
                $('#imageResult').css(""height"", 200);
                $('#imageResult')
                    .attr('src', e.target.result);
            };
            reader.readAsDataURL(input.files[0]);
        }
    }

    $(function () {
        $('#upload').on('change', function () {
            readURL(input);
        });
    });

    var input = document.getElementById('upload');
    var infoArea = document.getElementById('upload-label');

    input.addEventListener('change', showFileName);
    function showFileName(event) {
        var input = event.srcElement;
        var fileName = input.files[0].name;
        infoArea.textContent = '");
#nullable restore
#line 144 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Home\Register.cshtml"
                           Write(localizer["FileName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": \' + fileName;\r\n    }\r\n</script>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(document).ready(function () {\r\n            $(\'.Company-Select\').select2();\r\n        });\r\n    });\r\n</script>");
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
