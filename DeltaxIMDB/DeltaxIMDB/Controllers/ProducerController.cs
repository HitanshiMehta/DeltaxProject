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
using System.Web;

namespace DeltaxIMDB.Controllers
{
    public class ProducerController : Controller
    {
        //********************Declaration********************
        private IProducerRepository _ProducerRep;
        //Constructor
        public ProducerController()
        {
            this._ProducerRep = new ProducerRepository(new ProducerContext());
        }

        //********************Implementation********************

        //Display
        public ActionResult Index()
        {
            ViewBag.FileStatus = "hello";
            var AllProducer = _ProducerRep.GetProducer();
            return View(AllProducer);
        }

        //Detail
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProducerModel ProducerModel = _ProducerRep.GetProducerById(id);
            if (ProducerModel == null)
            {
                return HttpNotFound();
            }
            return View(ProducerModel);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Producer_Id,Producer_Name,Producer_Photo,Producer_Sex,Producer_DOB,Producer_Bio,Producer_Photo_Data")] ProducerModel ProducerModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (ProducerModel.Producer_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(ProducerModel);
                    }
                    else
                    {
                        ProducerModel.Producer_Photo = ProducerModel.Producer_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(ProducerModel.Producer_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            ProducerModel.Producer_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _ProducerRep.AddProducer(ProducerModel);

                    _ProducerRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException e)
            {
                ViewBag.FileStatus = e;
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(ProducerModel);
        }


        // GET: Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProducerModel Producer = _ProducerRep.GetProducerById(id);
            if (Producer == null)
            {
                return HttpNotFound();
            }
            return View(Producer);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Producer_Id,Producer_Name,Producer_Photo,Producer_Sex,Producer_DOB,Producer_Bio,Producer_Photo_Data")] ProducerModel ProducerModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (ProducerModel.Producer_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(ProducerModel);
                    }
                    else
                    {
                        ProducerModel.Producer_Photo = ProducerModel.Producer_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(ProducerModel.Producer_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            ProducerModel.Producer_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _ProducerRep.UpdateProducer(ProducerModel);
                    _ProducerRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(ProducerModel);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProducerModel ProducerModel = _ProducerRep.GetProducerById(id);
            if (ProducerModel == null)
            {
                return HttpNotFound();
            }
            return View(ProducerModel);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _ProducerRep.DeleteProducer(id);
                _ProducerRep.save();
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