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
    public class TDV_SACHController : Controller
    {
        private TranDuyVu_2210900138Entities db = new TranDuyVu_2210900138Entities();

        // GET: TDV_SACH
        public ActionResult TdvIndex()
        {
            var tDV_SACH = db.TDV_SACH.Include(t => t.TDV_TACGIA);
            return View(tDV_SACH.ToList());
        }

        // GET: TDV_SACH/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_SACH tDV_SACH = db.TDV_SACH.Find(id);
            if (tDV_SACH == null)
            {
                return HttpNotFound();
            }
            return View(tDV_SACH);
        }

        // GET: TDV_SACH/Create
        public ActionResult Create()
        {
            ViewBag.Tdv_MaTG = new SelectList(db.TDV_TACGIA, "Tdv_MaTG", "Tdv_TenTG");
            return View();
        }

        // POST: TDV_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tdv_MaSach,Tdv_TenSach,Tdv_SoTrang,Tdv_NamXB,Tdv_MaTG,Tdv_TrangThai")] TDV_SACH tDV_SACH)
        {
            if (ModelState.IsValid)
            {
                db.TDV_SACH.Add(tDV_SACH);
                db.SaveChanges();
                return RedirectToAction("TdvIndex");
            }

            ViewBag.Tdv_MaTG = new SelectList(db.TDV_TACGIA, "Tdv_MaTG", "Tdv_TenTG", tDV_SACH.Tdv_MaTG);
            return View(tDV_SACH);
        }

        // GET: TDV_SACH/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_SACH tDV_SACH = db.TDV_SACH.Find(id);
            if (tDV_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Tdv_MaTG = new SelectList(db.TDV_TACGIA, "Tdv_MaTG", "Tdv_TenTG", tDV_SACH.Tdv_MaTG);
            return View(tDV_SACH);
        }

        // POST: TDV_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tdv_MaSach,Tdv_TenSach,Tdv_SoTrang,Tdv_NamXB,Tdv_MaTG,Tdv_TrangThai")] TDV_SACH tDV_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tDV_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TdvIndex");
            }
            ViewBag.Tdv_MaTG = new SelectList(db.TDV_TACGIA, "Tdv_MaTG", "Tdv_TenTG", tDV_SACH.Tdv_MaTG);
            return View(tDV_SACH);
        }

        // GET: TDV_SACH/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TDV_SACH tDV_SACH = db.TDV_SACH.Find(id);
            if (tDV_SACH == null)
            {
                return HttpNotFound();
            }
            return View(tDV_SACH);
        }

        // POST: TDV_SACH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TDV_SACH tDV_SACH = db.TDV_SACH.Find(id);
            db.TDV_SACH.Remove(tDV_SACH);
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
