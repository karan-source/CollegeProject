using CollegeProject.Models;
using System.Collections.Generic;

namespace CollegeProject.ViewModel
{
    public class IndexModel
    {
        public List<Movie> MyMovies { get; set; }
        public List<Slider> MySlides { get; set; }
        public List<TVShows> MyTvShows { get; set; }
        public List<AudioBooks> MyAudioBooks { get; set; }

    }
}