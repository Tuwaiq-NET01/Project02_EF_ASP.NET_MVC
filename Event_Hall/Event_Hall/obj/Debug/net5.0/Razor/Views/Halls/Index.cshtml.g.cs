#pragma checksum "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17683d03d6a4b3d767a7c184810016016e08790f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Halls_Index), @"mvc.1.0.view", @"/Views/Halls/Index.cshtml")]
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
#line 1 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\_ViewImports.cshtml"
using Event_Hall;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\_ViewImports.cshtml"
using Event_Hall.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17683d03d6a4b3d767a7c184810016016e08790f", @"/Views/Halls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80448bf0756b0925148de66fbf4e64ee25a36193", @"/Views/_ViewImports.cshtml")]
    public class Views_Halls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
  
    var halls = (List<HallModel>)ViewBag.Halls;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-borderless table-dark"" style=""width: 100%; margin: 0px;"">
    <thead style=""background-color: black; text-align: center;"">
        <tr style=""width: 100%; margin: 0px;text-align: center;"">
            <th scope=""col"">ID </th>
            <th scope=""col"">Name </th>
            <th scope=""col"">Capacity </th>
            <th scope=""col"">Avaliability </th>
 
        </tr>
    </thead>
");
#nullable restore
#line 16 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
     foreach (var item in halls)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody style=\"background-color: black;\">\r\n            <tr style=\"width: 100%; margin: 0px; text-align: center; background-color: black;\">\r\n                <th scope=\"row\">");
#nullable restore
#line 21 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
               Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" people</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
               Write(item.Avaliability);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               \r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Reema\source\repos\Project02_EF_ASP.NET_MVC\Event_Hall\Event_Hall\Views\Halls\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
