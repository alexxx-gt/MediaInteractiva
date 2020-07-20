using DAL.Models;
using Microsoft.EntityFrameworkCore;
using SharedModels.Enums;
using System.Collections.Generic;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Owner)
                .WithMany(e => e.Animals)
                .HasForeignKey(a => a.OwnerId);

            modelBuilder.Entity<Employee>().HasData(new List<Employee>() { 
                new Employee { Id = 1, FirstName = "Aaron", LastName = "Hamilton", IsMIEmployee = true},
                new Employee { Id = 2, FirstName = "Jayden", LastName = "Anderson", IsMIEmployee = true },
                new Employee { Id = 3, FirstName = "Edward", LastName = "Reid", IsMIEmployee = true },
                new Employee { Id = 4, FirstName = "Theo", LastName = "Davidson", IsMIEmployee = true },
                new Employee { Id = 5, FirstName = "Theo", LastName = "Lawson", IsMIEmployee = true },
                new Employee { Id = 6, FirstName = "Kenneth", LastName = "Morton", IsMIEmployee = true },
                new Employee { Id = 7, FirstName = "Alexis", LastName = "Larsen", IsMIEmployee = true },
                new Employee { Id = 8, FirstName = "Austin", LastName = "Atkinson", IsMIEmployee = true },
                new Employee { Id = 9, FirstName = "Riley", LastName = "Daugherty", IsMIEmployee = true },
                new Employee { Id = 10, FirstName = "Korbin", LastName = "Harding", IsMIEmployee = true },
                new Employee { Id = 11, FirstName = "Stanley", LastName = "Wright", IsMIEmployee = true },
                new Employee { Id = 12, FirstName = "Kayden", LastName = "Kennedy", IsMIEmployee = true },
                new Employee { Id = 13, FirstName = "Sean", LastName = "Harris", IsMIEmployee = true },
                new Employee { Id = 14, FirstName = "Lewis", LastName = "Davies", IsMIEmployee = true },
                new Employee { Id = 15, FirstName = "Stanley", LastName = "Jackson", IsMIEmployee = true },
                new Employee { Id = 16, FirstName = "Zechariah", LastName = "Rosario", IsMIEmployee = true },
                new Employee { Id = 17, FirstName = "Sincere", LastName = "Terrell", IsMIEmployee = true },
                new Employee { Id = 18, FirstName = "Kendall", LastName = "Lindsay", IsMIEmployee = true },
                new Employee { Id = 19, FirstName = "Emery", LastName = "Gillespie", IsMIEmployee = true },
                new Employee { Id = 20, FirstName = "Maddox", LastName = "Chen", IsMIEmployee = true },
                new Employee { Id = 21, FirstName = "Jodie", LastName = "Evans", IsMIEmployee = true },
                new Employee { Id = 22, FirstName = "Abbie", LastName = "Hudson", IsMIEmployee = true },
                new Employee { Id = 23, FirstName = "Charlotte", LastName = "Gordon", IsMIEmployee = true },
                new Employee { Id = 24, FirstName = "Libby", LastName = "Rogers", IsMIEmployee = true },
                new Employee { Id = 25, FirstName = "Lacey", LastName = "Cooke", IsMIEmployee = true },
                new Employee { Id = 26, FirstName = "Kensley", LastName = "Cobb", IsMIEmployee = true },
                new Employee { Id = 27, FirstName = "Ariel", LastName = "Ramos", IsMIEmployee = true },
                new Employee { Id = 28, FirstName = "Lola", LastName = "Moran", IsMIEmployee = true },
                new Employee { Id = 29, FirstName = "Carissa", LastName = "Contreras", IsMIEmployee = true },
                new Employee { Id = 30, FirstName = "Phoenix", LastName = "Valenzuela", IsMIEmployee = true }});

            modelBuilder.Entity<Animal>().HasData(new List<Animal>()
            {
                new Animal{Id = 1, Name = "ABBEY", Type = EAnimalType.Dog, OwnerId = 1},
                new Animal{Id = 2, Name = "ABBY", Type = EAnimalType.Cat, OwnerId = 2},
                new Animal{Id = 3, Name = "ABEL", Type = EAnimalType.Parrot, OwnerId = 3},
                new Animal{Id = 4, Name = "BEAMER", Type = EAnimalType.Hamster, OwnerId = 5},
                new Animal{Id = 5, Name = "BEANIE", Type = EAnimalType.Cavy, OwnerId = 6},
                new Animal{Id = 6, Name = "BEANS", Type = EAnimalType.Snake, OwnerId = 7},
                new Animal{Id = 7, Name = "BEAR", Type = EAnimalType.Raccoon, OwnerId = 8},
                new Animal{Id = 8, Name = "BEAU", Type = EAnimalType.Dog, OwnerId = 9},
                new Animal{Id = 9, Name = "BEAUTY", Type = EAnimalType.Cat, OwnerId = 10},
                new Animal{Id = 10, Name = "BEAUX", Type = EAnimalType.Parrot, OwnerId = 11},
                new Animal{Id = 11, Name = "CASSIS", Type = EAnimalType.Hamster, OwnerId = 12},
                new Animal{Id = 12, Name = "CHA CHA", Type = EAnimalType.Cavy, OwnerId = 13},
                new Animal{Id = 13, Name = "CHAD", Type = EAnimalType.Snake, OwnerId = 14},
                new Animal{Id = 14, Name = "CHAMBERLAIN", Type = EAnimalType.Raccoon, OwnerId = 15},
                new Animal{Id = 15, Name = "CHAMP", Type = EAnimalType.Dog, OwnerId = 16},
                new Animal{Id = 16, Name = "CHANCE", Type = EAnimalType.Cat, OwnerId = 17},
                new Animal{Id = 17, Name = "CHANEL", Type = EAnimalType.Parrot, OwnerId = 18},
                new Animal{Id = 18, Name = "CHAOS", Type = EAnimalType.Hamster, OwnerId = 19},
                new Animal{Id = 19, Name = "CHARISMA", Type = EAnimalType.Cavy, OwnerId = 20},
                new Animal{Id = 20, Name = "FLAKE", Type = EAnimalType.Snake, OwnerId = 21},
                new Animal{Id = 21, Name = "FLAKEY", Type = EAnimalType.Raccoon, OwnerId = 22},
                new Animal{Id = 22, Name = "FLASH", Type = EAnimalType.Dog, OwnerId = 23},
                new Animal{Id = 23, Name = "FLINT", Type = EAnimalType.Cat, OwnerId = 24},
                new Animal{Id = 24, Name = "FLOPSY", Type = EAnimalType.Parrot, OwnerId = 25},
                new Animal{Id = 25, Name = "FLOWER", Type = EAnimalType.Hamster, OwnerId = 26},
                new Animal{Id = 26, Name = "FLOYD", Type = EAnimalType.Cavy, OwnerId = 27},
                new Animal{Id = 27, Name = "GOOSE", Type = EAnimalType.Snake, OwnerId = 28},
                new Animal{Id = 28, Name = "GORDON", Type = EAnimalType.Raccoon, OwnerId = 29},
                new Animal{Id = 29, Name = "GRACE", Type = EAnimalType.Dog, OwnerId = 30},
                new Animal{Id = 30, Name = "GRACIE", Type = EAnimalType.Cat, OwnerId = 1},
                new Animal{Id = 31, Name = "GRADY", Type = EAnimalType.Parrot, OwnerId = 2},
                new Animal{Id = 32, Name = "GREENIE", Type = EAnimalType.Hamster, OwnerId = 3},
                new Animal{Id = 33, Name = "GRETA", Type = EAnimalType.Cavy, OwnerId = 4},
                new Animal{Id = 34, Name = "JUDY", Type = EAnimalType.Snake, OwnerId = 5},
                new Animal{Id = 35, Name = "JULIUS", Type = EAnimalType.Raccoon, OwnerId = 6},
                new Animal{Id = 36, Name = "JUNE", Type = EAnimalType.Dog, OwnerId = 7},
                new Animal{Id = 37, Name = "JUNIOR", Type = EAnimalType.Cat, OwnerId = 8},
                new Animal{Id = 38, Name = "JUSTICE", Type = EAnimalType.Parrot, OwnerId = 9},
                new Animal{Id = 39, Name = "KALI", Type = EAnimalType.Hamster, OwnerId = 10},
                new Animal{Id = 40, Name = "KALLIE", Type = EAnimalType.Cavy, OwnerId = 11},
                new Animal{Id = 41, Name = "KANE", Type = EAnimalType.Snake, OwnerId = 12},
                new Animal{Id = 42, Name = "KARMA", Type = EAnimalType.Raccoon, OwnerId = 13},
                new Animal{Id = 43, Name = "KASEY", Type = EAnimalType.Dog, OwnerId = 14},
                new Animal{Id = 44, Name = "KATIE", Type = EAnimalType.Cat, OwnerId = 15},
                new Animal{Id = 45, Name = "KATO", Type = EAnimalType.Parrot, OwnerId = 16},
                new Animal{Id = 46, Name = "KATZ", Type = EAnimalType.Hamster, OwnerId = 17},
                new Animal{Id = 47, Name = "KAYLA", Type = EAnimalType.Cavy, OwnerId = 18},
                new Animal{Id = 48, Name = "KC", Type = EAnimalType.Snake, OwnerId = 19},
                new Animal{Id = 49, Name = "KEESHA", Type = EAnimalType.Raccoon, OwnerId = 20},
                new Animal{Id = 50, Name = "KELLIE", Type = EAnimalType.Dog, OwnerId = 21},
                new Animal{Id = 51, Name = "KELLY", Type = EAnimalType.Cat, OwnerId = 22},
                new Animal{Id = 52, Name = "KELSEY", Type = EAnimalType.Parrot, OwnerId = 23},
                new Animal{Id = 53, Name = "KENYA", Type = EAnimalType.Hamster, OwnerId = 24},
                new Animal{Id = 54, Name = "KERRY", Type = EAnimalType.Cavy, OwnerId = 25},
                new Animal{Id = 55, Name = "RALPHIE", Type = EAnimalType.Snake, OwnerId = 26},
                new Animal{Id = 56, Name = "RAMBLER", Type = EAnimalType.Raccoon, OwnerId = 27},
                new Animal{Id = 57, Name = "RAMBO", Type = EAnimalType.Dog, OwnerId = 28},
                new Animal{Id = 58, Name = "RANGER", Type = EAnimalType.Cat, OwnerId = 29},
                new Animal{Id = 59, Name = "RASCAL", Type = EAnimalType.Parrot, OwnerId = 30},
                new Animal{Id = 60, Name = "RAVEN", Type = EAnimalType.Hamster, OwnerId = 1},
                new Animal{Id = 61, Name = "REBEL", Type = EAnimalType.Cavy, OwnerId = 2},
                new Animal{Id = 62, Name = "RED", Type = EAnimalType.Snake, OwnerId = 3},
                new Animal{Id = 63, Name = "REGGIE", Type = EAnimalType.Raccoon, OwnerId = 4},
                new Animal{Id = 64, Name = "REILLY", Type = EAnimalType.Dog, OwnerId = 5},
                new Animal{Id = 65, Name = "REMY", Type = EAnimalType.Cat, OwnerId = 6},
                new Animal{Id = 66, Name = "REX", Type = EAnimalType.Parrot, OwnerId = 7},
                new Animal{Id = 67, Name = "REXY", Type = EAnimalType.Hamster, OwnerId = 8},
                new Animal{Id = 68, Name = "RHETT", Type = EAnimalType.Cavy, OwnerId = 9},
                new Animal{Id = 69, Name = "RICKY", Type = EAnimalType.Snake, OwnerId = 10},
                new Animal{Id = 70, Name = "RICO", Type = EAnimalType.Raccoon, OwnerId = 11},
                new Animal{Id = 71, Name = "RIGGS", Type = EAnimalType.Dog, OwnerId = 12},
                new Animal{Id = 72, Name = "RILEY", Type = EAnimalType.Cat, OwnerId = 13},
            });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
    }
}
