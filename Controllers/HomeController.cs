using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BowlingLeague.Models;
using Microsoft.EntityFrameworkCore;


namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }

        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        //VIEW BOWLERS
        public IActionResult Index()
        {
            ViewBag.Teams = _repo.Teams.ToList();

            ViewBag.AllTeams = "";

            var bowlers = _repo.Bowlers
                .ToList();

            return View(bowlers);
        }

        //VIEW TEAMS
        [HttpGet]
        public IActionResult Teams(int teamid)
        {
            ViewBag.Teams = _repo.Teams.ToList();

            var teams = _repo.Bowlers
                .Where(x => x.TeamID == teamid)
                .ToList();


            ViewBag.AllTeams = _repo.Teams
                .Where(x => x.TeamID == teamid)
                .ToList();
                

            return View("Index", teams);
        }

        //ADD BOWLER
        [HttpGet]
        public IActionResult AddBowler()
        {
            ViewBag.Teams = _repo.Teams
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddBowler(Bowler b)
        {
            if (ModelState.IsValid)
            {
                _repo.AddBowler(b);

                return RedirectToAction("Index", b);
            }
            else
            {
                ViewBag.Teams = _repo.Teams.ToList();
                return View();
            }
        }

        //EDIT BOWLER
        [HttpGet]
        public IActionResult Edit(int bowlerid)
        {
            ViewBag.Teams = _repo.Teams
                .ToList();

            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bowlerid);

            return View("AddBowler", bowler);
        }


        [HttpPost]
        public IActionResult Edit(Bowler b)
        {
            _repo.SaveBowler(b);

            return RedirectToAction("Index");
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

            return RedirectToAction("Index");
        }
    }
}