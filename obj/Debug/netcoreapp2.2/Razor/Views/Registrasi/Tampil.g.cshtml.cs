#pragma checksum "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a5c8eb05ce0764ad1a700431d6645b02d4798fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registrasi_Tampil), @"mvc.1.0.view", @"/Views/Registrasi/Tampil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registrasi/Tampil.cshtml", typeof(AspNetCore.Views_Registrasi_Tampil))]
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
#line 1 "C:\Kuliah\2019\SampleASPCore\Views\_ViewImports.cshtml"
using SampleASPCore;

#line default
#line hidden
#line 2 "C:\Kuliah\2019\SampleASPCore\Views\_ViewImports.cshtml"
using SampleASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a5c8eb05ce0764ad1a700431d6645b02d4798fe", @"/Views/Registrasi/Tampil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d333f8d5d686f7d92ce436d3ba3663d9a602e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Registrasi_Tampil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
  
   Layout = "_Layout"; 

   string nama = "Erick";
   string alamat = "Jl Mangga 11";

   int bil1 = 11;
   int bil2 = 12;
   int hasil = bil1+bil2;

#line default
#line hidden
            BeginContext(164, 32, true);
            WriteLiteral("\r\n<h2>Detail Anggota</h2>\r\n\r\n<p>");
            EndContext();
            BeginContext(197, 4, false);
#line 14 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
Write(nama);

#line default
#line hidden
            EndContext();
            BeginContext(201, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(203, 6, false);
#line 14 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
    Write(alamat);

#line default
#line hidden
            EndContext();
            BeginContext(209, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(219, 4, false);
#line 15 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
Write(bil1);

#line default
#line hidden
            EndContext();
            BeginContext(223, 3, true);
            WriteLiteral(" + ");
            EndContext();
            BeginContext(227, 4, false);
#line 15 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
      Write(bil2);

#line default
#line hidden
            EndContext();
            BeginContext(231, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(235, 5, false);
#line 15 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
              Write(hasil);

#line default
#line hidden
            EndContext();
            BeginContext(240, 16, true);
            WriteLiteral("</p>\r\n<p>Name : ");
            EndContext();
            BeginContext(257, 15, false);
#line 16 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
     Write(Model.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(272, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(274, 14, false);
#line 16 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
                      Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(288, 19, true);
            WriteLiteral("</p>\r\n<p>Address : ");
            EndContext();
            BeginContext(308, 13, false);
#line 17 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
        Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(321, 16, true);
            WriteLiteral("</p>\r\n<p>Telp : ");
            EndContext();
            BeginContext(338, 10, false);
#line 18 "C:\Kuliah\2019\SampleASPCore\Views\Registrasi\Tampil.cshtml"
     Write(Model.Telp);

#line default
#line hidden
            EndContext();
            BeginContext(348, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
