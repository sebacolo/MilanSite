using Microsoft.AspNetCore.Mvc;

namespace milanSite.Controllers
{
    public class HomeController : Controller
    {
        // Azione per la pagina principale
        public IActionResult Index()
        {
            return View();
        }

        // Azione per la pagina formazione
        public IActionResult Formazione()
        {
            return View();
        }

        // Altre azioni per le altre pagine
        public IActionResult PurchaseTickets()
        {
            return View();
        }

        public IActionResult Purchase()
        {
            return View();
        }

        public IActionResult CaricoCredito()
        {
            return View();
        }

        public IActionResult Trofei()
        {
            return View();
        }

        public IActionResult PurchaseTicket()
        {
            return View();
        }
    }
}
