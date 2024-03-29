using Microsoft.EntityFrameworkCore;

namespace EpicodusPets.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext(DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pet>()
                .HasData(
                    new Pet { PetId = 1, Name = "Sylvie", Species = "Dog", Breed = "Shih-tzu mix", Age = 6, Gender = "Female", Description = "Grey, lanky, fluffy, distinct underbite", FavoriteThings = "Chicken, tortellini, beach, snow, her toys, being cozy", LeastFavoriteThings = "Grooming, vet visits, guitars, being cold, being alone", Owner = "Jacqueline", PhotoPath = "wwwroot/uploads/sylvie-jacqueline.jpg" },

                    new Pet { PetId = 2, Name = "Bridget", Species = "Dog", Breed = "Shih-tzu", Age = 7, Gender = "Female", Description = "lazy bum", FavoriteThings = "yogurt, cheese, carrots, sleep", LeastFavoriteThings = "Grooming, vet visits, raspberries (not the food), being alone", Owner = "Jason", PhotoPath = "wwwroot/uploads/bridget-jason.jpg" },

                    new Pet { PetId = 3, Name = "Chunk", Species = "Cat", Breed = "Long-hair Domestic Feline", Age = 5, Gender = "Male", Description = "Floofy McCuddlebug, Diva", FavoriteThings = "naps, snacks, being the little spoon, screaming", LeastFavoriteThings = "Toe touches, Watching his brother get affection, Being hungry ", Owner = "Sofia", PhotoPath = "wwwroot/uploads/chunk-sofia.jpg" },

                    new Pet { PetId = 4, Name = "Toad", Species = "Cat", Breed = "Medium-hair Domestic Feline", Age = 7, Gender = "Male", Description = "Lovebug, Angel, Shy", FavoriteThings = "Snuggles, Gravy, Treats, Feather", LeastFavoriteThings = "Loud noises, Strangers, Sudden movements, Vacuum", Owner = "Sofia", PhotoPath = "wwwroot/uploads/toad-sofia.jpg" },

                    new Pet { PetId = 5, Name = "Winston", Species = "Cat", Breed = "Short-hair Domestic Feline", Age = 6, Gender = "Male", Description = "A fine boi looking for his furrever girl.", FavoriteThings = "His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt", LeastFavoriteThings = "The vacuum, being picked up, having his nails clipped", Owner = "Mike", PhotoPath = "wwwroot/uploads/winston-mike.jpg" },

                    new Pet { PetId = 6, Name = "Roscoe", Species = "Dog", Breed = "German Shepard 1st Generation German-American", Age = 5, Gender = "Male", Description = "A Scooby Doo kinda guy looking for his Nova.", FavoriteThings = "Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls", LeastFavoriteThings = "Boxes, rain, baths, anything outdoors (except snow)", Owner = "Jen", PhotoPath = "wwwroot/uploads/roscoe-jen.jpg" },

                    new Pet { PetId = 7, Name = "Mau", Species = "Cat", Breed = "Medium-hair Domestic Feline", Age = 1, Gender = "Female", Description = "Mau is friendly to a fault.", FavoriteThings = "Mau enjoys taking naps and climbing house plants.", LeastFavoriteThings = "Rain and being told what to do", Owner = "Micah", PhotoPath = "wwwroot/uploads/mau-micah.jpg" },

                    new Pet { PetId = 8, Name = "Jasper", Species = "Dog", Breed = "Dutch Shepherd", Age = 12, Gender = "Male", Description = "A scary looking dog that is a true sweetheart", FavoriteThings = "Jasper loves stuffed toys, food, cheese, and water", LeastFavoriteThings = "Rain. Loud Noises.", Owner = "Erin(Chris's wife)", PhotoPath = "wwwroot/uploads/jasper-chris.jpg" },

                    new Pet { PetId = 9, Name = "Wren", Species = "Dog", Breed = "Australian Cattledog", Age = 4, Gender = "Female", Description = "Wren is a red heeler that loves to pick on other dogs", FavoriteThings = "Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese.", LeastFavoriteThings = "Rain and being told what to do", Owner = "Chris", PhotoPath = "wwwroot/uploads/wren-chris.jpg" },

                    new Pet { PetId = 10, Name = "Molly", Species = "Dog", Breed = "Australian Shepherd", Age = 2, Gender = "Female", Description = "Ridiculously fluffy and adorable, and knows it", FavoriteThings = "All squeeky toys.", LeastFavoriteThings = "Limes", Owner = "Christine", PhotoPath = "wwwroot/uploads/molly-christine.jpg" },

                    new Pet { PetId = 11, Name = "Uwa", Species = "Snake", Breed = "Ball Python", Age = 3, Gender = "Female", Description = "Very Curious, loves to get into trouble spots.", FavoriteThings = "Climbing Branches.", LeastFavoriteThings = "Fast Movement", Owner = "Erin", PhotoPath = "wwwroot/uploads/uwa-erin.jpg" },

                    new Pet { PetId = 12, Name = "Mocha", Species = "Cat", Breed = "Russian Blue Mix", Age = 4, Gender = "Female", Description = "Fluffy, talkative, will steal your cheese.", FavoriteThings = "Pets and butt scratches", LeastFavoriteThings = "Thunder and Vacuums", Owner = "Erin", PhotoPath = "wwwroot/uploads/mocha-erin.jpg" },

                    new Pet { PetId = 13, Name = "Stripes", Species = "Cat", Breed = "Unknown", Age = 1, Gender = "Male", Description = "Dangerous", FavoriteThings = "Total domination, sleeping", LeastFavoriteThings = "Being locked up", Owner = "Carrie", PhotoPath = "wwwroot/uploads/stripes-carrie.jpg" },

                    new Pet { PetId = 14, Name = "Kima", Species = "Dog", Breed = "Coonhound/Lab", Age = 3, Gender = "Female", Description = "The best dog ever", FavoriteThings = "hikes", LeastFavoriteThings = "shower", Owner = "Joel", PhotoPath = "wwwroot/uploads/kima-joel.jpg" },

                    new Pet { PetId = 15, Name = "Ashford", Species = "Cat", Breed = "Domestic short hair", Age = 6, Gender = "Male", Description = "Has an adorable moustache", FavoriteThings = "sleeping", LeastFavoriteThings = "screaming toddlers", Owner = "Anita", PhotoPath = "wwwroot/uploads/ashford-anita.jpg" },

                    new Pet { PetId = 16, Name = "Jasper", Species = "Cat", Breed = "Mixed Breed Maine Coon", Age = 2, Gender = "Male", Description = "Very sassy when restless but irresistably cute when sleepy", FavoriteThings = "Paper bags, boxes, being gently stroked on the nose while falling asleep", LeastFavoriteThings = "Sylvie", Owner = "Will (Jacqueline's roommate)", PhotoPath = "wwwroot/uploads/jasper-jacqueline.jpg" },

                    new Pet { PetId = 17, Name = "Levi", Species = "Dog", Breed = "Dachshund mix", Age = 5, Gender = "Male", Description = "#1 Handsy Boy", FavoriteThings = "Wearing clothes and playing with the hose", LeastFavoriteThings = "strangers, other dogs playing with his toys", Owner = "Joey (Jason's brother)", PhotoPath = "wwwroot/uploads/levi-jason.jpg" },

                    new Pet { PetId = 18, Name = "Meeko", Species = "Cat", Breed = "Mancoon, taby mix", Age = 8, Gender = "Male", Description = "Snuggly pur-box", FavoriteThings = "Catnip, food and cuddles", LeastFavoriteThings = "Other pets that steal the love he should be getting", Owner = "Hailey", PhotoPath = "wwwroot/uploads/meeko-hailey.jpg" },

                    new Pet { PetId = 19, Name = "Ladybird", Species = "Dog", Breed = " Golden Retriever", Age = 7, Gender = "Female", Description = "Such a love, very demanding with being loved on", FavoriteThings = "She loves to bring you gifts when you get home like my socks", LeastFavoriteThings = "Other dogs..", Owner = "Hailey", PhotoPath = "wwwroot/uploads/ladybird-hailey.jpg" },

                    new Pet { PetId = 20, Name = "Ebba Beryl", Species = "Dog", Breed = "Great Pyrenees", Age = 1, Gender = "Female", Description = "Huge white fully baby", FavoriteThings = "Loves the snow and to be outside with other animals", LeastFavoriteThings = "Water", Owner = "Hailey", PhotoPath = "wwwroot/uploads/ebba-beryl-hailey.jpg" }
                );
        }
    }
}