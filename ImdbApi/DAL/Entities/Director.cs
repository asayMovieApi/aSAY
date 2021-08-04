using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImdbApi.DAL.Entities
{
    public class Director
    {
        [Key]
        
        public int Id { get; set; }
       
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Movie> Movies { get; set; }
        
        public int GenderId { get; set; }
        [JsonIgnore]
        public virtual Gender Gender { get; set; }
    }
}
