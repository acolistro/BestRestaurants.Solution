#pragma checksum "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cb56bce42df3d736d386f34c759008052c32f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Index), @"mvc.1.0.view", @"/Views/Cuisines/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Index.cshtml", typeof(AspNetCore.Views_Cuisines_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
#line 6 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
using System.Collections.Generic;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cb56bce42df3d736d386f34c759008052c32f8", @"/Views/Cuisines/Index.cshtml")]
    public class Views_Cuisines_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestaurants.Models.Cuisine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(139, 20, true);
            WriteLiteral("\n<h1>Cuisines</h1>\n\n");
            EndContext();
#line 11 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(185, 44, true);
            WriteLiteral("  <h3>No cuisines have been added yet!</h3>\n");
            EndContext();
#line 14 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(232, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 16 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
   foreach(Cuisine cuisine in Model)
  {

#line default
#line hidden
            BeginContext(278, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(289, 77, false);
#line 18 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
     Write(Html.ActionLink($"{cuisine.Name}", "Details", new { id = cuisine.CuisineId }));

#line default
#line hidden
            EndContext();
            BeginContext(366, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 19 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(376, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(387, 44, false);
#line 22 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
Write(Html.ActionLink("Add new cuisine", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(431, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(441, 40, false);
#line 24 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(481, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestaurants.Models.Cuisine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
