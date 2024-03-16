using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BowlingAPI.Data;

namespace BowlingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private iBowlerRepository _bowlerRepository;
        public BowlerController(iBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlers = _bowlerRepository.Bowlers.ToArray();

            return bowlers;
        }
    }
}
