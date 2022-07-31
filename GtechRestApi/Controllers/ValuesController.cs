using Microsoft.AspNetCore.Mvc;

namespace GtechRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost("Post")]
        public int Post([FromBody] Summer value)
        {
            int sum = 0;
            foreach (var item in value.Numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
