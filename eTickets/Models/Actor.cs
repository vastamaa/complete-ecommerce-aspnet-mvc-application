using System.Collections.Generic;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
