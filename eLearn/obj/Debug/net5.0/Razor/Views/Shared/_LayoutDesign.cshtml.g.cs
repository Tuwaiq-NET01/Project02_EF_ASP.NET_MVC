#pragma checksum "C:\Users\amalf\source\repos\eLearn\Views\Shared\_LayoutDesign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e32705a781cbed494a9ddb5dcd8c78eda995d82e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutDesign), @"mvc.1.0.view", @"/Views/Shared/_LayoutDesign.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e32705a781cbed494a9ddb5dcd8c78eda995d82e", @"/Views/Shared/_LayoutDesign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325de8582b6d5f3967f01306b94e593dbc332b06", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutDesign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("        background-image: url(https://images.unsplash.com/photo-1432821596592-e2c18b78144f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=750&q=80)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e32705a781cbed494a9ddb5dcd8c78eda995d82e6178", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>eLearn</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e32705a781cbed494a9ddb5dcd8c78eda995d82e6534", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e32705a781cbed494a9ddb5dcd8c78eda995d82e7712", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""icon"" href=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAPcAAADMCAMAAACY78UPAAAAgVBMVEX///8AAACRkZHg4OBcXFy5ubkdHR3Q0NAqKirHx8fy8vL19fWbm5vv7+/l5eXCwsKkpKRpaWl3d3diYmK7u7uBgYFDQ0ONjY2pqana2tqvr69PT0/S0tIVFRVUVFQ1NTWGhoYNDQ1ISEg9PT1vb28wMDAcHBwUFBRAQEAkJCR7e3ths4z3AAAJRUlEQVR4nO2d6XaqPBeAkUFF5kkGUVFpq97/BX5I21ODSciwtbxf8/w56ywpez8CGTHRNHa8cmEHVejeCIsqsGtjxfHn/zUcb1E1yXqG57KLdKt+uf/KK4OqyOPE3G2O59P5uNmZSXvNC2vhAyTjpPmRIIyy3eiWLx+PISPDcqPTBzWZ+bp1U0ciiM7k/MPOrcEEMdTFdcmeTCYch+1SDziGz7juTpCTnjQiZ8FYsYj2jbfcAJU2XG7nnkgoWimqfWPvQl31OrsIZ1GKBMxlvDs2gby0r7/LpNCIxDQlvTtcT8q62kvG34hE3ch7z2at8O1uNPLRl7/m3RUuQmWcvYOI/Zves1nCfbenHNU0DSFvodobT8NnLVWW3QPqfdjO59sDZwYVc9iFbGF2h5A30lbYmrFrBaXnrZzPhq/jrDzDttzYZKteT2yPuZ9wiR3eNqaZ9Jjr5QHeO6EdaQQ5Q6XXMMR02XQ/kiwMFtiqAikPhbzPzN49XjrWsFqO1Wn1fFz5mAfU0yAXQMj7xOd9w6vo153+lF9HlJdtNf6wAHszN/GdlPaEUk5j0C92UrHVhr/l3eFU5O7ThXSThjTp2GYOLu+N1CecXTojIzosxtNFMbn6N8DeLe9fOwWplLMeD/aIJeI7b9dG3vtNyrvDIjyx7vBAYk9foCs7AW9NK/A6g5GvlGC9Exk2APaORc6gkQYvrveHEL6co9BgCYA30icS9dZ8bIfyT");
                WriteLiteral(@"hzfRHtjL8FRpuLdPeY4L/37U7w2ezdmiLw3UsZex48nssL15L/MsNqRxJj/hLzxjRKb9MFM9BbvkfdGaiHxyYeecvuo17W1K9zFlos0LW/NebzX51qN0S4kA3F5G4tHauQSyXprWvuguMOMJ4lVXncg3pfy0eunS4e724Y0svloGsO48F5mEvMThgGQryKVady0kU6IYTBF8tHuYZntMG8Hsg1oNQAp0fuasnXGF0yzPF2r22bSnuUQOdHn0xuQEGyzW7UWvdJbI3fLAUrOHjbvq3Zg89bHI8qlJdEQRmCbX3rT2LTBvDXCCIMJdf4T/vxDXu7tY0//BnV61tnrl3vjWwtw74EBez+MDYFmhh9rhDr7RLxXDyeHu5mm7P0wEHEEPPeUvYd1Dej7bkLemW/8gHwSQuaGjhuDfqWo9/uPj482mVBv5EF7njf6laaQp0a953cfoG3kCXhj5k8kUN7Ku0d5K2/lfYfyVt4wKO/Je8tO3yAob+UNhfJW3j1i3uIvnGBQ3sobCmlvR3krbxiU9wS90ekc0OSU9wS9PeWtvGH4D3mDTmIp7wl6oy/g/FVvgLU5flDeyhsK5S3ojSYn9VuXIcpbeUOhvAW90ZfM/qo34Juzylt5wwHsDbpOpvKeoDf6o9W/6i39e9V7lLfyhkLae6G8Z/2iBHAob+UNBbA36G+dJu2N/iBeeQOgvJU3FMpbefcob+WtvH8IlLfyhkF5K28olLfy7lHePN5yGywNmLQ3ujq38gZAeU/QG101S3kDoLwn6I2ug6i8AVDek/cG3fB50t7otiLKGwDlPUFvdJF2+QX471DeyhsK5S3oje4+obwBUN6T9wbNTXkrbyikvZHjDqC5KW/lDYXyFvRGdjz9AM1NeU/dewua2zO9kW3k5L3t4Avbrg3ZwRcgb6e0iyZOzncbQF7OyF6NIt7NjMb8mMR6tfCE2u3S3s6iuO4O1ASf5P2PfeJaBqe9lLdfxXtCLq/0/uStsTjeBBH29qr2wJPW0717oorRX");
                WriteLiteral(@"cy71JeEwKDelC0QyVzigOGeF/CuM8wOw6O8zPvGrhqbTOP1Lq8fYqmIeF/FQvWsC2pVx+W9CglbMTLwLuDN/3wjbCg6HN4123a2BPYC3tjt6bloSD+uZPaumGssPPc774qtlyvGBr+MF5v3irqrLhP3q5AwrwMuH7Zji9sAhMXbj+WD78g6FG/WrYPHyB9qtnFvX+qx/mKJBGb3Ht+wm5F8ULqPeRsc3/jlvGtz1w3D0HX1rDXP/0r/GP2+Obw1LdWveWEFdul7qw6vwy/t1AqzZIPZpZ5sjuRA9/bYrLdmVtm4fpHjB0XcPLQdubzpGHZxXTOa3+8aSfN2WNpLiWtz94UBvT/xbNc8MCT740fxHn+0kkJsjQ1w7x6/audjGZ+/EyZ6ByON8O1VfB2453j3OuFmxPxK9Tbof/6RSS2W9DzvDicdqYACsjf9wY5kV0J7qvcNi7rV/G6F9w4Ix/fsAbYJerp3V9K5tC5UivH2aNsZRyCLgb3Au8Om3O8turSbNXyXBkUHejX2Nd5dCc86cBH4J/KHcPtgvcpbY23nkouDC+SUwgu9uxv4wKSOZQs7kfJSb/qjSwV0pzft5d6C/XjYTeAf03iBt7bi7shnoK+NfQLp7TjOrXu66v6lHldzjZPtyIueOX1X+MZ40AFy3o5fpqGbRbv1afl+uPvTw/J0NGM9tBYGrsJlH8I4DLfO8Ay7CvW2i3g5DI6d78+bJHaLwBifqRH09heV3u6HgQlczCa00VR8xo56fvc3ZapHrCFn78fMDUpyI4fX21lYTcIaHOWYVXdNTJaS/fj1Za1sNxKcIzlf3QD3oHB4+6nONKJAZZOnXxfBGH3Kb7u7ObVrisyFoazjqhQZX/OC/HiQjv7NMv50p8/BtN2d7VI7c5zs48rg8DaqeHTshJ9lY1N7m3PLBhgyf8R0awbvMoQYuSYRBQaxD0LpnEiz6dwH79si/+OeWBdI4fkh8KBuGuGo/3eU999Cef8txLznxyjOdDes0tuLmx1BWrhNH");
                WriteLiteral(@"B2fUO/fhWzcIv2KF6RV6OpZHK3FQvJ4H/ZRHtrlSO/Pr62uAyOUDI59rFv1SG9rVdphHnHFZPI+rFvXonR1cHglx/uUWPZtuOBbDssrLbdl6/eNeV8SNxAfwHbqIuKZJv8XtS1q8SGXrjuVjN39GqV5mLgLiPEeL+Vrd19TiJkCx9YpczBrwkAI33u24xjhmcn5GMIurG9l+KZ3ONju+sapkbizyXj0+cIOMwVdTeE7bpA9ljPOYN2tZRY8I/Z3CsWRKL2rnjCG+i9wekVmKvu3B/71ic0C9N7GZ4B923RPf58VBD/cIdodYbJeN6A76dEoh8VcBvpM07Cz9TqCnohhx7m76Mvq19L4DYLPsub0srtsMpSVW73sBn/gf1jIs3hD5yAlAAAAAElFTkSuQmCC"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e32705a781cbed494a9ddb5dcd8c78eda995d82e13188", async() => {
                WriteLiteral(@"

    <div class=""container"">

        <nav class=""navbar sticky-top navbar-light"" style=""background-color: #f8f2ed"">
            <div class=""container-fluid"" style=""padding-left:500px"">
                <strong>
                    <a class=""navbar-brand"" href=""/home"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-book"" viewBox=""0 0 16 16"">
                            <path d=""M1 2.828c.885-.37 2.154-.769 3.388-.893 1.33-.134 2.458.063 3.112.752v9.746c-.935-.53-2.12-.603-3.213-.493-1.18.12-2.37.461-3.287.811V2.828zm7.5-.141c.654-.689 1.782-.886 3.112-.752 1.234.124 2.503.523 3.388.893v9.923c-.918-.35-2.107-.692-3.287-.81-1.094-.111-2.278-.039-3.213.492V2.687zM8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 ");
                WriteLiteral("0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z\" />\r\n                        </svg>\r\n\r\n                        eLearn\r\n\r\n                    </a>\r\n                </strong>\r\n            </div>\r\n        </nav>\r\n\r\n\r\n        ");
#nullable restore
#line 32 "C:\Users\amalf\source\repos\eLearn\Views\Shared\_LayoutDesign.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <footer>\r\n            <div style=\"background-color: #f8f2ed\">\r\n                <p>");
                WriteLiteral("@2021</p>\r\n            </div>\r\n        </footer>\r\n    </div>\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e32705a781cbed494a9ddb5dcd8c78eda995d82e15243", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e32705a781cbed494a9ddb5dcd8c78eda995d82e16343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e32705a781cbed494a9ddb5dcd8c78eda995d82e17443", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 43 "C:\Users\amalf\source\repos\eLearn\Views\Shared\_LayoutDesign.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 44 "C:\Users\amalf\source\repos\eLearn\Views\Shared\_LayoutDesign.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
