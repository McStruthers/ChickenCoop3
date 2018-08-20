using ChickenCoop3.Models;
using ChickenCoop3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ChickenCoop3.Controllers
{
    public class ChickensController : Controller
    {
        private ApplicationDbContext _context;

        public ChickensController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Chickens
        public ActionResult Index()
        {
            //var viewModel = new ChickensViewModel
            //{
            //    Chickens = chickenList
            //};
            var chickens = _context.Chickens.ToList();
            return View(chickens);
        }

        // GET: Chicken with ID
        public ActionResult Individual(int id)
        {
            var chicken = _context.Chickens.Include(c => c.ChickenBreed).SingleOrDefault(c => c.Id == id);
            if (chicken == null)
            {
                return HttpNotFound();
            }
            return View(chicken);
            //foreach (Chicken chicken in _context.Chickens.ToList())
            //{
            //    if (chicken.Id == id)
            //    {
            //        return View(chicken);
            //    }
            //}
            //return View();
        }

        public ActionResult New()
        {
            var chickenbreeds = _context.ChickenBreeds.ToList();
            var viewModel = new NewChickenViewModel
            {
                ChickenBreeds = chickenbreeds
            };
            return View(viewModel);
        }


        [HttpPost]
        public ActionResult Create(Chicken chicken)
        {
            _context.Chickens.Add(chicken); //puts in temp memory. must save changes to update db
            _context.SaveChanges();
            return RedirectToAction("Index", "Chickens");
        }
    }
}