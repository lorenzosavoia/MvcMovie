using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> lsMovies = new List<Movie>();

        public void PrendiDati()
        {
            Movie PrimoMovie = new Movie()
            {
                Id = 1,
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M,
                Photo = "/img/foto.jpg",
                AlternateText = "Pranaya Rout Photo not available"
            };
            lsMovies.Add(PrimoMovie);

            Movie SecondoMovie = new Movie()
            {
                Id = 2,
                Title = "Harry Potter e la pietra filosofale",
                ReleaseDate = DateTime.Parse("2001-2-12"),
                Genre = "Fantascienza",
                Price = 3M,
                Photo = "/img/foto.jpg",
                AlternateText = "Photo not available"
            };
            lsMovies.Add(SecondoMovie);

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowMovie()
        {
            PrendiDati();
            return View(lsMovies);
        }
    }
}
