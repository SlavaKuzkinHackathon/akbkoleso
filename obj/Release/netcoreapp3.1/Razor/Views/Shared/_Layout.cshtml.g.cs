#pragma checksum "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5802eb84190c0fbe1d7f21e8003a68635b619e93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5802eb84190c0fbe1d7f21e8003a68635b619e93", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5802eb84190c0fbe1d7f21e8003a68635b619e932889", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""viewport"" content=""width=device-width"" />
    <meta name=""description"" content=""Продажа шин, дисков, аккумуляторов в Новосибирске. недорогие шины диски аккумуляторы . зимняя шипованная резина штамповки японские аккумуляторы  Новосибирск."" />
    <meta name=""keywords"" content=""купить шины, диски, аккумуляторы, недорого, автоград Новосибирск"" />
    <title>");
#nullable restore
#line 9 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  Автоградшина | Шины, Диски, Аккумуляторы в Новосибирске </title>
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Ubuntu:wght@300;400;500&display=swap"" rel=""stylesheet"">
    <style>
        #loading {
            width: 100%;
            height: 100%;
            position: fixed;
            z-index: 9999;
            background: url('");
#nullable restore
#line 19 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
                        Write(Url.Content("~/images/public/preloader.gif"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\') no-repeat center center rgb(255, 255, 255);\r\n        }\r\n    </style>\r\n    ");
#nullable restore
#line 22 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 23 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5802eb84190c0fbe1d7f21e8003a68635b619e935957", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 26 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_NavCategory"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            <!-- Спиннер -->\r\n            <div id=\"loading\"></div>\r\n            ");
#nullable restore
#line 32 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </main>\r\n    </div>\r\n    ");
#nullable restore
#line 35 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 37 "C:\Users\Vyacheslav\Desktop\akb\11_deploy_1\akbkoleso\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function () {

            $('div#loading').hide();

        })
    </script>
    <!-- Yandex.Metrika counter -->
    <script type=""text/javascript"">
        (function (m, e, t, r, i, k, a) {
        m[i] = m[i] || function () { (m[i].a = m[i].a || []).push(arguments) };
            m[i].l = 1 * new Date(); k = e.createElement(t), a = e.getElementsByTagName(t)[0], k.async = 1, k.src = r, a.parentNode.insertBefore(k, a)
        })
        (window, document, ""script"", ""https://mc.yandex.ru/metrika/tag.js"", ""ym"");

    ym(62460400, ""init"", {
        clickmap: true,
        trackLinks: true,
        accurateTrackBounce: true,
        ecommerce: ""dataLayer""
    });
    </script>
    <noscript><div><img src=""https://mc.yandex.ru/watch/62460400"" style=""position:absolute; left:-9999px;""");
                BeginWriteAttribute("alt", " alt=\"", 2543, "\"", 2549, 0);
                EndWriteAttribute();
                WriteLiteral(" /></div></noscript>\r\n    <!-- /Yandex.Metrika counter -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
