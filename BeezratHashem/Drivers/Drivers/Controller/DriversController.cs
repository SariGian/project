using Microsoft.AspNetCore.Mvc;

namespace Drivers.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        

        [HttpGet]
        public string GetAll()
        {
            return "hello";
        }
    }
}
