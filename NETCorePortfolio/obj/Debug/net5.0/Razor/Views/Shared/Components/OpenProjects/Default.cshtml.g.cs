#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4634e32421f1c93b211babf84091edb5b94473c43ed9da0d93fb2fb0d3e5c448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_OpenProjects_Default), @"mvc.1.0.view", @"/Views/Shared/Components/OpenProjects/Default.cshtml")]
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
#nullable restore
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4634e32421f1c93b211babf84091edb5b94473c43ed9da0d93fb2fb0d3e5c448", @"/Views/Shared/Components/OpenProjects/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_OpenProjects_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-8 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""d-flex flex-row justify-content-between"">
                <h4 class=""card-title mb-1"">Son Projeler</h4>
                <p class=""text-muted mb-1"">En son eklenen 5 proje listeleniyor...</p>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""preview-list"">
");
#nullable restore
#line 13 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
                         foreach(var i in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""preview-item border-bottom"">
                                <div class=""preview-thumbnail"">
                                    <div class=""preview-icon bg-primary"">
                                        <i class=""mdi mdi-file-document""></i>
                                    </div>
                                </div>
                                <div class=""preview-item-content d-sm-flex flex-grow"">
                                    <div class=""flex-grow"">
                                        <h6 class=""preview-subject"">");
#nullable restore
#line 23 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
                                                               Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1236, "\"", 1250, 1);
#nullable restore
#line 24 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
WriteAttributeValue("", 1243, i.Link, 1243, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"text-muted mb-0\">Projeye Git</a>\r\n                                    </div>\r\n                                    <div class=\"mr-auto text-sm-right pt-2 pt-sm-0\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1495, 1);
#nullable restore
#line 27 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
WriteAttributeValue("", 1488, i.Link, 1488, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" style=\"font-size:25px;color:white;\"><i class=\"mdi mdi-eye\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 31 "D:\NETCorePortfolio\NETCorePortfolio\Views\Shared\Components\OpenProjects\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
