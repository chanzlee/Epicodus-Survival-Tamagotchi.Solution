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
        Survivor.currentSurvivor = newSurvivor;
        return View("Index", Survivor.currentSurvivor);
      }

      [HttpPost("/survivor/coding")]
      public ActionResult Coding()
      {
        Survivor.currentSurvivor.IncreaseCodingSkill();
        return View("Index", Survivor.currentSurvivor);
      }

      [HttpPost("/survivor/caffeine")]
      public ActionResult Caffeine()
      {
        Survivor.currentSurvivor.IncreaseCaffeine();
        return View("Index", Survivor.currentSurvivor);
      }

      [HttpPost("/survivor/sleep")]
      public ActionResult Sleep()
      {
        Survivor.currentSurvivor.IncreaseSleep();
        return View("Index", Survivor.currentSurvivor);
      }



    }
}
