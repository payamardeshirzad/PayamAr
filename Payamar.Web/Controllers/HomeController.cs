using System.Web.Mvc;

namespace Payamar.Web.Controllers
{
    public class HomeController : PayamarControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}