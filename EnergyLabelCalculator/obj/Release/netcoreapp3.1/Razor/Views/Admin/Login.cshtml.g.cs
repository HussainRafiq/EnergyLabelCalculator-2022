#pragma checksum "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc20bc20a9599c518583c9c82507a3d471587e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc20bc20a9599c518583c9c82507a3d471587e7", @"/Views/Admin/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e61f021c354de39099bd65983eaa22633a4e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
   ViewData["Title"] = "Admin Login"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    ");
            WriteLiteral(@"@import url(https://fonts.googleapis.com/css?family=Open+Sans);

    .btn {
        display: inline-block;
        *display: inline;
        *zoom: 1;
        padding: 4px 10px 4px;
        margin-bottom: 0;
        font-size: 13px;
        line-height: 18px;
        color: #333333;
        text-align: center;
        text-shadow: 0 1px 1px rgba(255, 255, 255, 0.75);
        vertical-align: middle;
        background-color: #f5f5f5;
        background-image: -moz-linear-gradient(top, #ffffff, #e6e6e6);
        background-image: -ms-linear-gradient(top, #ffffff, #e6e6e6);
        background-image: -webkit-gradient(linear, 0 0, 0 100%, from(#ffffff), to(#e6e6e6));
        background-image: -webkit-linear-gradient(top, #ffffff, #e6e6e6);
        background-image: -o-linear-gradient(top, #ffffff, #e6e6e6);
        background-image: linear-gradient(top, #ffffff, #e6e6e6);
        background-repeat: repeat-x;
        filter: progid:dximagetransform.microsoft.gradient(startColorstr=#ffffff, endColorstr=#e6e6e6, Grad");
            WriteLiteral(@"ientType=0);
        border-color: #e6e6e6 #e6e6e6 #e6e6e6;
        border-color: rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.1) rgba(0, 0, 0, 0.25);
        border: 1px solid #e6e6e6;
        -webkit-border-radius: 4px;
        -moz-border-radius: 4px;
        border-radius: 4px;
        -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05);
        -moz-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05);
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.05);
        cursor: pointer;
        *margin-left: .3em;
    }

        .btn:hover, .btn:active, .btn.active, .btn.disabled, .btn[disabled] {
            background-color: #e6e6e6;
        }

    .btn-large {
        padding: 9px 14px;
        font-size: 15px;
        line-height: normal;
        -webkit-border-radius: 5px;
        -moz-border-radius: 5px;
        border-radius: 5px;
    }

    .btn:hover {
        color: #333333;
        text-decoration: none;
   ");
            WriteLiteral(@"     background-color: #e6e6e6;
        background-position: 0 -15px;
        -webkit-transition: background-position 0.1s linear;
        -moz-transition: background-position 0.1s linear;
        -ms-transition: background-position 0.1s linear;
        -o-transition: background-position 0.1s linear;
        transition: background-position 0.1s linear;
    }

    .btn-primary, .btn-primary:hover {
        text-shadow: 0 -1px 0 rgba(0, 0, 0, 0.25);
        color: #ffffff;
    }

        .btn-primary.active {
            color: rgba(255, 255, 255, 0.75);
        }

    .btn-primary {
        background-color: #4a77d4;
        background-image: -moz-linear-gradient(top, #6eb6de, #4a77d4);
        background-image: -ms-linear-gradient(top, #6eb6de, #4a77d4);
        background-image: -webkit-gradient(linear, 0 0, 0 100%, from(#6eb6de), to(#4a77d4));
        background-image: -webkit-linear-gradient(top, #6eb6de, #4a77d4);
        background-image: -o-linear-gradient(top, #6eb6de, #4a77d4);
        background-imag");
            WriteLiteral(@"e: linear-gradient(top, #6eb6de, #4a77d4);
        background-repeat: repeat-x;
        filter: progid:dximagetransform.microsoft.gradient(startColorstr=#6eb6de, endColorstr=#4a77d4, GradientType=0);
        border: 1px solid #3762bc;
        text-shadow: 1px 1px 1px rgba(0,0,0,0.4);
        box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.2), 0 1px 2px rgba(0, 0, 0, 0.5);
    }

        .btn-primary:hover, .btn-primary:active, .btn-primary.active, .btn-primary.disabled, .btn-primary[disabled] {
            filter: none;
            background-color: #4a77d4;
        }

    .btn-block {
        width: 100%;
        display: block;
    }

    * {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        -ms-box-sizing: border-box;
        -o-box-sizing: border-box;
        box-sizing: border-box;
    }

    html {
        width: 100%;
        height: 100%;
        overflow: hidden;
    }

    body {
        width: 100%;
        height: 100%;
        font-family: 'Open Sans', sans-seri");
            WriteLiteral(@"f;
        background: #092756;
        background: -moz-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%),-moz-linear-gradient(top, rgba(57,173,219,.25) 0%, rgba(42,60,87,.4) 100%), -moz-linear-gradient(-45deg, #670d10 0%, #092756 100%);
        background: -webkit-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -webkit-linear-gradient(top, rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -webkit-linear-gradient(-45deg, #670d10 0%,#092756 100%);
        background: -o-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -o-linear-gradient(top, rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -o-linear-gradient(-45deg, #670d10 0%,#092756 100%);
        background: -ms-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), -ms-linear-gradient(top, rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), -ms-linear-gradient(-45deg, #670d10 0%,#092756 100%);
        bac");
            WriteLiteral(@"kground: -webkit-radial-gradient(0% 100%, ellipse cover, rgba(104,128,138,.4) 10%,rgba(138,114,76,0) 40%), linear-gradient(to bottom, rgba(57,173,219,.25) 0%,rgba(42,60,87,.4) 100%), linear-gradient(135deg, #670d10 0%,#092756 100%);
        filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#3E1D6D', endColorstr='#092756',GradientType=1 );
    }

    .login {
        position: absolute;
        top: 50%;
        left: 50%;
        margin: -150px 0 0 -150px;
        width: 300px;
        height: 300px;
    }

        .login h2 {
            color: #fff;
            text-shadow: 0 0 10px rgba(0,0,0,0.3);
            letter-spacing: 1px;
            text-align: center;
        }

    input {
        width: 100%;
        margin-bottom: 10px;
        background: rgba(0,0,0,0.3);
        border: none;
        outline: none;
        padding: 10px;
        font-size: 13px;
        color: #fff;
        text-shadow: 1px 1px 1px rgba(0,0,0,0.3);
        border: 1px solid rgba(0,0,0,0.3);
        border-r");
            WriteLiteral(@"adius: 4px;
        box-shadow: inset 0 -5px 45px rgba(100,100,100,0.2), 0 1px 1px rgba(255,255,255,0.2);
        -webkit-transition: box-shadow .5s ease;
        -moz-transition: box-shadow .5s ease;
        -o-transition: box-shadow .5s ease;
        -ms-transition: box-shadow .5s ease;
        transition: box-shadow .5s ease;
    }

        input:focus {
            box-shadow: inset 0 -5px 45px rgba(100,100,100,0.4), 0 1px 1px rgba(255,255,255,0.2);
        }
</style>
<div class=""login"">
    <h2>");
#nullable restore
#line 167 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
   Write(localizer["LoginTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbc20bc20a9599c518583c9c82507a3d471587e710899", async() => {
                WriteLiteral("\n        <input type=\"email\" name=\"email\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6868, "\"", 6904, 1);
#nullable restore
#line 169 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
WriteAttributeValue("", 6882, localizer["Username"], 6882, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required=\"required\" />\n        <input type=\"password\" name=\"password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6975, "\"", 7011, 1);
#nullable restore
#line 170 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
WriteAttributeValue("", 6989, localizer["Password"], 6989, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required=\"required\" />\n        <button type=\"submit\" class=\"btn btn-primary btn-block btn-large\">");
#nullable restore
#line 171 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
                                                                     Write(localizer["LoginButtonTitle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n        <br />\n");
#nullable restore
#line 173 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
         if (ViewBag.Error != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"alert-danger\">");
#nullable restore
#line 175 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
                     Write(localizer[ViewBag.Error]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>");
#nullable restore
#line 175 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Login.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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