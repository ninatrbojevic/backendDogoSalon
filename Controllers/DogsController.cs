using dogo_api.Database;
using dogo_api.Database.Entities;
using dogo_api.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dogo_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private DogoContext _context;

        public DogsController(DogoContext context)
        {
            _context = context;    
        }


        // GET: api/<DogsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Dora", "Roko" };
        }

        // GET api/<DogsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DogsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateReservationRequest reservationRequest)
        {
            var newReservation = new Reservation
            {
                OwnersFirstName = reservationRequest.OwnersFirstName,
                OwnersLastName = reservationRequest.OwnersLastName,
                DogName = reservationRequest.DogName,
                DogBreed = reservationRequest.DogBreed,
                Treatment = reservationRequest.Treatment,
                Date = reservationRequest.Date,
                CreatedAt = DateTime.UtcNow
            };

            _context.Reservations.Add(newReservation);

            _context.SaveChanges();

            return new OkObjectResult( new
            {
                newReservation.Id
            });
        }

        // PUT api/<DogsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DogsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
