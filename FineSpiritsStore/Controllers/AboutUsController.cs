using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineSpiritsStore.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AboutUsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AboutUsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutUsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AboutUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutUsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AboutUsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
