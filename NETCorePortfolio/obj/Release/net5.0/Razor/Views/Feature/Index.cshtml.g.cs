#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fcd488574f577d70d23ecb4527f4453a858b758fed1911663d2e71fe8ff0a64f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feature_Index), @"mvc.1.0.view", @"/Views/Feature/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\_ViewImports.cshtml"
using NETCorePortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NETCorePortfolio\NETCorePortfolio\Views\_ViewImports.cshtml"
using NETCorePortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fcd488574f577d70d23ecb4527f4453a858b758fed1911663d2e71fe8ff0a64f", @"/Views/Feature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Feature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Feature>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <div class=\"page-header\">\r\n        <h3 class=\"page-title\">Site Anasayfa Yazıları</h3>\r\n    </div>\r\n\r\n");
#nullable restore
#line 13 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
 using (Html.BeginForm("EditFeature", "Feature", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.HiddenFor(x=>x.FeatureID, new{@value = Model.FeatureID}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 19 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.Label("Hakkımda başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title, new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.Label("Alt başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x => x.SubTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"
Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 34 "D:\NETCorePortfolio\NETCorePortfolio\Views\Feature\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Feature> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
