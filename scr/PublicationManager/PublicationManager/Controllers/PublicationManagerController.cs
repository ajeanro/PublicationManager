using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jr.PublicationLibrary;

namespace PublicationManager.Controllers
{
    public class PublicationManagerController : Controller
    {
        private publicationRepo _publicationRepo = new publicationRepo();
        
        // GET: PublicationManager
        public ActionResult Index()
        {
            return View(_publicationRepo.ListAll());
        }

        // GET: PublicationManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_publicationRepo.GetById(id));
        }

        // GET: PublicationManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicationManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Publication newPublication, IFormCollection collection)
        {
            try
            {
                _publicationRepo.Add(newPublication);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicationManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_publicationRepo.GetById(id));
        }

        // POST: PublicationManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Publication editPublication, IFormCollection collection)
        {
            try
            {
                _publicationRepo.Edit(editPublication);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicationManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_publicationRepo.GetById(id));
        }

        // POST: PublicationManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _publicationRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}