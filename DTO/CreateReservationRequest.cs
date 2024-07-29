namespace dogo_api.DTO
{
    public class CreateReservationRequest
    {
        public string OwnersFirstName { get; set; }
        public string OwnersLastName { get; set; }
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public string Treatment { get; set; }
        public DateTime Date { get; set; }
    }
}
