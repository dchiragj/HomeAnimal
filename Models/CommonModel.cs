using System;
using System.Collections.Generic;

namespace Models
{
    public class UpdateNoOfFeeding
    {
        public string PetId { get; set; }
        public string Type { get; set; }
    }

    public class OwnerDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public int NoOfPets { get; set; }
        public string Gender { get; set; }
        public Pets Pets { get; set; }
    }

    public class Pets
    {
        public List<Cat> Cats { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}
