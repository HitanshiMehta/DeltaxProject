using System.Linq;
using System.Web.Mvc;
using DeltaxIMDB.Models;
using System.Net;
using System.Data;
using DeltaxIMDB.DAL.Repository;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using System.IO;
using System;

namespace DeltaxIMDB.Controllers
{
    public class ActorController : Controller
    {
        //********************Declaration********************
        private IActorRepository _ActorRep;
        //Constructor
        public ActorController()
        {
            this._ActorRep = new ActorRepository(new ActorContext());
        }

        //********************Implementation********************

        //Display
        public ActionResult Index()
        {

            var AllActor = from Actor in _ActorRep.GetActor()
                           select Actor;
            return View(AllActor);
        }

        //Detail
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel ActorModel = _ActorRep.GetActorById(id);
            if (ActorModel == null)
            {
                return HttpNotFound();
            }
            return View(ActorModel);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Actor_Id,Actor_Name,Actor_Photo,Actor_Sex,Actor_DOB,Actor_Bio,Actor_Height,Actor_Birth_Name,Actor_Birth_State,,Actor_Photo_Data")] ActorModel ActorModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ActorModel.Actor_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(ActorModel);
                    }
                    else
                    {
                        ActorModel.Actor_Photo = ActorModel.Actor_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(ActorModel.Actor_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            ActorModel.Actor_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _ActorRep.AddActor(ActorModel);
                    _ActorRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(ActorModel);
        }


        // GET: Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel Actor = _ActorRep.GetActorById(id);
            if (Actor == null)
            {
                return HttpNotFound();
            }
            return View(Actor);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Actor_Id,Actor_Name,Actor_Photo,Actor_Sex,Actor_DOB,Actor_Bio,Actor_Height,Actor_Birth_Name,Actor_Birth_State,Actor_Photo_Data")] ActorModel ActorModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ActorModel.Actor_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(ActorModel);
                    }
                    else
                    {
                        ActorModel.Actor_Photo = ActorModel.Actor_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(ActorModel.Actor_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            ActorModel.Actor_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _ActorRep.UpdateActor(ActorModel);
                    _ActorRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(ActorModel);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActorModel ActorModel = _ActorRep.GetActorById(id);
            if (ActorModel == null)
            {
                return HttpNotFound();
            }
            return View(ActorModel);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _ActorRep.DeleteActor(id);
                _ActorRep.save();
                return RedirectToAction("Index");
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
                { "id", id
            },
                { "saveChangesError", true } });
            }
        }
    }
}