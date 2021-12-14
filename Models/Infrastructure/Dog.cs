using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    [Table("Dog")]
    public class Dog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double NoOfFeeding { get; set; }
        public DateTime DOB { get; set; }
        public int LevelOfTraining { get; set; }
        public string SupposedHeight { get; set; }
        public string Breed { get; set; }
        public string Characteristics { get; set; }
        public string MedicalCondition { get; set; }
        public int Age { get; set; }
        public bool Vaccination { get; set; }
        public string Gender { get; set; }
        public string Colour { get; set; }
        public string OwnerId { get; set; }
        [JsonIgnore]
        public virtual Owner Owner { get; set; }
    }
}
