using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Learning.Views
{
    public class FancyController : Controller
    {
        // GET: Fancy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FancyTown()
        {
            ViewData["Message"] = "A very fancy page";

            return View(); 
        }

        // GET: Fancy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fancy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fancy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fancy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fancy/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fancy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fancy/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}