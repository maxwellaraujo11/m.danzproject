using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIETAPA4MaxwellAraujo.Models;

namespace PIETAPA4MaxwellAraujo
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
        
            UsuarioLogin teste = new UsuarioLogin();
            teste.TestarConexao();
            return View();
        }

        public IActionResult LoginAcesso()
        {
            UsuarioLogin teste = new UsuarioLogin();
            teste.TestarConexao();
            return View();
        }

        public IActionResult historia()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Videos()
        {
            return View();
        }

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
        
        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
