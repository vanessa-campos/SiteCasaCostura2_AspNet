#pragma checksum "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bcff58e73dc1bf006a26a6bc6af4fc5c85a0f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Vendidos), @"mvc.1.0.view", @"/Views/Produtos/Vendidos.cshtml")]
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
#line 1 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\_ViewImports.cshtml"
using CasaCosturaCadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\_ViewImports.cshtml"
using CasaCosturaCadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bcff58e73dc1bf006a26a6bc6af4fc5c85a0f74", @"/Views/Produtos/Vendidos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70cdd8501293c6e5c8bc18c736f49f3e22c9debf", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Vendidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Vendidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
  
    ViewData["Title"] = "Listagem Vendidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">    
    <div class=""col pt-2 mx-3 justify-content-center"">
        <h1 class=""text-center my-5"" style=""color: #f06eaa""><b>LISTA DE PRODUTOS VENDIDOS</b></h1>
        <div class=""table-responsive-sm col-md-12 col-sm-4 px-5"">        
");
#nullable restore
#line 10 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
             if(Model.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th class=""col-1"">Id</th>
                            <th class=""col-2"">Nome do Produto</th>
                            <th class=""col-3"">Descrição</th>
                            <th class=""col-2"">Tamanho</th>
                            <th class=""col-1"">Valor (R$)</th>
                            <th class=""col-1"">Qt</th>
                            <th class=""col-2"">Data Venda</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                         foreach (Vendidos v in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 26 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-2\">");
#nullable restore
#line 27 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-3\">");
#nullable restore
#line 28 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-2\">");
#nullable restore
#line 29 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 30 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 31 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-2\">");
#nullable restore
#line 32 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                             Write(v.DataVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>   \r\n");
#nullable restore
#line 34 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                        }  

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>   \r\n                </table>             \r\n");
#nullable restore
#line 37 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
            }else{    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-dark\">Nenhum produto vendido!</p>\r\n");
#nullable restore
#line 39 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <ul class=\"pagination col-12 justify-content-center \" style=\"margin:20px 0\">\r\n");
#nullable restore
#line 46 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
         for (int i = 1; i <= (int)ViewData["Pages"]; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link btn btn-light text-white m-2\"");
            BeginWriteAttribute("href", " href=\"", 2087, "\"", 2118, 2);
            WriteAttributeValue("", 2094, "/Produtos/Vendidos/?p=", 2094, 22, true);
#nullable restore
#line 47 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
WriteAttributeValue("", 2116, i, 2116, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">");
#nullable restore
#line 47 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 48 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Vendidos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Vendidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591