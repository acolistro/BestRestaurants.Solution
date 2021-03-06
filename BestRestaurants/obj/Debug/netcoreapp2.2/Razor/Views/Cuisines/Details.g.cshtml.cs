#pragma checksum "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c65c7ac6714b1e105c23b9681aea26489974230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Details), @"mvc.1.0.view", @"/Views/Cuisines/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Details.cshtml", typeof(AspNetCore.Views_Cuisines_Details))]
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
#line 5 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
using BestRestaurants.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c65c7ac6714b1e105c23b9681aea26489974230", @"/Views/Cuisines/Details.cshtml")]
    public class Views_Cuisines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestaurants.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 190, true);
            WriteLiteral("<div class=\"row\">\r\n  <div class=\"col-sm-9 col-md-7 col-lg-5 mx-auto\">\r\n    <div class=\"card bg-warning my-5\">\r\n      <div class=\"card-body\">\r\n        <h2>Restaurants with </h2>\r\n        <h2>");
            EndContext();
            BeginContext(293, 36, false);
#line 12 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(329, 25, true);
            WriteLiteral("</h2>\r\n        <hr />\r\n\r\n");
            EndContext();
#line 15 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
         if (Model.Restaurants.Count == 0)
        {

#line default
#line hidden
            BeginContext(409, 55, true);
            WriteLiteral("          <p>No restaurants of this cuisine type.</p>\r\n");
            EndContext();
#line 18 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
        }
        else 
        {

#line default
#line hidden
            BeginContext(501, 73, true);
            WriteLiteral("          <h4>Restaurants that serve this cuisine:</h4>\r\n          <ul>\r\n");
            EndContext();
#line 23 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
           foreach (var join in Model.Restaurants)
          {

#line default
#line hidden
            BeginContext(639, 18, true);
            WriteLiteral("              <li>");
            EndContext();
            BeginContext(658, 20, false);
#line 25 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
             Write(join.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(678, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
          }

#line default
#line hidden
            BeginContext(698, 17, true);
            WriteLiteral("          </ul>\r\n");
            EndContext();
#line 28 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(726, 30, true);
            WriteLiteral("\r\n        <hr/>\r\n\r\n        <p>");
            EndContext();
            BeginContext(757, 40, false);
#line 32 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
      Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(797, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(815, 69, false);
#line 33 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
      Write(Html.ActionLink("Edit Cuisine", "Edit", new { id = Model.CuisineId }));

#line default
#line hidden
            EndContext();
            BeginContext(884, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(902, 73, false);
#line 34 "C:\Users\ThinkPad\desktop\BestRestaurants.Solution\BestRestaurants\Views\Cuisines\Details.cshtml"
      Write(Html.ActionLink("Delete Cuisine", "Delete", new { id = Model.CuisineId }));

#line default
#line hidden
            EndContext();
            BeginContext(975, 48, true);
            WriteLiteral("</p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
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
