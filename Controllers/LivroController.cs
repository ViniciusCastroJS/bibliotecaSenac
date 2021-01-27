using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {
            LivroService livroService = new LivroService();

            if(l.Id == 0)
            {
                livroService.Inserir(l);
            }
            else
            {
                livroService.Atualizar(l);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro, int? pagina)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            int NumeroPag = pagina ?? 1;
            int PagSize = 10;
            LivroService livroService = new LivroService();
            var PagLivro = livroService.ListarTodos(objFiltro).ToPagedList(NumeroPag, PagSize);
            return View(PagLivro);
        }

        public IActionResult ListagemUsuario(string tipoFiltro, string filtro, int? pagina)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            int NumeroPag = pagina ?? 1;
            int PagSize = 10;
            LivroService livroService = new LivroService();
            UsuarioService usuarioService = new UsuarioService();
            Usuario u = usuarioService.ObterPorLogin(HttpContext.Session.GetString("user"));
            EmprestimoService emprestimoService = new EmprestimoService();
            IList<Emprestimo> em = emprestimoService.ObterEmcomUserId(u.Id);
            IList<Livro> PagLivro = new List<Livro>();
            foreach (var item in em)
            {
                PagLivro.Add(livroService.ListarTodosPorId(item.LivroId));
            }
            
            IPagedList<Livro> Livros = PagLivro.ToPagedList(NumeroPag, PagSize);

            return View(Livros);
        }



        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }
    }
}