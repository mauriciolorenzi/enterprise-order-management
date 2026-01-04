using enterprise_order_management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace enterprise_order_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok();
        }

        public IActionResult List()
        {
            return Ok();
        }

        public IActionResult Checkout(Order order)
        {
            return Ok();
        }
    }
}
