using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ImdbApi.DAL.Entities
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string GenderName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Director> Director { get; set; }
    }
}
