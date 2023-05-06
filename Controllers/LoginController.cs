using System;
using System.Collections.Generic;
using PIETAPA4MaxwellAraujo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PIETAPA4MaxwellAraujo.Controllers
{
    public class LoginController : Controller
    {
        

       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginAcesso loginAcesso)
        {
            UsuarioLogin usuarioLogin = new UsuarioLogin();
            LoginAcesso loginAcessoSessao = usuarioLogin.ValidarLogin(loginAcesso);

            if(loginAcesso != null) 
            {
                ViewBag.Mensagem="Você está logado!";
                HttpContext.Session.SetInt32("IdLoginAcesso", loginAcessoSessao.id);
                HttpContext.Session.SetString("NomeLoginAcesso", loginAcessoSessao.login);

                return Redirect("Cadastro");
            } else {
                ViewBag.Mensagem = "Falha no login!";
                return View();
            }
        }

         public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}