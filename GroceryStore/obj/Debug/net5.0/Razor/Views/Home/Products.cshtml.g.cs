#pragma checksum "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5f9598405b3eb83b2350448ba968d81267df6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Products), @"mvc.1.0.view", @"/Views/Home/Products.cshtml")]
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
#line 1 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\_ViewImports.cshtml"
using GroceryStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5f9598405b3eb83b2350448ba968d81267df6f", @"/Views/Home/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd50d0179ac9bea7de6074dacf685930840d048", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
  
    ViewData["Title"] = "Products";
    var Products = (List<Product>)ViewData["Products"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<h3>All Products</h3>\r\n<div class=\"card-columns\">\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
     foreach (var Product in Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card text-center\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 271, "\"", 291, 1);
#nullable restore
#line 18 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
WriteAttributeValue("", 277, Product.Image, 277, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top \" style=\"max-width:200px\"");
            BeginWriteAttribute("alt", " alt=\"", 338, "\"", 357, 1);
#nullable restore
#line 18 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
WriteAttributeValue("", 344, Product.Name, 344, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
                                  Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 21 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"
                                  Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\Norah\source\repos\GroceryStore\GroceryStore\Views\Home\Products.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n");
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
