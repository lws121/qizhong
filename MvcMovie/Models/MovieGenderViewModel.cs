using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenderViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genders { get; set; }
        public string  movieGender { get; set; }
        public string SearchString { get; set; }
    }
}
