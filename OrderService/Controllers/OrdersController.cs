using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.Data;
using OrderService.Models;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext _context;
        public OrdersController(OrderContext orderContext)
        {
            _context = orderContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order orders)
        {
            _context.Orders.Add(orders);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrders), new { id = orders.Id }, orders);
        }
    }
}