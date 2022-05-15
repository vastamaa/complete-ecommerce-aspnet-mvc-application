using eTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Cinema logo is required!")]
        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Cinema name is required!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Cinema description is required!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
