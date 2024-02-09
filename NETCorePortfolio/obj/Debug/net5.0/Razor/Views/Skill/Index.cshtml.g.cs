#pragma checksum "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c822709454282b90cc7eff4ad06014ab528931a55c8b208af801cc80d067ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7c822709454282b90cc7eff4ad06014ab528931a55c8b208af801cc80d067ed6", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d1eff688a01f71a47eda37782a8476c6020b9c570c04b73a5ee07c4294ed3396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Skill/AddSkill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editSkillForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Skill/EditSkill/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Yeteneklerim";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0 d-flex justify-content-between\">\r\n    <button type=\"button\" class=\"btn btn-primary\">\r\n        <span>Yeteneklerim</span>\r\n        <span class=\"badge badge-md badge-circle badge-floating badge-secondary p-2 border-white\">");
#nullable restore
#line 11 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
                                                                                             Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </button>\r\n    <button class=\"btn btn-success\" data-toggle=\"modal\" data-target=\"#yeniyetenekekle\">Yeni Yetenek Ekle</button>\r\n</div>\r\n\r\n");
            WriteLiteral(@"
<!-- Yetenek ekleme Modal -->
<div class=""modal fade"" id=""yeniyetenekekle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""yeniyetenekekleTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""yeniyetenekekleTitle"">Yeni Yetenek Ekle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c822709454282b90cc7eff4ad06014ab528931a55c8b208af801cc80d067ed67019", async() => {
                WriteLiteral(@"

            
            <div class=""modal-body"">
                <div class=""row d-flex flex-column"">
                    <div class=""form-group"">
                        <label>Yetenek Adı</label>
                        <input type=""text"" class=""form-control"" name=""Title"" />
                    </div>
                    <div class=""form-group"">
                        <label>Oran</label>
                        <input type=""text"" class=""form-control"" name=""Value"" />
                    </div>
                </div>
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

<!-- Yetenek Düzenleme Modal -->
<!-- Düzenleme Modal -->
<div class=""modal fade"" id=""duzenleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""duzenleModalTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""duzenleModalTitle"">Yetenek Düzenle</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c822709454282b90cc7eff4ad06014ab528931a55c8b208af801cc80d067ed610087", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""editTitle"">Yetenek Adı</label>
                        <input type=""text"" class=""form-control"" id=""editTitle"" name=""Title"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""editValue"">Oran</label>
                        <input type=""text"" class=""form-control"" id=""editValue"" name=""Value"" />
                    </div>
                    <!-- Hidden input to hold the SkillID -->
                    <input type=""hidden"" id=""editSkillId"" name=""SkillID"" />
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



<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col"">Sil</th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 100 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
             foreach(var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">\r\n                        <div class=\"media align-items-center\">\r\n                            <a class=\"avatar rounded-circle mr-3\">\r\n                                ");
#nullable restore
#line 106 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
                           Write(i.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 111 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
                   Write(i.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 116 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
                                                     Write(i.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                            <div>\r\n                                <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 5178, "\"", 5202, 1);
#nullable restore
#line 119 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
WriteAttributeValue("", 5194, i.Value, 5194, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 5241, "\"", 5266, 3);
            WriteAttributeValue("", 5249, "width:", 5249, 6, true);
#nullable restore
#line 119 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 5255, i.Value, 5256, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5264, "%;", 5264, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5492, "\"", 5527, 3);
            WriteAttributeValue("", 5502, "openEditModal(", 5502, 14, true);
#nullable restore
#line 125 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
WriteAttributeValue("", 5516, i.SkillID, 5516, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5526, ")", 5526, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Düzenle</button>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5628, "\"", 5664, 2);
            WriteAttributeValue("", 5635, "/Skill/DeleteSkill/", 5635, 19, true);
#nullable restore
#line 129 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
WriteAttributeValue("", 5654, i.SkillID, 5654, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 132 "D:\NETCorePortfolio\NETCorePortfolio\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c822709454282b90cc7eff4ad06014ab528931a55c8b208af801cc80d067ed617634", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
