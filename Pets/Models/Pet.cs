using System.Collections.Generic;

namespace EpicodusPets.Models
{
    public class Pet
    {
        public Pet()
        {
            this.Photos = new HashSet<Photo>();
        }
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string FavoriteThings { get; set; }
        public string LeastFavoriteThings { get; set; }
        public string Owner { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}