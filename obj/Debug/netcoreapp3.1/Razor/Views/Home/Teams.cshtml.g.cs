#pragma checksum "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ff7bb6de5d0538076fecde406142453f787d878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Teams), @"mvc.1.0.view", @"/Views/Home/Teams.cshtml")]
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
#line 1 "/Users/alismith/Desktop/BowlingLeague/Views/_ViewImports.cshtml"
using BowlingLeague;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/alismith/Desktop/BowlingLeague/Views/_ViewImports.cshtml"
using BowlingLeague.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff7bb6de5d0538076fecde406142453f787d878", @"/Views/Home/Teams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71d8b274c6450c1f086e8cc4287fe55d3f795540", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Teams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
  
    ViewData["Title"] = "Teams";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("<div class=\"dropdown\">\n    <button class=\"btn btn-primary dropdown-toggle fw-normal\" type=\"button\" data-toggle=\"dropdown\">\n        Filter by Team\n        <span class=\"caret\"></span>\n    </button>\n    <ul class=\"dropdown-menu\">\n");
#nullable restore
#line 13 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
         foreach (Team t in ViewBag.Teans)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"padding-left:10px;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ff7bb6de5d0538076fecde406142453f787d8784275", async() => {
#nullable restore
#line 15 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
                                                                                                               Write(t.TeamName);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-teamid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
                                                                                             WriteLiteral(t.TeamID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["teamid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-teamid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["teamid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n</div>\n<br />\n\n");
#nullable restore
#line 22 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
 foreach (Team t in ViewBag.AllTeams)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"lead fw-normal mb-lg-0\" style=\"font-size:28px; text-align:center\">The ");
#nullable restore
#line 24 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
                                                                                Write(t.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 25 "/Users/alismith/Desktop/BowlingLeague/Views/Home/Teams.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />");
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
