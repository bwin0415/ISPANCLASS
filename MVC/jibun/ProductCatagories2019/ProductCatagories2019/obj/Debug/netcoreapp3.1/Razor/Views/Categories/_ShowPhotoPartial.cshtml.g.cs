#pragma checksum "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8145e50dae2c00bef8966aa96f0ca9cd86d15b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories__ShowPhotoPartial), @"mvc.1.0.view", @"/Views/Categories/_ShowPhotoPartial.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\_ViewImports.cshtml"
using ProductCatagories2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\_ViewImports.cshtml"
using ProductCatagories2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8145e50dae2c00bef8966aa96f0ca9cd86d15b2", @"/Views/Categories/_ShowPhotoPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48bb2e908f2a01f9f26f61a53334952eca964ed2", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories__ShowPhotoPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCatagories2019.Models.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
 if (Model.Picture != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img style=\"width:320px;height:240px\"");
            BeginWriteAttribute("src", " src=\"", 243, "\"", 313, 1);
#nullable restore
#line 7 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
WriteAttributeValue("", 249, Url.Action("ShowPhoto","Categories",new { id=Model.CategoryId}), 249, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", "\r\n         title=\"", 314, "\"", 375, 1);
#nullable restore
#line 8 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
WriteAttributeValue("", 332, Html.DisplayFor(model=>model.CategoryName), 332, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 9 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img style=\"width:320px;height:240px\"");
            BeginWriteAttribute("src", " src=\"", 434, "\"", 513, 1);
#nullable restore
#line 12 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
WriteAttributeValue("", 440, Url.Content("https://www.ihecj.jp/wp-content/uploads/2018/01/noimg.png"), 440, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"找無圖片\" />\r\n");
#nullable restore
#line 13 "C:\Users\Student\Desktop\ISPAN\ISPANCLASS\MVC\jibun\ProductCatagories2019\ProductCatagories2019\Views\Categories\_ShowPhotoPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCatagories2019.Models.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
