#pragma checksum "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7eb43bf6b35cf640e40d5d24af4eed18bfe07a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageOptions), @"mvc.1.0.view", @"/Views/Shared/PageOptions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7eb43bf6b35cf640e40d5d24af4eed18bfe07a", @"/Views/Shared/PageOptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PageOptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-fluid mt-2"">
    <div class=""row m-1"">
        <div class=""col""></div>
        <div class=""col-1"">
            <label class=""col-form-label"">Поиск</label>
        </div>
        <div class=""col-3"">
            <select form=""pageform"" name=""options.searchpropertyname""
                    class=""form-control"">
");
#nullable restore
#line 10 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                 foreach (string s in ViewBag.searches as string[])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c7eb43bf6b35cf640e40d5d24af4eed18bfe07a3392", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 14 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                    Write(s.IndexOf('.') == -1 ? s : s.Substring(0, s.IndexOf('.')));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                       WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
AddHtmlAttributeValue("", 507, Model.Options.SearchPropertyName == s, 507, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"col\">\r\n            <input form=\"pageform\" class=\"form-control\" name=\"options.searchterm\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 836, "\"", 889, 1);
#nullable restore
#line 22 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
WriteAttributeValue("", 864, Model.Options.SearchTerm, 864, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>

        <div class=""col-1 text-right"">
            <button form=""pageform"" class=""btn btn-secondary"" type=""submit"">
                Поиск
            </button>
        </div>
        <div class=""col""></div>
    </div>
    <div class=""m-1"">
        <div class=""col""></div>
        <div class=""col-1"">
            <label class=""col-form-label"">Сортировка</label>
        </div>
        <div class=""col-3"">
            <select form=""pageform"" name=""options.OrderPropertyName""
                    class=""form-control"">
");
#nullable restore
#line 40 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                 foreach (string s in ViewBag.sorts as string[])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c7eb43bf6b35cf640e40d5d24af4eed18bfe07a7476", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                    Write(s.IndexOf('.') == -1 ? s : s.Substring(0, s.IndexOf('.')));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                       WriteLiteral(s);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
AddHtmlAttributeValue("", 1606, Model.Options.OrderPropertyName == s, 1606, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""col form-check form-check-inline"">
            <input form=""pageform"" type=""checkbox"" name=""Options.DescendingOrder""
                   id=""Options.DescendingOrder""
                   class=""form-check-input"" value=""true""");
            BeginWriteAttribute("checked", "\r\n                   checked=\"", 2068, "\"", 2128, 1);
#nullable restore
#line 53 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\Shared\PageOptions.cshtml"
WriteAttributeValue("", 2098, Model.Options.DescendingOrder, 2098, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
            <label class=""form-check-label"">Порядок по убыванию</label>
        </div>
        <div class=""col-1 text-right"">
            <button form=""pageform"" class=""btn btn-secondary"" type=""submit"">
                Сортировать
            </button>
        </div>
        <div class=""col""></div>
    </div>
</div>");
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