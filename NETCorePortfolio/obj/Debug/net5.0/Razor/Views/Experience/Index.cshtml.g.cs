#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4f0467b5d8a6d40247fec985863edb9d2387b9bf7df100b80ad2888e0cbeaad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4f0467b5d8a6d40247fec985863edb9d2387b9bf7df100b80ad2888e0cbeaad9", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Experience/AddExperience"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editExperienceForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Experience/EditExperience/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card-header border-0 d-flex justify-content-between"">
    <button type=""button"" class=""btn btn-primary"">
        <span>Deneyimlerim</span>
        <span class=""badge badge-md badge-circle badge-floating badge-secondary p-2 border-white"">");
#nullable restore
#line 12 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
                                                                                             Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </button>\r\n    <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#yenideneyimekle\">Yeni Deneyim Ekle</button>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<!-- Yetenek ekleme Modal -->
<div class=""modal fade"" id=""yenideneyimekle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""yenideneyimekleTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""yenideneyimekleTitle"">Yeni Deneyim Ekle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f0467b5d8a6d40247fec985863edb9d2387b9bf7df100b80ad2888e0cbeaad96570", async() => {
                WriteLiteral(@"

                <div class=""modal-body"">
                    <div class=""row d-flex flex-column"">
                        <div class=""form-group"">
                            <label>Pozisyon</label>
                            <input type=""text"" class=""form-control"" name=""Title"" />
                        </div>
                        <div class=""form-group"">
                            <label>Konum/Şirket</label>
                            <input type=""text"" class=""form-control"" name=""Company"" />
                        </div>
                        <div class=""form-group"">
                            <label>Tarih</label>
                            <input type=""text"" class=""form-control"" name=""Date"" />
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-primary"">Oluştur</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismi");
                WriteLiteral("ss=\"modal\">Vazgeç</button>\r\n                </div>\r\n            ");
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

<!-- Yetenek Düzenleme Modal -->
<!-- Düzenleme Modal -->
<div class=""modal fade"" id=""duzenleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""duzenleModalTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""duzenleModalTitle"">Deneyimi Düzenle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f0467b5d8a6d40247fec985863edb9d2387b9bf7df100b80ad2888e0cbeaad99959", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""editTitle"">Pozisyon</label>
                        <input type=""text"" class=""form-control"" id=""editTitle"" name=""Title"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""editValue"">Konum/Şirket</label>
                        <input type=""text"" class=""form-control"" id=""editCompany"" name=""Company"" />
                    </div>

                    <div class=""form-group"">
                        <label for=""editValue"">Tarih</label>
                        <input type=""text"" class=""form-control"" id=""editDate"" name=""Date"" />
                    </div>
                    <!-- Hidden input to hold the SkillID -->
                    <input type=""hidden"" id=""editExperienceId"" name=""ExperienceID"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn");
                WriteLiteral(" btn-primary\">Kaydet</button>\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Vazgeç</button>\r\n                </div>\r\n            ");
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



<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Pozisyon</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Konum</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Tarih</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col"">Sil</th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 110 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">\r\n                        <div class=\"media align-items-center\">\r\n                            <a class=\"avatar rounded-circle mr-3\">\r\n                                ");
#nullable restore
#line 116 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
                           Write(i.ExperienceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </th>\r\n                    <td class=\"budget\">");
#nullable restore
#line 120 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
                                  Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"budget\">");
#nullable restore
#line 121 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
                                  Write(i.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td> <span class=\"completion mr-2\">");
#nullable restore
#line 123 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
                                                  Write(i.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\r\n                    <td><button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5604, "\"", 5649, 3);
            WriteAttributeValue("", 5614, "openEditExperience(", 5614, 19, true);
#nullable restore
#line 124 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
WriteAttributeValue("", 5633, i.ExperienceID, 5633, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5648, ")", 5648, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Düzenle</button></td>\r\n\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 5702, "\"", 5753, 2);
            WriteAttributeValue("", 5709, "/Experience/DeleteExperience/", 5709, 29, true);
#nullable restore
#line 126 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
WriteAttributeValue("", 5738, i.ExperienceID, 5738, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 128 "D:\NETCorePortfolio\NETCorePortfolio\Views\Experience\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script>
    function openEditExperience(experienceID) {
        // AJAX isteği yap
        $.ajax({
            url: '/Experience/GetById/' + experienceID,
            type: 'GET',
            success: function (response) {
                // Gelen verilerle modalı doldur
                $('#editTitle').val(response.title);
                $('#editCompany').val(response.company);
                $('#editDate').val(response.date);
                $('#editExperienceId').val(response.experienceID); // Hidden input'un değerini ayarla
                // Modalı aç
                $('#duzenleModal').modal('show');
            },
            error: function (error) {
                console.log(error);
            }
        });
    }


    // Kaydet butonuna basıldığında
    $(document).on('submit', '#editExperienceForm', function (e) {
        e.preventDefault()");
            WriteLiteral(@"; // Sayfanın yeniden yüklenmesini engelle

        var formData = $(this).serialize(); // Form verilerini al
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
