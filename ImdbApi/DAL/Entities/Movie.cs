using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImdbApi.DAL.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public double Rate { get; set; }
        public int DirectorId { get; set; }
        [JsonIgnore]
        public virtual Director Director { get; set; }
        [JsonIgnore]
        public virtual ICollection<MovieGenre> MovieGenre { get; set; }
    }
}
