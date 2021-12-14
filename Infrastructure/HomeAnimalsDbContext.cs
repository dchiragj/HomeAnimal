using Microsoft.EntityFrameworkCore;
using Models;

namespace Infrastructure
{
    public class HomeAnimalsDbContext : DbContext
    {
        public HomeAnimalsDbContext(DbContextOptions<HomeAnimalsDbContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cat>()
            .HasOne<Owner>(s => s.Owner)
            .WithMany(g => g.Cat)
            .HasForeignKey(s => s.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dog>()
            .HasOne<Owner>(s => s.Owner)
            .WithMany(g => g.Dog)
            .HasForeignKey(s => s.OwnerId)
            .OnDelete(DeleteBehavior.Cascade);


            //Owner List
            modelBuilder.Entity<Owner>().HasData(
                new Owner() { Id = "1", Name = "John", Dob = System.DateTime.Now, Age = 366, Address = "New York", Phone = "00000", NoOfPets = 4, Gender = "Male" });
            modelBuilder.Entity<Owner>().HasData(
                new Owner() { Id = "2", Name = "Ryan", Dob = System.DateTime.Now, Age = 560, Address = "New York", Phone = "00000", NoOfPets = 2, Gender = "Male" });
            modelBuilder.Entity<Owner>().HasData(
                new Owner() { Id = "3", Name = "Smith", Dob = System.DateTime.Now, Age = 560, Address = "New York", Phone = "00000", NoOfPets = 6, Gender = "Male" });
            modelBuilder.Entity<Owner>().HasData(
                new Owner() { Id = "4", Name = "Riya", Dob = System.DateTime.Now, Age = 560, Address = "New York", Phone = "00000", NoOfPets = 4, Gender = "Female" });
            modelBuilder.Entity<Owner>().HasData(
                new Owner() { Id = "5", Name = "Kriva", Dob = System.DateTime.Now, Age = 560, Address = "New York", Phone = "00000", NoOfPets = 4, Gender = "Female" });

            //Cat List
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "1", Name = "Cat1", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 368, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = false, Colour = "black", OwnerId = "1" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "2", Name = "Cat2", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "1" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "3", Name = "Cat3", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "2" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "4", Name = "Cat4", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "5", Name = "Cat5", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "6", Name = "Cat6", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "7", Name = "Cat7", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "4" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "8", Name = "Cat8", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "4" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "9", Name = "Cat9", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "5" });
            modelBuilder.Entity<Cat>().HasData(
                new Cat() { Id = "10", Name = "Cat10", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 455, CatchingMouses = true, Breed = "2", Characteristics = "brown-big", MedicalCondition = "xyz", Gender = "Male", Vaccination = true, Colour = "black", OwnerId = "5" });
            
            //Dog List
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "1", Name = "Dog1", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "1" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "2", Name = "Dog2", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "1" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "3", Name = "Dog3", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "2" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "4", Name = "Dog4", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "5", Name = "Dog5", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "6", Name = "Dog6", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "3" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "7", Name = "Dog7", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "4" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "8", Name = "Dog8", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "4" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "9", Name = "Dog9", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "5" });
            modelBuilder.Entity<Dog>().HasData(
                new Dog() { Id = "10", Name = "Dog10", DOB = System.DateTime.Now, NoOfFeeding = 1, Age = 422, LevelOfTraining = 5, SupposedHeight = "20cm", Breed = "xyz", Characteristics = "brown-big", MedicalCondition = "xyz", Vaccination = true, Gender = "Male", Colour = "black", OwnerId = "5" });


        }
    }
}
