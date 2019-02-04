using Microsoft.AspNetCore.Mvc;
using WebAPITemplate.Repositories;

namespace WebAPITemplate.Controllers
{
    [Route("api/[controller]")]
    public class SampleGetController : Controller
    {
        private readonly ISampleGetRepository _iSampleGetRepository;

        public SampleGetController(ISampleGetRepository iSampleGetRepository)
        {
            _iSampleGetRepository = iSampleGetRepository;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_iSampleGetRepository.Get());
        }
    }
}