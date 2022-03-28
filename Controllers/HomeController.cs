using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BowlingLeague.Models;


namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        //HOME PAGE
        public IActionResult Index()
        {
            return View();
        }

        //VIEW BOWLERS
        [HttpGet]
        public IActionResult ViewBowlers()
        {
            //List<Team> teams = _repo.Teams.ToList();

            var bowlers = _repo.Bowlers
                //.FromSqlRaw("Select * from recipes where recipetitle like 'a%'")
                .OrderBy(x => x.BowlerFirstName)
                .ToList();

            return View(bowlers);
        }

        //VIEW TEAMS
        [HttpGet]
        public IActionResult Teams()
        {
            //List<Team> teams = _repo.Teams.ToList();

            var teams = _repo.Bowlers
                //.FromSqlRaw("Select * from recipes where recipetitle like 'a%'")
                .OrderBy(x => x.BowlerFirstName)
                .ToList();

            return View(teams);
        }

        //ADD BOWLER
        [HttpGet]
        public IActionResult AddBowler()
        {
            ViewBag.Bowlers = _repo.Bowlers.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddBowler(Bowler b)
        {
            _repo.AddBowler(b);

            return View("Index");

            //if (ModelState.IsValid)
            //{
            //    _repo.AddBowler(b);

            //    return View("ViewBowlers");
            //}
            //else
            //{
            //    ViewBag.Bowlers = _repo.Bowlers.ToList();
            //    return View();
            //}
        }

        //EDIT BOWLER
        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            ViewBag.Bowlers = _repo.Bowlers.ToList();

            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View("AddBowler", bowler);
        }


        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            _repo.SaveBowler(b);

            return RedirectToAction("ViewBowlers");
        }

        //DELETE BOWLER
        [HttpGet]
        public IActionResult Delete(int bowlerid)
        {
            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View(bowler);
        }

        [HttpPost]
        public IActionResult Delete(Bowler b)
        {
            Bowler bowler = _repo.Bowlers.Single(x => x.BowlerID == b.BowlerID);

            _repo.DeleteBowler(bowler);

            return View("Index");
        }
    }
}