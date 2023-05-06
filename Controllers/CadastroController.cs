using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using PIETAPA4MaxwellAraujo.Models;
using System;
using Microsoft.AspNetCore.Http;

namespace PIETAPA4MaxwellAraujo.Controllers
{
    public class CadastroController : Controller
    {     

        public IActionResult Cadastro()
        {
                        return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Cadastro cadastro)
        {
                       
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Inserir(cadastro);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();            
        }

//----------------------------------------------------------------------------------------//



        public IActionResult Login()
        {
            return View();
        }
 
   }
}