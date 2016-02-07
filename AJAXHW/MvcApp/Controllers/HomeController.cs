namespace MvcApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;

    using MvcApp.Data.Models;
    using MvcApp.Models;
    using MvcApp.Services.Contracts;

    using Newtonsoft.Json;

    using Ninject;

    using WebGrease.Css.Extensions;

    public class HomeController : Controller
    {
        [Inject]
        public IMoviesService Movies { get; set; }

        [Inject]
        public IMaleActorsService MaleActors { get; set; }

        [Inject]
        public IFemaleActorsService FemaleActors { get; set; }

        [Inject]
        public IStudiosService Studios { get; set; }

        [Inject]
        public IDirectorsService Directors { get; set; }

        public ActionResult Index()
        {
            this.PopulateDropDowns();

            return this.View();
        }

        public ActionResult MoviesRead([DataSourceRequest] DataSourceRequest request)
        {

            return this.Json(this.Movies.GetAll().Select(
                    x =>
                    new MovieViewModel
                    {
                        Id = x.MovieId,
                        Title = x.Title,
                        Year = x.Year,
                        Studio = new StudioViewModel
                                     {
                                         Name = x.Studio.Name,
                                         Id = x.StudioId
                                     },
                        MaleActor = new MaleActorViewModel
                        {
                            Name = x.MaleActor.FirstName + " " + x.MaleActor.LastName,
                            Id = x.MaleActorId
                        },
                        FemaleActor = new FemaleActorViewModel
                        {
                            Name = x.FemaleActor.FirstName + " " + x.FemaleActor.LastName,
                            Id = x.FemaleActorId
                        },
                        Director = new DirectorViewModel
                        {
                            Name = x.Director.FirstName + " " + x.Director.LastName,
                            Id = x.DirectorId
                        }
                    }).ToDataSourceResult(request));
        }

        [HttpPost]
        public ActionResult MoviesCreate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<MovieViewModel> movies)
        {
            var results = new List<MovieViewModel>();

            if (movies != null && this.ModelState.IsValid)
            {
                foreach (var movie in movies)
                {
                    var newMovie = new Movie
                    {
                        Title = movie.Title,
                        DirectorId = movie.Director.Id,
                        FemaleActorId = movie.FemaleActor.Id,
                        MaleActorId = movie.MaleActor.Id,
                        Year = movie.Year,
                        StudioId = movie.Studio.Id
                    };
                    this.Movies.CreateMovie(newMovie);

                    results.Add(movie);
                }

                this.Movies.SaveChanges();
            }

            return this.Json(results.ToDataSourceResult(request, this.ModelState));
        }

        [HttpPost]
        public ActionResult MoviesUpdate([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<MovieViewModel> movies)
        {
            var movieViewModels = movies as IList<MovieViewModel> ?? movies.ToList();
            if (movies != null && this.ModelState.IsValid)
            {
                foreach (var movie in movieViewModels)
                {
                    var updatedMovie = new Movie
                    {
                        MovieId = movie.Id,
                        Title = movie.Title,
                        DirectorId = movie.Director.Id,
                        FemaleActorId = movie.FemaleActor.Id,
                        MaleActorId = movie.MaleActor.Id,
                        Year = movie.Year,
                        StudioId = movie.Studio.Id
                    };

                    this.Movies.UpdateMovie(updatedMovie);
                }

                this.Movies.SaveChanges();
            }

            return this.Json(movieViewModels.ToDataSourceResult(request, this.ModelState));
        }

        [HttpPost]
        public ActionResult MoviesDestroy([DataSourceRequest] DataSourceRequest request,
            [Bind(Prefix = "models")]IEnumerable<MovieViewModel> movies)
        {
            var movieViewModels = movies as MovieViewModel[] ?? movies.ToArray();
            foreach (var movie in movieViewModels)
            {
                this.Movies.DeleteMovie(movie.Id);
            }

            this.Movies.SaveChanges();

            return this.Json(movieViewModels.ToDataSourceResult(request, this.ModelState));
        }

        private void PopulateDropDowns()
        {

            var maleActors =
               this.MaleActors.GetAll()
                   .Select(a => new MaleActorViewModel { Name = a.FirstName + " " + a.LastName, Id = a.MaleActorId }).OrderBy(x => x.Name);

            var femaleActors =
               this.FemaleActors.GetAll()
                   .Select(a => new FemaleActorViewModel { Name = a.FirstName + " " + a.LastName, Id = a.FemaleActorId }).OrderBy(x => x.Name);

            var studios =
                this.Studios.GetAll()
                    .Select(s => new StudioViewModel { Name = s.Name, Id = s.StudioId }).OrderBy(x => x.Name);

            var directors =
                this.Directors.GetAll()
                    .Select(d => new DirectorViewModel { Name = d.FirstName + " " + d.LastName, Id = d.DirectorId }).OrderBy(x => x.Name);

            this.ViewData["maleActors"] = maleActors;
            this.ViewData["defaultMaleActor"] = maleActors.First();
            this.ViewData["femaleActors"] = femaleActors;
            this.ViewData["defaultFemaleActor"] = femaleActors.First();
            this.ViewData["studios"] = studios;
            this.ViewData["defaultStudio"] = studios.First();
            this.ViewData["directors"] = directors;
            this.ViewData["defaultDirector"] = directors.First();
        }
    }
}