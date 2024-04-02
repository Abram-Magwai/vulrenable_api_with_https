using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace vulrenable_api_with_https.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        [HttpPost("SendMessage")]
        public IActionResult SendMessage(string message)
        {
            Console.WriteLine("Received message");
            return Ok(message);
        }
        [HttpPost("SendMessageObject")]
        public IActionResult SendMessageObject(Message message)
        {
            return Ok(message);
        }
        [HttpPost("SendComplexObject")]
        public IActionResult SendComplexObject(ComplexObject complexObject)
        {
            return Ok(complexObject);
        }
    }
    public class Message
    {
        public string Context { get; set; } = null!;
    }
    public class ComplexObject
    {
        public string Message { get; set; } = null!;
        public int Size { get; set; }
    }
}
