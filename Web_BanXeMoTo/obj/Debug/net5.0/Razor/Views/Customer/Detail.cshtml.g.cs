#pragma checksum "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cac3ce478d4e666b26471b0c1769bf75ab4f6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Detail), @"mvc.1.0.view", @"/Views/Customer/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cac3ce478d4e666b26471b0c1769bf75ab4f6c", @"/Views/Customer/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932e652f77ec83008959bfefacc459e116bf9f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web_BanXeMoTo.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_LayoutManager.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"app-main__inner\">\n    <h1>Detail</h1>\n\n    <div>\n        <h4>KhachHang</h4>\n        <hr />\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 15 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Idkh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 18 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Idkh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 21 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 24 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 33 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.TenKh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 36 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.TenKh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 39 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 42 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 45 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 48 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 51 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayNameFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 54 "D:\SCHOOLS\HUFLIT\Do An 01\PF_Project\DA1_WEB\Web_BanXeMoTo\Views\Customer\Detail.cshtml"
           Write(Html.DisplayFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n");
            WriteLiteral("        </dl>\n\n\n    </div>\n    <div>\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cac3ce478d4e666b26471b0c1769bf75ab4f6c7844", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web_BanXeMoTo.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
