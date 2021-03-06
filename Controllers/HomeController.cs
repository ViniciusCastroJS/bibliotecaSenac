﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            
            if(HttpContext.Session.GetString("user") != "admin")
            {
                return RedirectToAction("UsuarioIndex");
            }
            return View();
        }

        public IActionResult UsuarioIndex()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {
            UsuarioService usuarioService = new UsuarioService();
            List<Usuario> usuarios = usuarioService.ListarTodos();

            if (login == "admin" && senha == "123" )
            {
                    HttpContext.Session.SetString("user", "admin");
                    return RedirectToAction("Index");
            }
            else{
                foreach (Usuario u in usuarios){

                    if (u.Login == login && u.Senha == senha )
                    {
                        HttpContext.Session.SetString("user", u.Login);
                        return RedirectToAction("UsuarioIndex");
                    }
                }
            }

            ViewData["Erro"] = "Senha inválida";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
