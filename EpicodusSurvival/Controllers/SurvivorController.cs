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
        if (Survivor.currentSurvivor.GetCodingSkill()>=100)
        {
          return View("Graduate", Survivor.currentSurvivor);
        }
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

      [HttpPost("/survivor/decay")]
      public ActionResult Decay()
      {
        var mortal = Survivor.currentSurvivor;
        Survivor.TimeDecay(mortal);
        if(mortal.GetSleep()<=0)
        {
          return View("GameOver");
        }
        if(mortal.GetCaffeine()<=0)
        {
          mortal.decaffed = true;
        } else
        {
          mortal.decaffed = false;
        }
        return View("Index", Survivor.currentSurvivor);
      }
    }
}
