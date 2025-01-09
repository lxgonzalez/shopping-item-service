namespace ShoppingItemService.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        public required int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
        public required decimal Subtotal { get; set; }
    }

}
