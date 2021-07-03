using CollegeProject.Models;
using CollegeProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CollegeProject.Controllers
{
    public class HomeController : Controller
    {

        EnrollmentEntities entities = new EnrollmentEntities();
        // GET: Home

        List<Slider> sliderList = new List<Slider>()
            {
                new Slider
                {
                    SlideImage = "../Content/images/slide-2.jpg"
                },
                new Slider
                {
                    SlideImage = "../Content/images/slide-3.jpg"
                },
                new Slider
                {
                    SlideImage = "../Content/images/slide-4.jpg"
                },
                new Slider
                {
                    SlideImage = "../Content/images/slide-5.jpg"
                },
                new Slider
                {
                    SlideImage = "../Content/images/slide-6.jpg"
                }

            };

        List<Movie> movieList = new List<Movie>()
            {
                new Movie{
                    Id=1,
                    Title = "Future Hell",
                    Release = 2020,
                    Genre = "Romance",
                    Image  = "../Content/images/card-1.jpg"

                },
                new Movie
                {
                    Id=2,
                    Title = "Toto Family",
                    Release = 2020,
                    Genre = "Drama",
                    Image  = "../Content/images/card-2.jpg"
                },
                new Movie
                {
                    Id=3,
                    Title = "Inside Women",
                    Release = 2018,
                    Genre = "Action",
                    Image  = "../Content/images/card-3.jpg"
                },
                new Movie
                {
                    Id=4,
                    Title = "Spaceman",
                    Release = 2020,
                    Genre = "Thriller",
                    Image  = "../Content/images/card-4.jpg"
                },
                new Movie
                {
                    Id=5,
                    Title = "Voices",
                    Release = 2019,
                    Genre = "Sci Fi",
                    Image  = "../Content/images/card-5.jpg"
                },
                new Movie
                {
                    Id=6,
                    Title = "Colors of Pain",
                    Release = 2020,
                    Genre = "Romance",
                    Image  = "../Content/images/card-6.jpg"
                },
                new Movie
                {
                    Id=7,
                    Title = "Green Magic World",
                    Release = 2019,
                    Genre = "Horror",
                    Image  = "../Content/images/card-7.jpg"
                },
                new Movie
                {
                    Id=8,
                    Title = "Soviet : The Cold War",
                    Release = 2019,
                    Genre = "War",
                    Image  = "../Content/images/card-8.jpg"
                },
                new Movie{
                    Id=9,
                    Title = "Finding Love of Life",
                    Release = 2020,
                    Genre = "Crime",
                    Image  = "../Content/images/card-9.jpg"
                },
                new Movie{
                    Id=10,
                    Title = "Meet the Brothers",
                    Release = 2021,
                    Genre = "Comedy",
                    Image  = "../Content/images/card-10.jpg"
                },
                new Movie{
                    Id=11,
                    Title = "Freedom Fighters",
                    Release = 2020,
                    Genre = "Action",
                    Image  = "../Content/images/card-11.jpg"
                },
                new Movie{
                    Id=12,
                    Title = "Patriot on Redline",
                    Release = 2020,
                    Genre = "Adventure",
                    Image  = "../Content/images/card-12.jpg"
                }
            };

        List<TVShows> tVShowsList = new List<TVShows>()
            {
                new TVShows
                {
                    Title = "Women's Day",
                    Episodes = "7 Episodes - 2021",
                    Image = "../Content/images/feature-1.jpg"
                },
                new TVShows
                {
                    Title = "The Perfect Match",
                    Episodes = "12 Episodes - 2020",
                    Image = "../Content/images/feature-2.jpg"
                },
                new TVShows
                {
                    Title = "The Dog Woof",
                    Episodes = "20 Episodes - 2021",
                    Image = "../Content/images/feature-3.jpg"
                },
                new TVShows
                {
                    Title = "The Easy Reach",
                    Episodes = "5 Episodes - 2015",
                    Image = "../Content/images/feature-4.jpg"
                },
                new TVShows
                {
                    Title = "The Cooking",
                    Episodes = "25 Episodes - 2019",
                    Image = "../Content/images/feature-5.jpg"
                },
                new TVShows
                {
                    Title = "The Hikaru",
                    Episodes = "10 Episodes - 2021",
                    Image = "../Content/images/feature-6.jpg"
                },
                new TVShows
                {
                    Title = "Life Quotes",
                    Episodes = "18 Episodes - 2018",
                    Image = "../Content/images/feature-7.jpg"
                },
                new TVShows
                {
                    Title = "The Beachball",
                    Episodes = "8 Episodes - 2016",
                    Image = "../Content/images/feature-8.jpg"
                },

            };

        List<AudioBooks> audioBookList = new List<AudioBooks>()
            {
                new AudioBooks
                {
                    Title = "To Kill a Fae",
                    Release = 2021,
                    Image = "../Content/images/audiobook-1.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/to-kill-a-fae/"
                },
                new AudioBooks
                {
                    Title = "Wild Sign",
                    Release = 2021,
                    Image = "../Content/images/audiobook-2.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/wild-sign/"
                },
                new AudioBooks
                {
                    Title = "Just As I Am",
                    Release = 2021,
                    Image = "../Content/images/audiobook-3.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/just-as-i-am-a-memoir/"
                },
                new AudioBooks
                {
                    Title = "The Practice",
                    Release = 2021,
                    Image = "../Content/images/audiobook-4.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/the-practice/"
                },
                new AudioBooks
                {
                    Title = "Cleaning Up",
                    Release = 2021,
                    Image = "../Content/images/audiobook-5.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/cleaning-up-your-mental-mess/"
                },
                new AudioBooks
                {
                    Title = "Becoming",
                    Release = 2021,
                    Image = "../Content/images/audiobook-6.jpeg",
                    Link = "http://digiflex.themezinho.net/audiobook/becoming/"
                }

            };

        List<Blogs> blogsList = new List<Blogs>()
        {
            new Blogs
            {
                Title = "Exclusive: Santa Claus shares his list of must-watch ho-ho-holiday",
                Release = "December 1, 2021",
                Image = "../Content/images/blog-1.jpg",
                Link = "http://digiflex.themezinho.net/exclusive-santa-claus-shares-his-list-of-must-watch-ho-ho-holiday/"
            },
            new Blogs
            {
                Title = "Digiflex’s spy thriller ‘Munich’ starring Ceremy Arons starts production",
                Release = "December 1, 2021",
                Image = "../Content/images/blog-2.jpg",
                Link= "http://digiflex.themezinho.net/digiflexs-spy-thriller-munich-starring-ceremy-arons-starts-production/"
            },
            new Blogs
            {
                Title = "Supernatural Horror Series Archive 81 Starring Emmy Award Nominee",
                Release = "December 1, 2021",
                Image = "../Content/images/blog-3.jpg",
                Link = "http://digiflex.themezinho.net/supernatural-horror-series-archive-81-starring-emmy-award-nominee/"
            },
            new Blogs
            {
                Title = "The world’s leading streaming entertainment service, released axe",
                Release = "December 1, 2021",
                Image = "../Content/images/blog-4.jpg",
                Link = "http://digiflex.themezinho.net/the-worlds-leading-streaming-entertainment-service-released-axe/"
            },
            new Blogs
            {
                Title = "Every episode is a standalone story, but all are interconnected",
                Release = "December 1, 2021",
                Image = "../Content/images/blog-5.jpg",
                Link = "http://digiflex.themezinho.net/every-episode-is-a-standalone-story-but-all-are-interconnected/"
            }
        };

        public ActionResult Index()
        {
            IndexModel indexModel = new IndexModel();

            indexModel.MySlides = sliderList;
            indexModel.MyMovies = movieList;
            indexModel.MyTvShows = tVShowsList;
            indexModel.MyAudioBooks = audioBookList;

            return View(indexModel);
        }

        public ActionResult Guest()
        {
            IndexModel indexModel = new IndexModel();

            indexModel.MySlides = sliderList;
            indexModel.MyMovies = movieList;
            indexModel.MyTvShows = tVShowsList;
            indexModel.MyAudioBooks = audioBookList;

            return View(indexModel);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(User user)
        {
            var data = entities.Users.ToList();

            foreach (var item in data)
            {
                if (user.Email == item.Email && user.Password == item.Password)
                {
                    return Json(1);
                }
            }
            return Json(0);
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {

                User current = new User
                {
                    Id = Guid.NewGuid(),
                    Email = user.Email,
                    Password = user.Password
                };

                entities.Users.Add(current);
                entities.SaveChanges();

                return Json(1);
            }

            return Json(0);

        }

        [HttpPost]
        public JsonResult AddToFav(Favourite e)
        {
            var data = entities.Favourites.Find(e.Id);

            if (data == null)
            {
                entities.Favourites.Add(e);
                entities.SaveChanges();

                return Json(1);
            }

            return Json(2);
        }

        public ActionResult Favourites()
        {
            var items = entities.Favourites.ToList();

            return View(items);
        }

        public ActionResult Remove(Favourite f)
        {
            var data = entities.Favourites.Find(f.Id);

            if (data != null)
            {
                entities.Favourites.Remove(data);
                entities.SaveChanges();

                return RedirectToAction("Favourites", "Home");
            }
            return null;
        }

        public ActionResult Movies()
        {
            return View(movieList);
        }
        public ActionResult AudioBooks()
        {
            return View(audioBookList);
        }

        public ActionResult TVShows()
        {
            return View(tVShowsList);
        }

        public ActionResult Blog()
        {
            return View(blogsList);
        }
    }
}