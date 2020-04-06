using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vjezba02.Models;

namespace Vjezba02.Controllers
{
    public class StudentController : Controller
    {
        BazaDbContext bazaPodataka = new BazaDbContext();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Početna o studentima";
            ViewBag.Fakultet = "Međimursko veleučilište";
            return View();
        }

        public ActionResult Popis()
        {
            var studenti = bazaPodataka.PopisStudenata.ToList();
 
            return View(studenti);
        }

        
        public ActionResult Detalji(int? id)
        {
           
            if (!id.HasValue)
            {
                
                return RedirectToAction("Popis");              
            }


            Student student = bazaPodataka.PopisStudenata.FirstOrDefault(x => x.Id == id);

            
            if (student == null)
            {
                
                return RedirectToAction("Popis");
            }

           
            return View(student);
        }

              
        public ActionResult Azuriraj(int? id)
        {
           
            if (!id.HasValue)
            {
                 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
               
            }

            
            Student student = bazaPodataka.PopisStudenata.FirstOrDefault(x => x.Id == id);

            
            if (student == null)
            {
                
                return HttpNotFound();              
            }

            
            return View(student);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Azuriraj(Student s)
        {
            if (GodisteController.ProvjeriGodiste(s.DatumRodjenja) == false)
            {
                ModelState.AddModelError("DatumRodjenja", "Osoba mora biti starija od 18");
            }
            if (!OIB.ProvjeriOIB(s.Oib))
            {
                ModelState.AddModelError("Oib", "Neispravan OIB");
            }

            if (ModelState.IsValid)
            {

                bazaPodataka.Entry(s).State = System.Data.Entity.EntityState.Modified;
                bazaPodataka.SaveChanges();
               
                return RedirectToAction("Popis");
            }
                   
            return View(s);
        }
    }
}