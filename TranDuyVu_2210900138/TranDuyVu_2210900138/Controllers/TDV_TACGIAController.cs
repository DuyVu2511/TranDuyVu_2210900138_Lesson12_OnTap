using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TranDuyVu_2210900138.Models;

namespace TranDuyVu_2210900138.Controllers
{
    public class TDV_TACGIAController : Controller
    {
        private TranDuyVu_2210900138Entities db = new TranDuyVu_2210900138Entities();

        // GET: TDV_TACGIA
        public ActionResult TdvIndex()
        {
            return View(db.TDV_TACGIA.ToList());
        }

        // GET: TDV_TACGIA/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_TACGIA tDV_TACGIA = db.TDV_TACGIA.Find(id);
            if (tDV_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tDV_TACGIA);
        }

        // GET: TDV_TACGIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TDV_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tdv_MaTG,Tdv_TenTG")] TDV_TACGIA tDV_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.TDV_TACGIA.Add(tDV_TACGIA);
                db.SaveChanges();
                return RedirectToAction("TdvIndex");
            }

            return View(tDV_TACGIA);
        }

        // GET: TDV_TACGIA/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_TACGIA tDV_TACGIA = db.TDV_TACGIA.Find(id);
            if (tDV_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tDV_TACGIA);
        }

        // POST: TDV_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tdv_MaTG,Tdv_TenTG")] TDV_TACGIA tDV_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDV_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TdvIndex");
            }
            return View(tDV_TACGIA);
        }

        // GET: TDV_TACGIA/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_TACGIA tDV_TACGIA = db.TDV_TACGIA.Find(id);
            if (tDV_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(tDV_TACGIA);
        }

        // POST: TDV_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TDV_TACGIA tDV_TACGIA = db.TDV_TACGIA.Find(id);
            db.TDV_TACGIA.Remove(tDV_TACGIA);
            db.SaveChanges();
            return RedirectToAction("TdvIndex");
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
