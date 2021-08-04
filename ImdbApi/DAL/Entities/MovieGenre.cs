using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImdbApi.DAL.Entities
{
    public class MovieGenre
    {
        [Key]
       
        public int Id { get; set; }

        public int GenreId { get; set; }
        [JsonIgnore]
        public Genre Genre { get; set; }

        public int MovieId { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
