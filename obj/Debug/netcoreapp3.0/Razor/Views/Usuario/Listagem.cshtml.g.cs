#pragma checksum "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9cc4f39a468aa7244de2cb3aea86eaab7fce04a"
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
#line 1 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9cc4f39a468aa7244de2cb3aea86eaab7fce04a", @"/Views/Usuario/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f177e54b8cb2233769139cbcee409111fa8ef17d", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark border-bottom box-shadow mb-3\">\r\n            <div class=\"container\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9cc4f39a468aa7244de2cb3aea86eaab7fce04a4741", async() => {
                WriteLiteral("Biblioteca");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"" id=""menuLivros"">Livros</a>
                            <div class=""dropdown-menu"" aria-labelledby=""menuLivros"">
                                <a class=""dropdown-item"" href=""/Livro/Listagem"">Listagem</a>
                                <a class=""dropdown-item"" href=""/Livro/Cadastro"">Cadastro</a>
                            </div>
                        </li>                  ");
            WriteLiteral(@"     
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Emprestimo</a>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""/Emprestimo/Listagem"">Listagem</a>
                                <a class=""dropdown-item"" href=""/Emprestimo/Cadastro"">Cadastro</a>
                            </div>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link text-light dropdown-toggle"" data-toggle=""dropdown"" href=""#"">Usuários</a>
                            <div class=""dropdown-menu"">
                                <a class=""dropdown-item"" href=""/Usuario/Listagem"">Listagem</a>
                                <a class=""dropdown-item"" href=""/Usuario/Cadastro"">Cadastro</a>
                            </div>
                        </li>
                    </u");
            WriteLiteral(@"l>
                </div>
            </div>
        </nav>
    </header>


<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped""> 
            <thead>
                <tr><th>Id</th>
                <th>Login</th>
                <th>Senha</th>
                <th>Nome</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 57 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                 foreach(Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                   Write(u.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 3072, "\"", 3098, 2);
            WriteAttributeValue("", 3079, "/Livro/Edicao/", 3079, 14, true);
#nullable restore
#line 64 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
WriteAttributeValue("", 3093, u.Id, 3093, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Vinicius\Desktop\Netcore3.0\Biblioteca\Views\Usuario\Listagem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
