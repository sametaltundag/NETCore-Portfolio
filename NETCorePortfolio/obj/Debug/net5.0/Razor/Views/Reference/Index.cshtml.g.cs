#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2aeaf0eaa81ae10b89ab88fb2240552f25267a1af16af33ac8bccfe5042c23d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reference_Index), @"mvc.1.0.view", @"/Views/Reference/Index.cshtml")]
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
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2aeaf0eaa81ae10b89ab88fb2240552f25267a1af16af33ac8bccfe5042c23d2", @"/Views/Reference/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reference_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reference>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Reference/AddReference"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editReferenceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Reference/EditReference/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <div class=\"page-header\">\r\n        <h3 class=\"page-title\">Referanslarım (");
#nullable restore
#line 10 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(") </h3>\r\n        <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#yenireferansekle\">Referans Ekle</button>\r\n    </div>\r\n\r\n");
#nullable restore
#line 14 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
     foreach(var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n        \r\n            <div class=\"col-3\">\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 556, "\"", 578, 1);
#nullable restore
#line 19 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
WriteAttributeValue("", 564, i.ReferenceID, 564, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"ReferenceID\" />\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 623, "\"", 640, 1);
#nullable restore
#line 20 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
WriteAttributeValue("", 629, i.ImageUrl, 629, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Reference Image\" class=\"card-img-top\">\r\n            </div>\r\n            <div class=\"col-9\">\r\n                <div class=\"d-flex align-items-center justify-content-start\">\r\n                    <h3>");
#nullable restore
#line 24 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" |</h3> <span class=\"px-1\">");
#nullable restore
#line 24 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
                                                     Write(i.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <textarea class=\"form-control\" rows=\"7\" style=\"resize:vertical;\">");
#nullable restore
#line 27 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
                                                                            Write(i.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n                <div class=\"btn-group d-flex justify-content-end\">\r\n                        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1165, "\"", 1208, 3);
            WriteAttributeValue("", 1175, "openEditReference(", 1175, 18, true);
#nullable restore
#line 30 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
WriteAttributeValue("", 1193, i.ReferenceID, 1193, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1207, ")", 1207, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Güncelle</button>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1251, "\"", 1299, 2);
            WriteAttributeValue("", 1258, "/Reference/DeleteReference/", 1258, 27, true);
#nullable restore
#line 31 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
WriteAttributeValue("", 1285, i.ReferenceID, 1285, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                </div>\r\n            </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "D:\NETCorePortfolio\NETCorePortfolio\Views\Reference\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""modal fade"" id=""yenireferansekle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""yenireferansekleTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""yenireferansekleTitle"">Yeni Referans Ekle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aeaf0eaa81ae10b89ab88fb2240552f25267a1af16af33ac8bccfe5042c23d29927", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row d-flex flex-column"">
                        <div class=""form-group"">
                            <label>Referans Görsel URL</label>
                            <input type=""text"" class=""form-control"" name=""ImageUrl"" />
                        </div>
                        <div class=""form-group"">
                            <label>Referans Adı</label>
                            <input type=""text"" class=""form-control"" name=""Name"" />
                        </div>
                        <div class=""form-group"">
                            <label>Şirket/Ünvan</label>
                            <input type=""text"" class=""form-control"" name=""Company"" />
                        </div>

                        <div class=""form-group"">
                            <label>Yorum</label>
                            <textarea class=""form-control"" name=""Comment"" rows=""5""></textarea>
                        </div>
         ");
                WriteLiteral(@"           </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Oluştur</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                </div>
            ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aeaf0eaa81ae10b89ab88fb2240552f25267a1af16af33ac8bccfe5042c23d213509", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""editImageUrl"">Görsel URL</label>
                        <input type=""text"" class=""form-control"" id=""editImageUrl"" name=""ImageUrl"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""editName"">Referans Adı</label>
                        <input type=""text"" class=""form-control"" id=""editName"" name=""Name"" />
                    </div>

                    <div class=""form-group"">
                        <label for=""editLink"">Firma/Ünvan</label>
                        <input type=""text"" class=""form-control"" id=""editCompany"" name=""Company"" />
                    </div>
                    
                    <div class=""form-group"">
                        <label for=""editLink"">Yorum</label>
                        <textarea class=""form-control"" id=""editComment"" name=""Comment""></textarea>
                    </div>");
                WriteLiteral(@"
                    <input type=""hidden"" id=""editReferenceId"" name=""ReferenceID"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                </div>
            ");
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
    function openEditReference(referenceID) {
        // AJAX isteği yap
        $.ajax({
            url: '/Reference/GetById/' + referenceID,
            type: 'GET',
            success: function (response) {
                // Gelen verilerle modalı doldur
                $('#editImageUrl').val(response.imageurl);
                $('#editName').val(response.name);
                $('#editCompany').val(response.company);
                $('#editComment').val(response.comment);
                $('#editReferenceId').val(response.id);

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

        var formData = $(this).serialize(); // Form verilerin");
            WriteLiteral(@"i al
        var url = $(this).attr('action'); // Formun gönderileceği URL

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reference>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
