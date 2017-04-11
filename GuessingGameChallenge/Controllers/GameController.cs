using GuessingGameChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGameChallenge.Controllers
{
    public class GameController : Controller
    {

        private bool GuessWasCorrect(int guess) => guess == (int)Session["Answer"];
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(1, 10);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }
            return View(model);
        }
    }
}