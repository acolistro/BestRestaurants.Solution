#pragma checksum "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59dbd5f6e1c455c777a09aaa6e317e1d6ae1db8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Edit), @"mvc.1.0.view", @"/Views/Cuisines/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Edit.cshtml", typeof(AspNetCore.Views_Cuisines_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59dbd5f6e1c455c777a09aaa6e317e1d6ae1db8e", @"/Views/Cuisines/Edit.cshtml")]
    public class Views_Cuisines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(65, 38, true);
            WriteLiteral("<h2>Edit</h2>\n\n<h4>Edit this cuisine: ");
            EndContext();
            BeginContext(104, 36, false);
#line 7 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
                  Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 9 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
 using (@Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(179, 40, false);
#line 11 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
Write(Html.HiddenFor(model => model.CuisineId));

#line default
#line hidden
            EndContext();
            BeginContext(224, 34, false);
#line 13 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(262, 35, false);
#line 14 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(299, 41, true);
            WriteLiteral("  <input type = \"submit\" value=\"Save\" />\n");
            EndContext();
#line 17 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(342, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(347, 40, false);
#line 19 "/Users/katysolovewicz/Projects/epicodus/c#/BestRestaurants.Solution/BestRestaurants/Views/Cuisines/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(387, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestaurants.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
