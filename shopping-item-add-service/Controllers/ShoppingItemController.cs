using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingItemAddService.Data;
using ShoppingItemAddService.Models;
namespace CartListService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingItemController : ControllerBase
    {
        private readonly ShoppingItemContext _context;

        public ShoppingItemController(ShoppingItemContext context)
        {
            _context = context;
        }
        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShoppingItem>>> GetCartItems()
        {
            return await _context.ShoppingItem.ToListAsync();
        }

    }
}
