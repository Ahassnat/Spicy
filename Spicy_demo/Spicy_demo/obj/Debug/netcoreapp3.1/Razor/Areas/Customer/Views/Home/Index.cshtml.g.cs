#pragma checksum "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2cc3ab45af3b0e932f53cd64cea9942a7ee0aba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\_ViewImports.cshtml"
using Spicy_demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\_ViewImports.cshtml"
using Spicy_demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2cc3ab45af3b0e932f53cd64cea9942a7ee0aba", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8908beca30cb1600a3de0a8551c51a99cdebd4dd", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spicy_demo.Models.View_Models.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_menuitemsCustomerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\r\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"2500\">\r\n");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.Count(); i++)
            {
                if (i == 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                     if (Model.Coupon.ToList()[i].Picture != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item active\">\r\n");
#nullable restore
#line 17 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                              
                                var base64 = Model.Coupon.ToList()[i].Picture;
                                var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 789, "\"", 802, 1);
#nullable restore
#line 21 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 795, imgsrc, 795, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n                        </div>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                     

                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                     if (Model.Coupon.ToList()[i].Picture != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"carousel-item\">\r\n");
#nullable restore
#line 31 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                              
                                var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                                var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1404, "\"", 1417, 1);
#nullable restore
#line 36 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1410, imgsrc, 1410, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
                     
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<div class=\"backgroundWhite container\">\r\n");
#nullable restore
#line 47 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var item in Model.Category)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2cc3ab45af3b0e932f53cd64cea9942a7ee0aba8446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(c=>c.Category.Name==item.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Admin\source\repos\Spicy_demo\Spicy_demo\Areas\Customer\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spicy_demo.Models.View_Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
