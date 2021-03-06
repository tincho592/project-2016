﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.Models;

namespace Model.Controllers
{
    [Authorize]
    public class ImagesController : Controller
    {
        private ohlalaEntities db = new ohlalaEntities();

        // GET: Images
        public ActionResult Index()
        {
            return View("~/Views/Loader/Images/Index.cshtml", db.Image.ToList());
        }

        // GET: Images/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/Images/Details.cshtml", image);
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            return View("~/Views/Loader/Images/Create.cshtml");
        }

        // POST: Images/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,ImagePath")] ImageView imageView)
        {
            if (ModelState.IsValid)
            {
                AutoMapper.Mapper.Initialize(x => {
                    x.CreateMap<ImageView, Image>();
                });
                db.Image.Add(AutoMapper.Mapper.Map<Image>(imageView));
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("~/Views/Loader/Images/Create.cshtml", imageView);
        }

        // GET: Images/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/Images/Edit.cshtml", image);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,ImagePath")] Image image)
        {
            if (ModelState.IsValid)
            {
                db.Entry(image).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Loader/Images/Edit.cshtml", image);
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Image image = db.Image.Find(id);
            if (image == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Loader/Images/Delete.cshtml", image);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Image image = db.Image.Find(id);
            db.Image.Remove(image);
            db.SaveChanges();
            return RedirectToAction("~/Views/Loader/Images/Index.cshtml");
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
