﻿using Model.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Oh_lala_Web.Controllers
{
    [Authorize]
    public class TypeEventsController : Controller
    {
        private ohlalaEntities db = new ohlalaEntities();

        // GET: TypeEvents
        public ActionResult Index()
        {
            return View("~/Views/Loader/TypeEvents/Index.cshtml", db.TypeEvent.ToList());
        }

        // GET: TypeEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeEvent typeEvent = db.TypeEvent.Find(id);
            if (typeEvent == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/TypeEvents/Details.cshtml", typeEvent);
        }

        // GET: TypeEvents/Create
        public ActionResult Create()
        {
            return View("~/Views/Loader/TypeEvents/Create.cshtml");
        }

        // POST: TypeEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")] TypeEventView typeEventView)
        {
            if (ModelState.IsValid)
            {
                AutoMapper.Mapper.Initialize(x => {
                    x.CreateMap<TypeEventView, TypeEvent>();
                });
                db.TypeEvent.Add(AutoMapper.Mapper.Map<TypeEvent>(typeEventView));
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("~/Views/Loader/TypeEvents/Create.cshtml", typeEventView);
        }

        // GET: TypeEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeEvent typeEvent = db.TypeEvent.Find(id);
            if (typeEvent == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/TypeEvents/Edit.cshtml", typeEvent);
        }

        // POST: TypeEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] TypeEvent typeEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeEvent).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Loader/TypeEvents/Edit.cshtml", typeEvent);
        }

        // GET: TypeEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeEvent typeEvent = db.TypeEvent.Find(id);
            if (typeEvent == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/TypeEvents/Delete.cshtml", typeEvent);
        }

        // POST: TypeEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeEvent typeEvent = db.TypeEvent.Find(id);
            db.TypeEvent.Remove(typeEvent);
            db.SaveChanges();
            return RedirectToAction("~/Views/Loader/TypeEvents/Index.cshtml");
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
