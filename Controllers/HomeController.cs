using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BADigital_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IServiceCateRepository serviceCateRepository;

        public HomeController()
        {
            serviceCateRepository = new ServiceCateRepository();
        }

        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<ServiceCategory> Get()
        {
            return serviceCateRepository.GetServiceCategories();
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
