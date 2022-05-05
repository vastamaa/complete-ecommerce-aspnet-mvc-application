using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "The profile picture is required!")]
        public string ProfilePictureURL { get; set; }

        [Required(ErrorMessage = "Full name is required!")]
        [Display(Name = "Full name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The full name must be between 3 and 50 characters!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Biography is required!")]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
