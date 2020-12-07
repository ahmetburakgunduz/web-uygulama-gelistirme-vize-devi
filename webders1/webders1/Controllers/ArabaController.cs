using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webders1.Controllers
{
    public class ArabaController : Controller
    {
        // GET: Araba
        public ActionResult Listele()
        {
            return View(Models.ArabaVeri.VeriListe);
        }

        public ActionResult Yeni()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var araba = Models.ArabaVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View(araba);
            var araba2 = Models.ArabaVeri.VeriListe.Where(x => x.Id == 2).FirstOrDefault();
            return View(araba);
            var araba3 = Models.ArabaVeri.VeriListe.Where(x => x.Id == 3).FirstOrDefault();
            return View(araba);
        }

        public ActionResult Delete(int Id)
        {
            var araba = Models.ArabaVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View(araba);
        }

        [HttpPost]
        public ActionResult Delete(Models.ArabaVeri arabaVeri)
        {
            var araba = Models.ArabaVeri.VeriListe.Where(x => x.Id == arabaVeri.Id).FirstOrDefault();

            Models.ArabaVeri.VeriListe.Remove(araba);

            return RedirectToAction("Listele");
        }

        [HttpPost]
        public ActionResult Edit(Models.ArabaVeri arabaVeri)
        {
            var araba = Models.ArabaVeri.VeriListe.Where(x => x.Id == arabaVeri.Id).FirstOrDefault();
            araba.Marka = arabaVeri.Marka;
            araba.Model = arabaVeri.Model;
            araba.Yil = arabaVeri.Yil;
            araba.MotorGucu = arabaVeri.MotorGucu;

            return RedirectToAction("Listele");
        }

        [HttpPost]
        public ActionResult Yeni(Models.ArabaVeri ArabaVeri)
        {
            Models.ArabaVeri.VeriListe.Add(ArabaVeri);
            return RedirectToAction("Listele");
        }
    }
}