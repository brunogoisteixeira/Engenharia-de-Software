using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PreCrime;

namespace PreCrime.Controllers
{
    public class TipoCrimeController : Controller
    {
        //private PreCrimeEntities db = new PreCrimeEntities();

        PreCrimeEntities db;

        public TipoCrimeController()
        {
            db = new PreCrimeEntities();
        }








        // Pega os atributos e mostrar na página principal
        public ActionResult Index()
        {
            return View(db.TB_TIPO_CRIME.ToList());
        }

        // Mostra os detalhes pegando pelo id escolhido
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_TIPO_CRIME tB_TIPO_CRIME = db.TB_TIPO_CRIME.Find(id);
            if (tB_TIPO_CRIME == null)
            {
                return HttpNotFound();
            }
            return View(tB_TIPO_CRIME);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCrime/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "COD_TIPO_CRIME,TIPO_CRIME")] TB_TIPO_CRIME tB_TIPO_CRIME)
        {
            if (ModelState.IsValid)
            {
                db.TB_TIPO_CRIME.Add(tB_TIPO_CRIME);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_TIPO_CRIME);
        }

        // Editar o campo passando o id como parametro
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_TIPO_CRIME tB_TIPO_CRIME = db.TB_TIPO_CRIME.Find(id);
            if (tB_TIPO_CRIME == null)
            {
                return HttpNotFound();
            }
            return View(tB_TIPO_CRIME);
        }

        // POST: TipoCrime/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "COD_TIPO_CRIME,TIPO_CRIME")] TB_TIPO_CRIME tB_TIPO_CRIME)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_TIPO_CRIME).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_TIPO_CRIME);
        }

        // Apaga o campo do id passado por parâmetro
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_TIPO_CRIME tB_TIPO_CRIME = db.TB_TIPO_CRIME.Find(id);
            if (tB_TIPO_CRIME == null)
            {
                return HttpNotFound();
            }
            return View(tB_TIPO_CRIME);
        }

        // POST: TipoCrime/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_TIPO_CRIME tB_TIPO_CRIME = db.TB_TIPO_CRIME.Find(id);
            db.TB_TIPO_CRIME.Remove(tB_TIPO_CRIME);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
