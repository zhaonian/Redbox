using System.Web.Mvc;
using Redbox.Models;

namespace Redbox.Controllers
{
    public class MoviesController : Controller
    {
        // GET Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };
            return View();
        }
    }
}