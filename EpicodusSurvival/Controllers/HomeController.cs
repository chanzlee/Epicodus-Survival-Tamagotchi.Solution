using Microsoft.AspNetCore.Mvc;
using EpicodusSurvival.Models;

namespace EpicodusSurvival.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
