#pragma checksum "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7ea6ce72666092d00fba201c2b437d215295cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_StavkeRezervacijePartial), @"mvc.1.0.view", @"/Views/Shared/StavkeRezervacijePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7ea6ce72666092d00fba201c2b437d215295cb", @"/Views/Shared/StavkeRezervacijePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73229d79ca6450a5a2a119d92dd667de6cae449", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_StavkeRezervacijePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelAgency.Models.StavkaRezervacijeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 6 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
    Write(Model.Rb + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!--input hidden value=\"");
#nullable restore
#line 7 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
                            Write(Model.Rb+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"Rezervacija.StavkeRezervacije[");
#nullable restore
#line 7 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
                                                                              Write(Model.Rb);

#line default
#line hidden
#nullable disable
            WriteLiteral("].RB\" /-->\r\n    </td>\r\n    <td>\r\n");
            WriteLiteral("        <input hidden");
            BeginWriteAttribute("value", " value=\"", 266, "\"", 287, 1);
#nullable restore
#line 11 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
WriteAttributeValue("", 274, Model.GostID, 274, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 288, "\"", 342, 3);
            WriteAttributeValue("", 295, "Rezervacija.StavkeRezervacije[", 295, 30, true);
#nullable restore
#line 11 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
WriteAttributeValue("", 325, Model.Rb, 325, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 334, "].GostID", 334, 8, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </td> \r\n    <td>");
#nullable restore
#line 13 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
   Write(Model.Pasos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 14 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
   Write(Model.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 15 "C:\Users\Sara\source\repos\ASP.Net\TravelAgencyProject\TravelAgency\Views\Shared\StavkeRezervacijePartial.cshtml"
   Write(Model.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelAgency.Models.StavkaRezervacijeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
