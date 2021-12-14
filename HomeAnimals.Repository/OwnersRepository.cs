using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAnimals.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class OwnersRepository : IOwnersRepository
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly HomeAnimalsDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public OwnersRepository(HomeAnimalsDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<Tuple<bool, string, List<OwnerDetails>>> GetAllOwners()
        {
            List<OwnerDetails> ownersList = new List<OwnerDetails>();

            List<Owner> ownerList = await _context.Owners.Include(m => m.Cat).Include(m => m.Dog).ToListAsync();
            foreach (Owner item in ownerList)
            {
                OwnerDetails ownerDetails = new OwnerDetails();
                if (item != null)
                {
                    ownerDetails.Id = item.Id;
                    ownerDetails.Name = item.Name;
                    ownerDetails.Dob = item.Dob;
                    ownerDetails.Address = item.Address;
                    ownerDetails.Age = item.Age;
                    ownerDetails.Phone = item.Phone;
                    ownerDetails.NoOfPets = item.NoOfPets;
                    ownerDetails.Gender = item.Gender;

                    Pets pets = new Pets();
                    List<Dog> dogs = new List<Dog>();
                    List<Cat> cats = new List<Cat>();
                    cats = item.Cat.ToList();
                    dogs = item.Dog.ToList();

                    pets.Cats = cats;
                    pets.Dogs = dogs;
                    ownerDetails.Pets = pets;

                    ownersList.Add(ownerDetails);
                }
            }
            if (ownersList.Count > 0)
            {
                return new Tuple<bool, string, List<OwnerDetails>>(true, "Get successful.", ownersList);
            }
            else
            {
                return new Tuple<bool, string, List<OwnerDetails>>(true, "No records found.", null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, OwnerDetails>> GetOwnersById(string Id)
        {
            OwnerDetails ownerDetails = new OwnerDetails();

            Owner owner = await _context.Owners.Where(c => c.Id == Id).Include(m => m.Cat).Include(m => m.Dog).FirstOrDefaultAsync();
            if (owner != null)
            {
                ownerDetails.Id = owner.Id;
                ownerDetails.Name = owner.Name;
                ownerDetails.Dob = owner.Dob;
                ownerDetails.Address = owner.Address;
                ownerDetails.Age = owner.Age;
                ownerDetails.Phone = owner.Phone;
                ownerDetails.NoOfPets = owner.NoOfPets;
                ownerDetails.Gender = owner.Gender;

                Pets pets = new Pets();
                List<Dog> dogs = new List<Dog>();
                List<Cat> cats = new List<Cat>();
                cats = owner.Cat.ToList();
                dogs = owner.Dog.ToList();

                pets.Cats = cats;
                pets.Dogs = dogs;
                ownerDetails.Pets = pets;

                return new Tuple<bool, string, OwnerDetails>(true, "Get successful.", ownerDetails);
            }
            else
            {
                return new Tuple<bool, string, OwnerDetails>(true, "No records found.", null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public async Task<Tuple<bool, string, OwnerDetails>> UpdateNoOfFeeding(UpdateNoOfFeeding updateNoOfFeeding)
        {
            if (updateNoOfFeeding.Type.ToLower() == "cat")
            {
                Cat catObj = await _context.Cats.Where(c => c.Id == updateNoOfFeeding.PetId).FirstOrDefaultAsync();
                if (catObj != null)
                {
                    catObj.NoOfFeeding = catObj.NoOfFeeding + 1;
                    _ = await _context.SaveChangesAsync();

                    Tuple<bool, string, OwnerDetails> tuple = await GetOwnersById(catObj.OwnerId);
                    return new Tuple<bool, string, OwnerDetails>(true, "Update Successful.", tuple.Item3);
                }
                else
                {
                    return new Tuple<bool, string, OwnerDetails>(false, "Cat Details Not Found.", null);
                }
            }
            else
            {
                Dog dogObj = await _context.Dogs.Where(c => c.Id == updateNoOfFeeding.PetId).FirstOrDefaultAsync();
                if (dogObj != null)
                {
                    dogObj.NoOfFeeding = dogObj.NoOfFeeding + 1;
                    _ = await _context.SaveChangesAsync();

                    Tuple<bool, string, OwnerDetails> tuple = await GetOwnersById(dogObj.OwnerId);
                    return new Tuple<bool, string, OwnerDetails>(true, "Update Successful.", tuple.Item3);
                }
                else
                {
                    return new Tuple<bool, string, OwnerDetails>(false, "Cat Details Not Found.", null);
                }
            }
        }
    }
}
