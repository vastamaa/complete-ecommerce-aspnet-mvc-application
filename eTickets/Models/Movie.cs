using eTickets.Data;
using System;

namespace eTickets.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategories { get; set; }
    }
}
