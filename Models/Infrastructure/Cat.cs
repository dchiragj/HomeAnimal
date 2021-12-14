using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    [Table("Cat")]
    public class Cat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public double NoOfFeeding { get; set; }
        public DateTime DOB { get; set; }
        public bool CatchingMouses { get; set; }
        public string Breed { get; set; }
        public string Characteristics { get; set; }
        public string MedicalCondition { get; set; }
        public int Age { get; set; }
        public bool Vaccination { get; set; }
        public string Gender { get; set; }
        public string Colour { get; set; }
        [JsonIgnore]
        public virtual Owner Owner { get; set; }
        public string OwnerId { get; set; }
    }
}
