#pragma checksum "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e8bf12490e48a3e50a7d1434b07bfe68df2552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RecentlyAddedArticles_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RecentlyAddedArticles/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RecentlyAddedArticles/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RecentlyAddedArticles_Default))]
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
#line 1 "C:\Users\marti\ASP.NET\Hasici.Web\Views\_ViewImports.cshtml"
using Hasici.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e8bf12490e48a3e50a7d1434b07bfe68df2552", @"/Views/Shared/Components/RecentlyAddedArticles/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db45adcf962e967ea6b1c699d17b8ba2126500f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RecentlyAddedArticles_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 63, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n<section>\r\n    <header class=\"major\">\r\n        <h2>");
            EndContext();
            BeginContext(93, 19, false);
#line 10 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
       Write(ViewData["Title_2"]);

#line default
#line hidden
            EndContext();
            BeginContext(112, 47, true);
            WriteLiteral("</h2>\r\n    </header>\r\n    <div class=\"posts\">\r\n");
            EndContext();
#line 13 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
         foreach (var article in Model)
        {

#line default
#line hidden
            BeginContext(211, 130, true);
            WriteLiteral("            <article>\r\n\r\n                <a href=\"#\" class=\"image\"><img src=\"images/pic01.jpg\" alt=\"\" /></a>\r\n                <h3>");
            EndContext();
            BeginContext(342, 35, false);
#line 18 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
               Write(Html.DisplayFor(m => article.Title));

#line default
#line hidden
            EndContext();
            BeginContext(377, 23, true);
            WriteLiteral("</h3>\r\n                ");
            EndContext();
            BeginContext(401, 25, false);
#line 19 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
           Write(Html.Raw(article.Preview));

#line default
#line hidden
            EndContext();
            BeginContext(426, 105, true);
            WriteLiteral("                \r\n\r\n             \r\n                    <ul class=\"actions\">\r\n                        <li>");
            EndContext();
            BeginContext(531, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d297e41255924e41867f38b61dc51840", async() => {
                BeginContext(623, 11, true);
                WriteLiteral("Čítať ďalej");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
                                                                                WriteLiteral(article.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(638, 79, true);
            WriteLiteral("</li>\r\n                    </ul>\r\n               \r\n\r\n\r\n            </article>\r\n");
            EndContext();
#line 29 "C:\Users\marti\ASP.NET\Hasici.Web\Views\Shared\Components\RecentlyAddedArticles\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(728, 34, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
