#pragma checksum "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34913de4d2ca6e594d20fb0c40bb1f14ab08121d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34913de4d2ca6e594d20fb0c40bb1f14ab08121d", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e61f021c354de39099bd65983eaa22633a4e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
   ViewData["Title"] = localizer["Admin"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12 col-sm-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34913de4d2ca6e594d20fb0c40bb1f14ab08121d4061", async() => {
                WriteLiteral("\n            <h3>");
#nullable restore
#line 9 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["Values"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\n            <br />\n            <div class=\"row\">\n                <div class=\"col-4\">\n                    <h6>");
#nullable restore
#line 13 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                   Write(localizer["AverageElectric"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 577, "\"", 643, 1);
#nullable restore
#line 15 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 585, ViewBag.Value!=null?ViewBag.Value["AverageElectric"]:"", 585, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 653, "\"", 696, 1);
#nullable restore
#line 15 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 667, localizer["AverageElectric"], 667, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"AverageElectric\" class=\"form-control border-0 rounded-pill bg-white shadow-sm\">\n                    </div>\n                </div>\n                <div class=\"col-4\">\n                    <h6>");
#nullable restore
#line 19 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                   Write(localizer["AverageGas"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n                    <div class=\"input-group mb-3  rounded-pill bg-white shadow-sm\">\n                        <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1052, "\"", 1113, 1);
#nullable restore
#line 21 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1060, ViewBag.Value!=null?ViewBag.Value["AverageGas"]:"", 1060, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1123, "\"", 1161, 1);
#nullable restore
#line 21 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1137, localizer["AverageGas"], 1137, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""AverageGas"" class=""form-control border-0 rounded-pill bg-white shadow-sm"">
                    </div>
                </div>

                <div class=""col-4"" style=""text-align:left;padding:20px;"">
                    
                    <button type=""submit"" class=""btn btn-sm btn-primary"">");
#nullable restore
#line 27 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                                                                    Write(localizer["MakeChange"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n                </div>\n            </div>\n\n               \n              \n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 8 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 229, Url.Action("SetValue","Admin"), 229, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"col-md-12\">\n        <h3>");
#nullable restore
#line 37 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
       Write(localizer["UsersList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 39 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
         if (TempData.Keys.Contains("SuccesMessage"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-success\">");
#nullable restore
#line 41 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                   Write(localizer[TempData["SuccesMessage"].ToString()]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 41 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
         if (TempData.Keys.Contains("Error"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"text-danger\">");
#nullable restore
#line 44 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                  Write(localizer[TempData["Error"].ToString()]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 44 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                                                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 46 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
         if (ViewBag.Companies != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"data-table\" class=\"table table-bordered table-responsive \" style=\"width:100%\">\n    <thead>\n        <tr>\n            <th style=\"width:15%\">\n                ");
#nullable restore
#line 52 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["FirstName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"width:15%\">\n                ");
#nullable restore
#line 55 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["LastName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"width:20%\">\n                ");
#nullable restore
#line 58 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"width:25%\">\n                ");
#nullable restore
#line 61 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["Company"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th style=\"width:25%\">\n                ");
#nullable restore
#line 64 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
           Write(localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n\n");
#nullable restore
#line 69 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
      DataTable data = ViewBag.Companies; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 72 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
     if (data != null && data.Rows.Count > 0)
    {
        foreach (DataRow dr in data.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tbody>\n    <tr>\n        <td>");
#nullable restore
#line 78 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
       Write(dr["FirstName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 79 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
       Write(dr["LastName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 80 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
       Write(dr["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td style=\"text-align:center\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 2897, "\"", 2922, 2);
            WriteAttributeValue("", 2903, "/", 2903, 1, true);
#nullable restore
#line 82 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2904, dr["CompanyLogo"], 2904, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\n            <br />\n            ");
#nullable restore
#line 84 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
       Write(dr["CompanyName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <a");
            BeginWriteAttribute("href", " href=\"", 3043, "\"", 3077, 2);
            WriteAttributeValue("", 3050, "\\Admin\\UpdateUser\\", 3050, 18, true);
#nullable restore
#line 87 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3068, dr["ID"], 3068, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm m-1\">");
#nullable restore
#line 87 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                                                                                Write(localizer["UpdateText"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 3162, "\"", 3193, 3);
            WriteAttributeValue("", 3172, "DeleteUser(", 3172, 11, true);
#nullable restore
#line 88 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3183, dr["ID"], 3183, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3192, ")", 3192, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm m-1\">");
#nullable restore
#line 88 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                                                                                 Write(localizer["DeleteText"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n        </td>\n    </tr>\n</tbody>\n");
#nullable restore
#line 92 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
 }



}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr><td colspan=\"6\"><center><h5>");
#nullable restore
#line 99 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
                           Write(localizer["EmptyRecord"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></center></td></tr>\n");
#nullable restore
#line 100 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>");
#nullable restore
#line 102 "D:\Work\EnergyLabelCalculator_Freelance\EnergyLabelCalculator\Views\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
    $(document).ready(function () {
        $('#data-table').DataTable();
    });
</script>
<script>
    function DeleteUser(ID) {
        if (ID) {
            if (confirm(""Are you sure to delete?"")) {
                window.location.href = ""\\Admin\\DeleteUser?ID="" + ID;
            }


        } else {
            alert(""Company Not Selected"");
        }
    }
</script>");
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
