using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripOrganizer.Domain.Entities;
using TripOrganizer.Infra.Repository;

namespace TripOrganizer.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {

        private readonly TripsRepository _tripsRepository;

        public TripsController(TripsRepository tripsRepository)
        {
            _tripsRepository = tripsRepository;
        }

        [HttpGet]
        public async Task<List<Trip>> GetAllTrips()
        {

        }

        [HttpPost]
        public async Task<IActionResult> AddTrip([FromBody] Trip trip)
        {

        }

        [HttpPut]
        public async Task<IActionResult> EditTrip()
    }
}
