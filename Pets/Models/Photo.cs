namespace EpicodusPets.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public int PetId { get; set; }
        public string Url { get; set; }
        public virtual Pet Pet { get; set; }
    }
}