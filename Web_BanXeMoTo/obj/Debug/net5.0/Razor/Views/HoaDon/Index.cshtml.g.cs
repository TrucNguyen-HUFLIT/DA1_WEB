#pragma checksum "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c5ac1296521281f7a4bf447faf71808d9cb3b2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HoaDon_Index), @"mvc.1.0.view", @"/Views/HoaDon/Index.cshtml")]
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
#nullable restore
#line 1 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\_ViewImports.cshtml"
using Web_BanXeMoTo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c5ac1296521281f7a4bf447faf71808d9cb3b2b", @"/Views/HoaDon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    public class Views_HoaDon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.HoaDonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
  
    ViewData["Title"] = "Create";

    Layout = "~/Views/Shared/_LayoutManager.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""app-main__inner"">
    <div class=""app-page-title"">
        <div class=""page-title-wrapper"">
            <div class=""page-title-heading"">
                <div>

                    Quản lý Hóa đơn

                </div>
            </div>
        </div>
    </div>
    <ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b6093", async() => {
                WriteLiteral("\n                <span>Danh sách hóa đơn</span>\n            ");
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
            WriteLiteral("\n        </li>\n        <li class=\"nav-item\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b7445", async() => {
                WriteLiteral("\n                <span>Tạo hóa đơn</span>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
    </ul>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""main-card mb-3 card"">
                <div class=""card-body"">
                    <table class=""table table-hover table-sm"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b9106", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 42 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDon.Idhd);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b10748", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 46 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDon.IdkhNavigation.TenKh);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </th>\n\n                                <th>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b12407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 50 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.HoaDon.NgayDat);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </th>
                                <th>
                                    <label class=""control-label"">Tổng tiền</label>
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 59 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                             foreach (var item in Model.ListHoaDon)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>\n                                        ");
#nullable restore
#line 63 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                   Write(item.Idhd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n\n                                    <td>\n");
#nullable restore
#line 67 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                         foreach (var kh in Model.ListKhachHang)
                                        {

                                            if (item.Idkh == kh.Idkh)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                           Write(kh.TenKh);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                                         
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\n                                    <td>\n                                        ");
#nullable restore
#line 77 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                   Write(item.NgayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td>\n");
#nullable restore
#line 80 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                          
                                            Int64 amount = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                             foreach (var cthd in Model.ListChiTietHd)
                                            {

                                                if (item.Idhd == cthd.Idhd)
                                                {
                                                    amount += (Int64)cthd.GiaBan * ((int)((cthd.KhuyenMai != 0) ? cthd.KhuyenMai / 100 : 1) );
                                                }
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                       Write(string.Format("{0:N0}", ((Int64)@amount)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\n                                    </td>\n                                    <td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c5ac1296521281f7a4bf447faf71808d9cb3b2b17934", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                                                                  WriteLiteral(item.Idhd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 98 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\HoaDon\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.HoaDonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
