#pragma checksum "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2680f9419c8a6900a3152e8921d45ffaf3fab10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Details), @"mvc.1.0.view", @"/Views/Hotel/Details.cshtml")]
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
#line 1 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\_ViewImports.cshtml"
using TravelAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\_ViewImports.cshtml"
using TravelAgency.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2680f9419c8a6900a3152e8921d45ffaf3fab10", @"/Views/Hotel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73229d79ca6450a5a2a119d92dd667de6cae449", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelAgency.Models.HotelVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("slika"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Hoteli11.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <p>Detalji</p>\r\n    <hr />\r\n    <div>\r\n        <div class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Zemlja));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Zemlja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Grad));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 32 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Grad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 35 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Adresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n        </div>\r\n        <div class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 49 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.Telefon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dl>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 55 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Hotel.BrojZvezdinca));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n            </dt>\r\n            <dl class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
           Write(Html.DisplayFor(model => model.Hotel.BrojZvezdinca));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dl>
        </div>
        <hr />

        <table class=""table table-dark"" id=""myTable"">
            <thead>
                <tr>
                    <th>
                        Broj sobe
                    </th>
                    <th>
                        Tip
                    </th>
                    <th>
                        Zauzeta
                    </th>
                    <th>

                    </th>
                </tr>
            </thead>
            <tbody >
");
#nullable restore
#line 81 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                 foreach (var item in Model.Sobe)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"table-dark\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.BrojSobe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"table-dark\">\r\n                            ");
#nullable restore
#line 88 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TipSobe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"table-dark\">\r\n                            ");
#nullable restore
#line 91 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Zauzeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td class=\"table-dark\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2680f9419c8a6900a3152e8921d45ffaf3fab1013051", async() => {
                WriteLiteral("\r\n                                Napravi rezervaciju\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                                                                           WriteLiteral(item.HotelID);

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
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Hotel\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <hr />\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2680f9419c8a6900a3152e8921d45ffaf3fab1015809", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-arrow-left\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2680f9419c8a6900a3152e8921d45ffaf3fab1017155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#myTable\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"

<style>
    .slika {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        object-fit: cover;
        opacity: 0.5;
        overflow: hidden;
    }

    .card {
        position: relative;
        z-index: 10;
        opacity: 0.8;
        margin: 2em 5em 0em 5em;
        justify-content: center;
        padding: 2em;
        opacity: 0.9;
    }


        .card p {
            text-align: center;
            letter-spacing: 5px;
            text-transform: uppercase;
        }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelAgency.Models.HotelVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
