#pragma checksum "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2d8ca1644f97a2d5886f0d26f0efc6b13ff2f71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Costuras), @"mvc.1.0.view", @"/Views/Produtos/Costuras.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d8ca1644f97a2d5886f0d26f0efc6b13ff2f71", @"/Views/Produtos/Costuras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70cdd8501293c6e5c8bc18c736f49f3e22c9debf", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Costuras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Costura>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
  
    ViewData["Title"] = "Listagem Costura";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">    
    <div class=""col pt-2 mx-3 justify-content-center"">
        <h1 class=""text-center my-5"" style=""color: #f06eaa""><b>LISTA DE SERVIÇOS DE COSTURA</b></h1>    
            <div class=""table-responsive-sm col-md-12 col-sm-4 px-5"">        
");
#nullable restore
#line 10 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                 if(Model.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th class=""col-1"">Id</th>
                            <th class=""col-2"">Resumo</th>
                            <th class=""col-1"">Nome do Cliente</th>
                            <th class=""col-1"">Telefone</th>
                            <th class=""col-2"">Descrição</th>
                            <th class=""col-1"">Valor (R$)</th>
                            <th class=""col-1"">Data de Entrega</th>
                            <th class=""col-1"">Pago na hora</th>
                            <th class=""col-1"">Entregue</th>
                            <th class=""col-1""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                         foreach (Costura c in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 29 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-2\">");
#nullable restore
#line 30 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Resumo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 31 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 32 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-2\">");
#nullable restore
#line 33 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 34 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 35 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.DataEntrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 36 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Pago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\">");
#nullable restore
#line 37 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                             Write(c.Entregue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"col-1\"><a class=\"page-link btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 1988, "\"", 2020, 2);
            WriteAttributeValue("", 1995, "/Produtos/Atualizar/", 1995, 20, true);
#nullable restore
#line 38 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
WriteAttributeValue("", 2015, c.Id, 2015, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">Atualizar</a></td>\r\n                            </tr>   \r\n");
#nullable restore
#line 40 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                        }  

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>   \r\n                    </table>             \r\n");
#nullable restore
#line 43 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                    }else{    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-dark\">Nenhum serviço registrado!</p>\r\n");
#nullable restore
#line 45 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <ul class=\"pagination col-12 justify-content-center \" style=\"margin:20px 0\">\r\n");
#nullable restore
#line 52 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
         for (int i = 1; i <= (int)ViewData["Pages"]; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link btn btn-light text-white m-2\"");
            BeginWriteAttribute("href", " href=\"", 2640, "\"", 2671, 2);
            WriteAttributeValue("", 2647, "/Produtos/Costuras/?p=", 2647, 22, true);
#nullable restore
#line 53 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
WriteAttributeValue("", 2669, i, 2669, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">");
#nullable restore
#line 53 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
                                                                                                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 54 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Produtos\Costuras.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Costura>> Html { get; private set; }
    }
}
#pragma warning restore 1591