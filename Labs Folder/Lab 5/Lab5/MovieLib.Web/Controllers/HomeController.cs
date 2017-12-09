/*
 * Harrison Suffka
 * ITSE 1430
 * 12-08-2017
 */

using System.Web.Mvc;

namespace MovieLib.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}