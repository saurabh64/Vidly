using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        private Movie movie;

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }

        public IEnumerable<Genre> Genres { get; set; }
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}