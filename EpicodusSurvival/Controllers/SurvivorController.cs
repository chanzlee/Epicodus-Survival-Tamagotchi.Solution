using Microsoft.AspNetCore.Mvc;
using EpicodusSurvival.Models;

namespace EpicodusSurvival.Controllers
{
    public class SurvivorController : Controller
    {
      [HttpGet("/survivor")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/survivor/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/survivor")]
      public ActionResult Create()
      {
      Survivor newSurvivor = new Survivor(Request.Form["survName"]);
      return View("Index", newSurvivor);
      }


    }
}
