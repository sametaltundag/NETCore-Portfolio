#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0bb9bb82deb4d006ce80af4bd0dc140f30945ce7917941085337b6bf7e9d2ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0bb9bb82deb4d006ce80af4bd0dc140f30945ce7917941085337b6bf7e9d2ac2", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Portfolio/AddPortfolio"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editPortfolioForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Portfolio/EditPortfolio/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\">\r\n    <div class=\"page-header\">\r\n        <h3 class=\"page-title\">Projelerim (");
#nullable restore
#line 9 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
                                      Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(") </h3>\r\n        <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#yeniprojeekle\">Yeni Proje Ekle</button>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 14 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
         foreach(var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 mt-3\">\r\n                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 589, 1);
#nullable restore
#line 18 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 578, i.ImageUrl, 578, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" style=\"height:200px;width:100%;object-fit:contain;object-position:center;\"/>\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 20 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
                                          Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 822, "\"", 836, 1);
#nullable restore
#line 21 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 829, i.Link, 829, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Projeye Git</a>\r\n                        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 948, "\"", 991, 3);
            WriteAttributeValue("", 958, "openEditPortfolio(", 958, 18, true);
#nullable restore
#line 22 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 976, i.PortfolioID, 976, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 990, ")", 990, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Düzenle</button>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1037, "\"", 1085, 2);
            WriteAttributeValue("", 1044, "/Portfolio/DeletePortfolio/", 1044, 27, true);
#nullable restore
#line 23 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1071, i.PortfolioID, 1071, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "D:\NETCorePortfolio\NETCorePortfolio\Views\Portfolio\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""yeniprojeekle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""yeniprojeekleTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""yeniprojeekleTitle"">Yeni Proje Ekle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb9bb82deb4d006ce80af4bd0dc140f30945ce7917941085337b6bf7e9d2ac29211", async() => {
                WriteLiteral(@"

                <div class=""modal-body"">
                    <div class=""row d-flex flex-column"">
                        <div class=""form-group"">
                            <label>Görsel URL</label>
                            <input type=""text"" class=""form-control"" name=""ImageUrl"" />
                        </div>
                        <div class=""form-group"">
                            <label>Proje Adı</label>
                            <input type=""text"" class=""form-control"" name=""Name"" />
                        </div>
                        <div class=""form-group"">
                            <label>Link</label>
                            <input type=""text"" class=""form-control"" name=""Link"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Oluştur</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss");
                WriteLiteral("=\"modal\">Vazgeç</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""duzenleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""duzenleModalTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""duzenleModalTitle"">Projeyi Düzenle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb9bb82deb4d006ce80af4bd0dc140f30945ce7917941085337b6bf7e9d2ac212537", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""editImageUrl"">Görsel URL</label>
                        <input type=""text"" class=""form-control"" id=""editImageUrl"" name=""ImageUrl"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""editName"">Proje Adı</label>
                        <input type=""text"" class=""form-control"" id=""editName"" name=""Name"" />
                    </div>

                    <div class=""form-group"">
                        <label for=""editLink"">Link</label>
                        <input type=""text"" class=""form-control"" id=""editLink"" name=""Link"" />
                    </div>
                    <input type=""hidden"" id=""editPortfolioId"" name=""PortfolioID"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
                    <button type=""b");
                WriteLiteral("utton\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Vazgeç</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<script>
    function openEditPortfolio(portfolioID) {
        // AJAX isteği yap
        $.ajax({
            url: '/Portfolio/GetById/' + portfolioID,
            type: 'GET',
            success: function (response) {
                // Gelen verilerle modalı doldur
                $('#editImageUrl').val(response.imageurl);
                $('#editName').val(response.name);
                $('#editLink').val(response.link);
                $('#editPortfolioId').val(response.id); 

                $('#duzenleModal').modal('show');
            },
            error: function (error) {
                console.log(error);
            }
        });
    }


    // Kaydet butonuna basıldığında
    $(document).on('submit', '#editPortfolioForm', function (e) {
        e.preventDefault(); // Sayfanın yeniden yüklenmesini engelle

        var formData = $(this).serialize(); // Form verilerini al
        var url = $(this).attr('action'); // Formun gönde");
            WriteLiteral(@"rileceği URL

        // AJAX isteği yap
        $.post(url, formData)
            .done(function (response) {
                // Başarılı bir şekilde işlem yapıldığında modalı kapat
                $('#duzenleModal').modal('hide');
                // İlgili sayfayı yeniden yükle
                window.location.reload();
            })
            .fail(function (error) {
                console.log(error);
            });
    });


</script>");
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