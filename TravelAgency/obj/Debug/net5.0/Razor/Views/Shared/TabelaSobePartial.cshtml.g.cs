#pragma checksum "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f090fd50c51ff4c4c8c8146c62f50d069fd0369"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TabelaSobePartial), @"mvc.1.0.view", @"/Views/Shared/TabelaSobePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f090fd50c51ff4c4c8c8146c62f50d069fd0369", @"/Views/Shared/TabelaSobePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73229d79ca6450a5a2a119d92dd667de6cae449", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TabelaSobePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Domain.Soba>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 5 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml"
       Write(item.BrojSobe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 6 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml"
       Write(item.TipSobe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 7 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml"
       Write(item.Zauzeta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 9 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\TabelaSobePartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Domain.Soba>> Html { get; private set; }
    }
}
#pragma warning restore 1591
