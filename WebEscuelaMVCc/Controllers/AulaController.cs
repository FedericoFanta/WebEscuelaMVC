using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVCc.Data;
using WebEscuelaMVCc.Models;

namespace WebEscuelaMVCc.Controllers
{
    public class AulaController : Controller
    {
        private AulaDbContext context = new AulaDbContext();
        // GET: Aula
        public ActionResult Index()
        {
            List<Aula> lista = context.Aulas.ToList();
            return View("Index", lista);
        }

        //GET: Opera/Created
        public ActionResult Register()
        {
           Aula aula = new Aula();

            return View("Register");
        }

        //POST: /Opera/Create
        [HttpPost]
        public ActionResult Register(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();

                return RedirectToAction("Index");

            }
            else
            {
                return View(aula);
            }
        }


        public ActionResult Details(int id)
        {
            Aula aula = context.Aulas.Find(id);

            if (aula== null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Details",aula);
            }
        }

        // GET: /Opera/Delete/id
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Aula aula = context.Aulas.Find(id);

            if (aula==null)
            {
                return HttpNotFound();

            }

            return View("Delete", aula);
        }


        // POST: /Opera/Delete
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
           Aula aula = context.Aulas.Find(id);
            if (aula != null)
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}