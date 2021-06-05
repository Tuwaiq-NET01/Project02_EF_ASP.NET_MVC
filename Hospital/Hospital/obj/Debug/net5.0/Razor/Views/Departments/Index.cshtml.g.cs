#pragma checksum "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c33651fa4c483c50bc8ae1b2b020c84f01d002e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Index), @"mvc.1.0.view", @"/Views/Departments/Index.cshtml")]
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
#line 1 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33651fa4c483c50bc8ae1b2b020c84f01d002e2", @"/Views/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caee22214edcd79e48d3dce45ad60c3b27aa44", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
  
    var departments = (List<DepartmentModel>)ViewBag.Departments;



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-dark table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Department ID</th>\r\n            <th>Department Name</th>\r\n            <th>Head Manager</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
         foreach (var department in departments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
           Write(department.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
           Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 473, "\"", 523, 2);
            WriteAttributeValue("", 480, "/Physicians/details/", 480, 20, true);
#nullable restore
#line 21 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
WriteAttributeValue("", 500, department.PhysicianId, 500, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
                                                                 Write(department.PhysicianId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Taghr\source\repos\Hospital\Hospital\Views\Departments\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
