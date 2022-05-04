using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Profile picture")]
        [Required(ErrorMessage = "Profile picture is required!")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The full name must be between 3 and 50 characters!")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required!")]
        public string Biography { get; set; }


        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
