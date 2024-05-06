using Microsoft.AspNetCore.Mvc;
using Security.Presention.Abstraction;

namespace Security.Presention.Controller
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public sealed class TestController:ApiController
    {
        [HttpGet]
        
        public IActionResult Get()
        {
            return Ok("İşlem başarılıdır.");
        }
    }
}
