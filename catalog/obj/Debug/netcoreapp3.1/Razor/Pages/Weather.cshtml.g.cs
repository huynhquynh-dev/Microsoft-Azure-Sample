#pragma checksum "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8dbe8857e674dafb52344046349239bfef3c5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(catalog.Pages.Pages_Weather), @"mvc.1.0.razor-page", @"/Pages/Weather.cshtml")]
namespace catalog.Pages
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
#line 1 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\_ViewImports.cshtml"
using catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8dbe8857e674dafb52344046349239bfef3c5d2", @"/Pages/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac1f9cd817065766929b0b6574b21bebc7d2b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Weather : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "weather", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h1 class=\"display-5\">Our Weather:</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8dbe8857e674dafb52344046349239bfef3c5d23840", async() => {
                WriteLiteral("\r\n        Weather Server IP:\r\n");
#nullable restore
#line 10 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
         if (ViewData["ip"] == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"text\" name=\"ip\" />\r\n");
#nullable restore
#line 13 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"text\" name=\"ip\"");
                BeginWriteAttribute("value", " value=\"", 357, "\"", 380, 1);
#nullable restore
#line 16 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
WriteAttributeValue("", 365, ViewData["ip"], 365, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 17 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <button>Get Weather</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br /><br />\r\n");
#nullable restore
#line 22 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
     if (ViewData["weather"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> ");
#nullable restore
#line 24 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
       Write(ViewData["weather"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" degrees Celsius</p>\r\n");
#nullable restore
#line 25 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
    }
    else
    {
        if (ViewData["error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"color: red;\">");
#nullable restore
#line 30 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
                              Write(ViewData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No weather data</p>\r\n");
#nullable restore
#line 35 "D:\01_CODE\03_DevOps\01_Azure Microsoft\01_Microsoft Azure From Zero to Hero - The Complete Guide\catalog\Pages\Weather.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WeatherModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WeatherModel>)PageContext?.ViewData;
        public WeatherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
