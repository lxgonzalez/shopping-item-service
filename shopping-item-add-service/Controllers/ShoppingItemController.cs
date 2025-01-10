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
        

        [HttpPost]
        public async Task<ActionResult<ShoppingItem>> CreateShoppingItem([FromBody] ShoppingItem shoppingItem)
        {
            try
            {
                _context.ShoppingItem.Add(shoppingItem);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(CreateShoppingItem), new { id = shoppingItem.Id }, shoppingItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
