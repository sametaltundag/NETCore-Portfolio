#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97d62fcdeb3c38aea7fd0ff4fbb137ef0528b6e87329f336ffd4dd3e8e68f797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/Index.cshtml")]
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
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"97d62fcdeb3c38aea7fd0ff4fbb137ef0528b6e87329f336ffd4dd3e8e68f797", @"/Areas/Writer/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bedd53a138b069785550fa10c8b08d3652affa513a594c43af8203f4666e40ff", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Default/AddNotification"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editNotificationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Default/EditNotification/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
  
    string durum = "";
    string metin = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between"">
                    <h4 class=""card-title"">Tablo Verileri (");
#nullable restore
#line 17 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                                                      Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h4>
                    <button class=""btn btn-success"" type=""button"" data-toggle=""modal"" data-target=""#yenibildirimekle"">Yeni Bildirim Oluştur</button>
                </div>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Başlık</th>
                                <th>Tarih</th>
                                <th>Tür</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                             foreach(var i in Model)
                            {
                                if(i.Status == 0)
                                {
                                    durum = "success";
                                    metin = "Yeni İçerik";
                                } else if (i.Status == 1)
                                {
                                    durum = "warning";
                                    metin = "Hazırlanıyor";
                                }
                                else if (i.Status == 2)
                                {
                                    durum = "primary";
                                    metin = "Güncel";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 48 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                                   Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                                   Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                                    Write(((DateTime)i.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><label");
            BeginWriteAttribute("class", " class=\"", 2160, "\"", 2186, 3);
            WriteAttributeValue("", 2168, "badge", 2168, 5, true);
            WriteAttributeValue(" ", 2173, "badge-", 2174, 7, true);
#nullable restore
#line 51 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2180, durum, 2180, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                                                                     Write(metin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2344, "\"", 2381, 3);
            WriteAttributeValue("", 2354, "openEditNotification(", 2354, 21, true);
#nullable restore
#line 53 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2375, i.Id, 2375, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2380, ")", 2380, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Detaylar</button>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2444, "\"", 2484, 2);
            WriteAttributeValue("", 2451, "/Default/DeleteNotification/", 2451, 28, true);
#nullable restore
#line 54 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
WriteAttributeValue("", 2479, i.Id, 2479, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 57 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 61 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                 if (Model.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"mt-3 text-center\">Herhangi bir veri bulunamadı...</p>\r\n");
#nullable restore
#line 64 "D:\NETCorePortfolio\NETCorePortfolio\Areas\Writer\Views\Default\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>


<div class=""modal fade"" id=""yenibildirimekle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""yenibildirimekleTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""yenibildirimekleTitle"">Yeni Bildirim Oluştur</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97d62fcdeb3c38aea7fd0ff4fbb137ef0528b6e87329f336ffd4dd3e8e68f79711860", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""row d-flex flex-column"">
                        <div class=""form-group"">
                            <label>Başlık</label>
                            <input type=""text"" class=""form-control"" name=""Title"" />
                        </div>
                        <div class=""form-group"">
                            <label>İçerik</label>
                            <textarea class=""form-control"" name=""Content""></textarea>
                        </div>
                        <div class=""form-group"">
                            <label>Tarih</label>
                            <input type=""datetime-local"" class=""form-control"" name=""Date"" />
                        </div>

                        <div class=""form-group"">
                            <label>Durum</label>
                            <input type=""number"" min=""0"" max=""3"" class=""form-control"" name=""Status"" />
                        </div>
                    ");
                WriteLiteral(@"</div>
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
                <h5 class=""modal-title"" id=""duzenleModalTitle"">Bildirim Düzenle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97d62fcdeb3c38aea7fd0ff4fbb137ef0528b6e87329f336ffd4dd3e8e68f79715435", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""editTitle"">Başlık</label>
                        <input type=""text"" class=""form-control"" id=""editTitle"" name=""Title"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""editContent"">İçerik</label>
                        <textarea class=""form-control"" id=""editContent"" name=""Content""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""editDate"">Tarih</label>
                        <input type=""datetime-local"" class=""form-control"" id=""editDate"" name=""Date"" />
                    </div>

                    <div class=""form-group"">
                        <label for=""editStatus"">Durum</label>
                        <input type=""number"" min=""0"" max=""3"" class=""form-control"" id=""editStatus"" name=""Status"" />

                    </div>
          ");
                WriteLiteral(@"          <input type=""hidden"" id=""editNotId"" name=""Id"" />
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
    function openEditNotification(notid) {
        // AJAX isteği yap
        $.ajax({
            url: '/Default/NotificationDetail/' + notid,
            type: 'GET',
            success: function (response) {
                // Gelen verilerle modalı doldur
                $('#editTitle').val(response.title);
                $('#editContent').val(response.content);
                $('#editDate').val(response.date);
                $('#editStatus').val(response.status);
                $('#editNotId').val(response.id);

                $('#duzenleModal').modal('show');
            },
            error: function (error) {
                console.log(error);
            }
        });
    }


    // Kaydet butonuna basıldığında
    $(document).on('submit', '#editNotificationForm', function (e) {
        e.preventDefault(); // Sayfanın yeniden yüklenmesini engelle

        var formData = $(this).serialize(); // Form verilerini al
     ");
            WriteLiteral(@"   var url = $(this).attr('action'); // Formun gönderileceği URL

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
