#pragma checksum "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f3d7f747bd830dc7b15cd963c7f5ee5b3dd503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\amalf\source\repos\eLearn\Views\_ViewImports.cshtml"
using eLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amalf\source\repos\eLearn\Views\_ViewImports.cshtml"
using eLearn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f3d7f747bd830dc7b15cd963c7f5ee5b3dd503", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325de8582b6d5f3967f01306b94e593dbc332b06", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
  
    var Users = (List<User>)ViewData["Users"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center;padding-bottom:30px"">Current Users</h1>

<table class=""table table-dark"">
    <thead>
        <tr>
            <td>
                Id
            </td>
            <td>
                First Name
            </td>
            <td>
                Last Name
            </td>
            <td>
                Email
            </td>

        </tr>
        </th>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
         foreach (var User in Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
               Write(User.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
               Write(User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
               Write(User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
               Write(User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\Users\amalf\source\repos\eLearn\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
