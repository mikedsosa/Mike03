using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mike03.Models
{
    //Create a class that will get/set variables from the form input
    //Perform validations such as Required and Max Length before submitting form. 
    public class EnterNewMovieResponse
    {
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage = "Please limit notes to 25 characters or less")]
        public string Notes { get; set; }
    }
}
