#pragma checksum "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ea020bfcf0a150feb62ec8746ca8f0fa076c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_GetAllOrders), @"mvc.1.0.view", @"/Views/UserProfile/GetAllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ea020bfcf0a150feb62ec8746ca8f0fa076c61", @"/Views/UserProfile/GetAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_GetAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<akbkoleso.ViewModels.UserOrdersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3 my-4\">\r\n        <div class=\"list-group \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c616643", async() => {
                WriteLiteral("Данные пользователя");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c617906", async() => {
                WriteLiteral("Изменить данные");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                   WriteLiteral(Model.User.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6110169", async() => {
                WriteLiteral("Изменить пароль");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                             WriteLiteral(Model.User.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6112443", async() => {
                WriteLiteral("Корзина");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6113901", async() => {
                WriteLiteral("Заказы");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a class=\"list-group-item list-group-item-action\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6115224", async() => {
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"Выйти из профиля\" style=\"background:none;border:none;padding:0\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-9 my-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 23 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                         if (Model.User.Name == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h4>");
#nullable restore
#line 25 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                           Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 26 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h4>");
#nullable restore
#line 29 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                           Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 30 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <hr>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                 for (int i = Model.Orders.Count - 1; i >= 0; i--)
                {
                    var order = Model.Orders[i];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group row"">
                        <div class=""col-md-12"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <h5>Заказ № ");
#nullable restore
#line 43 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                   Write(order.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <h5><span class=\"badge badge-info badge-pill\">");
#nullable restore
#line 44 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                     Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h5>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-md-7 order-md-2"">
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Дата оформления:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 53 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.DateTime.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"г.</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Адрес доставки:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 57 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Получатель:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 61 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.UserFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                   Write(order.UserLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Телефон:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 65 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.UserPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Email:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 69 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Комменатрий:</div>
                                                <div class=""col-7"">");
#nullable restore
#line 73 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                              Write(order.UserComment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                            </div>
                                            <div class=""form-group row"">
                                                <div class=""col-5"" style=""color:darkgray"">Сумма заказа:</div>
                                                <div class=""col-7""><h6>");
#nullable restore
#line 77 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                  Write(order.FullPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381;</h6></div>\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"col-md-5 order-md-1\">\r\n");
#nullable restore
#line 81 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                             for (int j = 0; j < order.OrderItems.Count; j++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-group row\">\r\n                                                    <div class=\"col-md-4\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6125974", async() => {
                WriteLiteral("\r\n                                                            <img class=\"img-fluid d-none d-md-block rounded mb-2 shadow\" width=\"110\" height=\"110\"");
                BeginWriteAttribute("src", " src=\"", 5659, "\"", 5716, 1);
#nullable restore
#line 86 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
WriteAttributeValue("", 5665, Url.Content(order.OrderItems[j].Product.ImagePath), 5665, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Изображение товара\" />\r\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                                         WriteLiteral(order.OrderItems[j].Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    </div>\r\n                                                    <div class=\"form-group col-md-8 \">\r\n                                                        <div class=\"col-md-12\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99ea020bfcf0a150feb62ec8746ca8f0fa076c6129323", async() => {
#nullable restore
#line 90 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                                                                                                                          Write(order.OrderItems[j].Product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                                                                                  WriteLiteral(order.OrderItems[j].Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 91 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                         if (order.OrderItems[j].Amount > 1)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"col-md-12\"><h6>");
#nullable restore
#line 93 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                  Write(order.OrderItems[j].Product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381; х ");
#nullable restore
#line 93 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                                                                     Write(order.OrderItems[j].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\r\n");
#nullable restore
#line 94 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"col-md-12\"><h6>");
#nullable restore
#line 97 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                                                  Write(order.OrderItems[j].Product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &#8381;</h6></div>\r\n");
#nullable restore
#line 98 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 101 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 108 "C:\Users\Vyacheslav\Desktop\akb\11_git_1\akbkoleso\Views\UserProfile\GetAllOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<akbkoleso.ViewModels.UserOrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
