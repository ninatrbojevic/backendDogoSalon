using System.ComponentModel.DataAnnotations;

namespace dogo_api.Database.Entities
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string OwnersFirstName { get; set; }
        public string OwnersLastName { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public string Treatment { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
