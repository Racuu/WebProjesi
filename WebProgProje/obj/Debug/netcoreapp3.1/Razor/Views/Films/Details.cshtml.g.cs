#pragma checksum "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f6d61942ac3397f1632c6270ca71e1746c4040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films_Details), @"mvc.1.0.view", @"/Views/Films/Details.cshtml")]
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
#line 1 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\_ViewImports.cshtml"
using WebProgProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\_ViewImports.cshtml"
using WebProgProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f6d61942ac3397f1632c6270ca71e1746c4040", @"/Views/Films/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cf9a083faefde61eb88ce503fe3062bd4d11e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Films_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebProgProje.Models.FilmModel.Film>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
  
    ViewData["Title"] = "Film Detayları";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Detaylar</h1>\n\n<div>\n    <h4>Film</h4>\n    <hr />\n    <div class=\" row\">\n        <div class=\"col-md-6\">\n\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 237, "\"", 284, 1);
#nullable restore
#line 15 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
WriteAttributeValue("", 243, Html.DisplayFor(model => model.ResimUrl), 243, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"width:350px;height:350px;\">\n        </div>\n\n        <dl class=\"row col-md-6\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 20 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 23 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayFor(model => model.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 26 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.YaziGiris));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 29 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayFor(model => model.YaziGiris));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 32 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Etiket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 35 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
           Write(Html.DisplayFor(model => model.Etiket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>\n    <br /><br />\n    <h3>\n        ");
#nullable restore
#line 41 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h3>\n    \n    <div>\n        ");
#nullable restore
#line 45 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
   Write(Html.DisplayFor(model => model.Yazi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n</div>\n<div>\n");
#nullable restore
#line 50 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f6d61942ac3397f1632c6270ca71e1746c40407474", async() => {
                WriteLiteral("Düzenle");
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
#line 52 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
                               WriteLiteral(Model.Id);

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
            WriteLiteral("\n");
#nullable restore
#line 53 "C:\Users\mucah\Desktop\film-nasildi-master\WebProgProje\Views\Films\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2f6d61942ac3397f1632c6270ca71e1746c40409832", async() => {
                WriteLiteral("Listeye geri dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebProgProje.Models.FilmModel.Film> Html { get; private set; }
    }
}
#pragma warning restore 1591
