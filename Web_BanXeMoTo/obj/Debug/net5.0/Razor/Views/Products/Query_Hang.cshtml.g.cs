#pragma checksum "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbfca4593a23172c18c6caa9972bd31ea27b90c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Query_Hang), @"mvc.1.0.view", @"/Views/Products/Query_Hang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbfca4593a23172c18c6caa9972bd31ea27b90c3", @"/Views/Products/Query_Hang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Query_Hang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Controllers.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductsDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
  
    ViewData["Title"] = "Query_Hang";
    Layout = "~/Views/Shared/_LayoutCustomer.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--about-us start -->
<section id=""home"" class=""about-us"">
    <div class=""container"">
        <div class=""about-us-content"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""single-about-us"">
                        <div class=""about-us-txt"">
                            <h2>If passion is the path to success, persistence is your motorcycle</h2>                           
                        </div><!--/.about-us-txt-->
                    </div><!--/.single-about-us-->
                </div><!--/.col-->
                <div class=""col-sm-0"">
                    <div class=""single-about-us"">

                    </div><!--/.single-about-us-->
                </div><!--/.col-->
            </div><!--/.row-->
        </div><!--/.about-us-content-->
    </div><!--/.container-->

</section><!--/.about-us-->
<!--about-us end -->

");
            WriteLiteral("<div class=\"container\">\r\n    <table class=\"table\">\r\n");
#nullable restore
#line 39 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
         foreach (var hang in Model.ListHang)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <div class=\"gallary-header\">\r\n                <h2>\r\n                    ");
#nullable restore
#line 44 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
               Write(Html.DisplayFor(model => hang.TenHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n");
#nullable restore
#line 48 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
             foreach (var mau in Model.ListMauXe)
            {
                if (mau.Idhang == hang.Idhang)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 col-sm-6\">\r\n                        <div class=\"single-package-item\">\r\n                            <i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbfca4593a23172c18c6caa9972bd31ea27b90c35751", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 1965, "\"", 1996, 1);
#nullable restore
#line 54 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
WriteAttributeValue("", 1971, "/img/" + mau.HinhAnh1, 1971, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"package-place\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
                                                                WriteLiteral(mau.Idmau);

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
            WriteLiteral("</i>\r\n                            <div class=\"single-package-item-txt\">\r\n                                <h3>");
#nullable restore
#line 56 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
                               Write(Html.DisplayFor(model => mau.TenXe));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><span class=\"pull-right\">");
#nullable restore
#line 56 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
                                                                                                   Write((int)mau.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></h3>\r\n                                <div class=\"packages-para\">\r\n                                    <p>\r\n                                        <span>\r\n                                            <i class=\"fa fa-angle-right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbfca4593a23172c18c6caa9972bd31ea27b90c39367", async() => {
                WriteLiteral("Thông số sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
                                                                                                          WriteLiteral(mau.Idmau);

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
            WriteLiteral(@"</i>
                                        </span>
                                    </p>
                                </div><!--/.packages-para-->
                                <div class=""packages-review"">
                                    <p>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <span>254 reviews</span>
                                    </p>
                                </div><!--/.packages-review-->
                                <div class=""about-btn"">
                                    <button class=""about-view packages-btn"">
                                        book now
                                    </button>
                 ");
            WriteLiteral("               </div><!--/.about-btn-->\r\n                            </div><!--/.single-package-item-txt-->\r\n                        </div><!--/.single-package-item-->\r\n                    </div><!--/.col-->\r\n");
#nullable restore
#line 82 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Products\Query_Hang.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Controllers.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
