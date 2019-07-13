using System.Linq;
using System.Web.Mvc;
using DeltaxIMDB.Models;
using System.Net;
using System.Data;
using DeltaxIMDB.DAL.Repository;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace DeltaxIMDB.Controllers
{
    public class MovieActorController : Controller
    {
        private IMovieActorRepository _MovActRep;

        public MovieActorController()
        {
            _MovActRep = new MovieActorRepository(new MovieActorContext(), new MovieActorModel());
        }
        // GET: MovieActor
        public ActionResult Index()
        {
            var MovieActor = _MovActRep.GetMovieActor().ToList();
            return View(MovieActor);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieActorModel MovieActorModel = _MovActRep.GetMovieActorById(id);
            if (MovieActorModel == null)
            {
                return HttpNotFound();
            }
            return View(MovieActorModel);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _MovActRep.DeleteMovieActor(id);
                _MovActRep.save();
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