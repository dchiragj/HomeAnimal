using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Owner")]
    public class Owner
    {
        public Owner()
        {
            Cat = new HashSet<Cat>();
            Dog = new HashSet<Dog>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        [Required]
        public string Phone { get; set; }
        public int NoOfPets { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Cat> Cat { get; set; }
        public virtual ICollection<Dog> Dog { get; set; }
    }
}
