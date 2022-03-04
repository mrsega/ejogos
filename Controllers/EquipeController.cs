using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //IActionResult é apropriado para quando temos diversos tipos possíveis.

        //ActionResult representa vários códigos status HTTP.
        //[https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status]

        Equipe equipeModel = new Equipe()
        public IActionResult Index()
        {

            ViewBag.Equipes = equipeModel.LerEquipes();


            //ViewBag = RESERVA DE ESPAÇO PARA ARMAZENARMOS INFORMACOES PARA RECUPERAR NA VIEW

            //a ViewBag tem a função de "carregar" informações do Controller para a View
            return View();
        }
    }
}
