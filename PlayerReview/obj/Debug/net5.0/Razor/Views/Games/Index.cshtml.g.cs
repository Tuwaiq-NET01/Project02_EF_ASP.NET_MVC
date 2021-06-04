#pragma checksum "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810443f69e7d481a924b74a8b0baf153392104c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Index), @"mvc.1.0.view", @"/Views/Games/Index.cshtml")]
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
#line 1 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\_ViewImports.cshtml"
using PlayerReview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\_ViewImports.cshtml"
using PlayerReview.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"810443f69e7d481a924b74a8b0baf153392104c0", @"/Views/Games/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bb7a3be957112645a1110b35d51fd795051c70", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
  
    var games = (List<Game>)ViewData["games"];
    var companies = (List<Company>)ViewData["companies "];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>


<hr />



<h3>All Games</h3>

<table>
    <tr>
        <th>ID</th>
        <th>game name</th>
        <th>company</th>
    </tr>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
         foreach (var game in games)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
               Write(game.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
               Write(game.GameName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 31 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
                     foreach (var comp in companies)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
                         if (comp.Id == game.CompanyId) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
                                                   Write(comp.CompanyName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
                                                                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\moham\Desktop\proj2\PlayerReview\PlayerReview\Views\Games\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<hr />\r\n");
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
