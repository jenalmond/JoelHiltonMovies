using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonMovies.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please enter a movie title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the year the movie was released.")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Please enter the movie director's name.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a rating.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
        public int CategoryId { get; set; }
        //[Required(ErrorMessage = "Please select a category.")]
        public Category Category { get; set; }
    }
} 
