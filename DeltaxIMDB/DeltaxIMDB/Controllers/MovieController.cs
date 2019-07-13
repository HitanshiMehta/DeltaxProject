using System.Linq;
using System.Web.Mvc;
using DeltaxIMDB.Models;
using System.Net;
using System.Data;
using DeltaxIMDB.DAL.Repository;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using System;
using System.IO;

namespace DeltaxIMDB.Controllers
{
    public class MovieController : Controller
    {
        //********************Declaration********************
        private IMovieRepository _MovieRep;
        private IProducerRepository _ProRep;
        private IActorRepository _ActRep;
        private IMovieActorRepository _MovActRep;
        //Constructor
        public MovieController()
        {
            _MovieRep = new MovieRepository(new MovieContext());
            _ProRep = new ProducerRepository(new ProducerContext());
            _ActRep = new ActorRepository(new ActorContext());
            _MovActRep = new MovieActorRepository(new MovieActorContext(), new MovieActorModel());
        }

        //********************Implementation********************

        //Display
        public ActionResult Index()
        {

            var AllMovie = _MovieRep.GetMovie();
            return View(AllMovie);
        }

        [HttpGet]
        public ActionResult AddActor()
        {
            var AllActor = new SelectList(_ActRep.GetActor().ToList(), "Actor_Id", "Actor_Name");
            ViewData["AllActor"] = AllActor;
            var AllMovie = new SelectList(_MovieRep.GetMovie().ToList(), "Movie_Id", "Movie_Name");
            ViewData["AllMovie"] = AllMovie;
            return View();
        }

        [HttpPost]
        public ActionResult AddActor(MovieActorModel MovieActorModel)
        {
            var AllActor = new SelectList(_ActRep.GetActor().ToList(), "Actor_Id", "Actor_Name");
            ViewData["AllActor"] = AllActor;
            var AllMovie = new SelectList(_MovieRep.GetMovie().ToList(), "Movie_Id", "Movie_Name");
            ViewData["AllMovie"] = AllMovie;

            try
            {
                if (ModelState.IsValid)
                {
                    _MovActRep.AddMovieActor(MovieActorModel);
                    _MovActRep.save();
                    return Redirect("/MovieActor/Index");
                }
            }
            catch (DataException e)
            {
                ViewBag.FileStatus = e;
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(MovieActorModel);


        }

        //Detail
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //var tupleModel = new Tuple<MovieModel, ActorModel>(_MovieRep.GetMovieById(id), );
            MovieModel MovieModel = _MovieRep.GetMovieById(id);
            if (MovieModel == null)
            {
                return HttpNotFound();
            }
            return View(MovieModel);
        }

        // GET: Create
        public ActionResult Create()
        {
            var AllProducer = new SelectList(_ProRep.GetProducer().ToList(), "Producer_Id", "Producer_Name");
            ViewData["AllProducer"] = AllProducer;
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Movie_Id,Movie_Name,Movie_Release_Year,Movie_Plot,Movie_Poster,Movie_Rating,Producer_Id,Movie_Photo_Data")] MovieModel MovieModel)
        {
            var AllProducer = new SelectList(_ProRep.GetProducer().ToList(), "Producer_Id", "Producer_Name");
            ViewData["AllProducer"] = AllProducer;
            try
            {
                if (ModelState.IsValid)
                {
                    if (MovieModel.Movie_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(MovieModel);
                    }
                    else
                    {
                        MovieModel.Movie_Poster = MovieModel.Movie_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(MovieModel.Movie_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            MovieModel.Movie_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _MovieRep.AddMovie(MovieModel);
                    _MovieRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }

            return View(MovieModel);
        }


        // GET: Edit
        public ActionResult Edit(int? id)
        {
            var AllProducer = new SelectList(_ProRep.GetProducer().ToList(), "Producer_Id", "Producer_Name");
            ViewData["AllProducer"] = AllProducer;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieModel Movie = _MovieRep.GetMovieById(id);
            if (Movie == null)
            {
                return HttpNotFound();
            }
            return View(Movie);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Movie_Id,Movie_Name,Movie_Release_Year,Movie_Plot,Movie_Poster,Movie_Rating,Producer_Id,Movie_Photo_Data")] MovieModel MovieModel)
        {
            var AllProducer = new SelectList(_ProRep.GetProducer().ToList(), "Producer_Id", "Producer_Name");
            ViewData["AllProducer"] = AllProducer;
            try
            {
                if (ModelState.IsValid)
                {
                    if (MovieModel.Movie_Photo_Data == null)
                    {
                        ViewBag.FileStatus = "Please select image.";
                        return View(MovieModel);
                    }
                    else
                    {
                        MovieModel.Movie_Poster = MovieModel.Movie_Photo_Data.FileName;
                        String path = Server.MapPath("Image");
                        String filename = Path.GetFileName(MovieModel.Movie_Photo_Data.FileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        else
                        {
                            String fullpath = Path.Combine(path, filename);
                            MovieModel.Movie_Photo_Data.SaveAs(fullpath);
                        }

                    }
                    _MovieRep.UpdateMovie(MovieModel);
                    _MovieRep.save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(MovieModel);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieModel MovieModel = _MovieRep.GetMovieById(id);
            if (MovieModel == null)
            {
                return HttpNotFound();
            }
            return View(MovieModel);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _MovieRep.DeleteMovie(id);
                _MovieRep.save();
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