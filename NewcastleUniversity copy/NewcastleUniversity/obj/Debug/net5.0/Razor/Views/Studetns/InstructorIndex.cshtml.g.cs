#pragma checksum "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58eecc314ce76aacdcb06c67dc2325ecab3373d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Studetns_InstructorIndex), @"mvc.1.0.view", @"/Views/Studetns/InstructorIndex.cshtml")]
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
#line 1 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\_ViewImports.cshtml"
using NewcastleUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\_ViewImports.cshtml"
using NewcastleUniversity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58eecc314ce76aacdcb06c67dc2325ecab3373d", @"/Views/Studetns/InstructorIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d782ab2f3946f64964d20de1c3e1ab091a7c33a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Studetns_InstructorIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
  
    var instructors = (List<InstructorModel>)ViewData["instructor"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>This is Instructors Index</h1>

<table class""table"">
    <thead class=""thead-ligh"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Full Name</th>
            <th>Phone Number</th>
            <th>Email</th>

        </tr>
    </thead>

    <tbody>



");
#nullable restore
#line 24 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
         foreach (var i in instructors)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
               Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
               Write(i.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
               Write(i.PhoneNum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
               Write(i.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"btn\"><a");
            BeginWriteAttribute("href", " href=\"", 632, "\"", 672, 2);
            WriteAttributeValue("", 639, "/studetns/instructordetails/", 639, 28, true);
#nullable restore
#line 32 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
WriteAttributeValue("", 667, i.Id, 667, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">details</a></button></td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\arwaw\MVC\dotnetEF\NewcastleUniversity\NewcastleUniversity\Views\Studetns\InstructorIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    </tbody>\r\n\r\n\r\n</table>\r\n\r\n");
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
