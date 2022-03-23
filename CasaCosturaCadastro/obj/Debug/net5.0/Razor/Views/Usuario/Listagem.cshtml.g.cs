#pragma checksum "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35436a33ac08d65993b504893d75f1f89bbf5c3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listagem), @"mvc.1.0.view", @"/Views/Usuario/Listagem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35436a33ac08d65993b504893d75f1f89bbf5c3c", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70cdd8501293c6e5c8bc18c736f49f3e22c9debf", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">    
    <div class=""col pt-2 mx-3 justify-content-center"">
        <h1 class=""text-center my-5"" style=""color: #f06eaa""><b>USUÁRIOS CADASTRADOS</b></h1>
        <div class=""table-responsive-sm col-md-12 col-sm-4"">                    
");
#nullable restore
#line 10 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
             if(Model.Count > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th class=""col-1"">Tipo</th>                       
                        <th class=""col-3"">Login</th>
                        <th class=""col-3"">Senha</th>
                        <th class=""col-3"">Nome</th>
                        <th class=""col-1""></th>
                        <th class=""col-1""></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                     foreach (Usuario u in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 25 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                         if(u.Tipo == Usuario.ADMIN){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-1\">Administrador</td>\r\n");
#nullable restore
#line 27 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td class=\"col-1\">Padrão</td>\r\n");
#nullable restore
#line 29 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"col-3\">");
#nullable restore
#line 30 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                                     Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-3\">");
#nullable restore
#line 31 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                                     Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"col-3\">");
#nullable restore
#line 32 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                                     Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                        <td class=\"col-1\"><a class=\"page-link btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 1448, "\"", 1476, 2);
            WriteAttributeValue("", 1455, "/Usuario/Edicao/", 1455, 16, true);
#nullable restore
#line 33 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1471, u.Id, 1471, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">Editar</a></td>\r\n                        <td class=\"col-1\"><a class=\"page-link btn btn-light text-white\"");
            BeginWriteAttribute("href", " href=\"", 1617, "\"", 1646, 2);
            WriteAttributeValue("", 1624, "/Usuario/Excluir/", 1624, 17, true);
#nullable restore
#line 34 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 1641, u.Id, 1641, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">Excluir</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>   \r\n            </table>\r\n");
#nullable restore
#line 39 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
            }else{    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Nenhum registro encontrado!</p>\r\n");
#nullable restore
#line 41 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <ul class=\"pagination col-12 justify-content-center \" style=\"margin:20px 0\">\r\n");
#nullable restore
#line 49 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
         for (int i = 1; i <= (int)ViewData["Pages"]; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link btn btn-light text-white m-2\"");
            BeginWriteAttribute("href", " href=\"", 2178, "\"", 2208, 2);
            WriteAttributeValue("", 2185, "/Usuario/Listagem/?p=", 2185, 21, true);
#nullable restore
#line 50 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 2206, i, 2206, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: #f06eaa;\">");
#nullable restore
#line 50 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
                                                                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "G:\Meu Drive\A Casa da Costura\Sites\CasaCosturaCadastro\Views\Usuario\Listagem.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
