#pragma checksum "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e461567246aad034763f79f3f494241c05ca2c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\_ViewImports.cshtml"
using CampUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\_ViewImports.cshtml"
using CampUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e461567246aad034763f79f3f494241c05ca2c5", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f20eddfeb0a43cf7a5d47c07f3a8b91d79da046", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampModel.Entity.Camp>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 56, "\"", 105, 4);
            WriteAttributeValue("", 64, "background-image:", 64, 17, true);
            WriteAttributeValue(" ", 81, "url(\'", 82, 6, true);
#nullable restore
#line 3 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
WriteAttributeValue("", 87, Model.ImagePath, 87, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 103, "\')", 103, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n                <div class=\"post-heading\">\r\n                    <h1>");
#nullable restore
#line 9 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h2 class=\"subheading\">");
#nullable restore
#line 10 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
                                      Write(Model.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <span class=\"meta\">\r\n                        ");
#nullable restore
#line 12 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
                   Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        tarafından\r\n                        ");
#nullable restore
#line 14 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
                   Write(Model.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ' da yayınlandı.
                    </span>
                </div>
            </div>
        </div>
    </div>
</header>
<div class=""container"">
    <!-- Post Content -->
    <article>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-10 mx-auto"">
                    ");
#nullable restore
#line 27 "C:\Users\Buseyalcin\Desktop\CampingProject\CampUI\Views\Home\Post.cshtml"
               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </article>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampModel.Entity.Camp> Html { get; private set; }
    }
}
#pragma warning restore 1591
