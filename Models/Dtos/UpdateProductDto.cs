namespace InventoryManagement.Models.Dtos
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float SellingPrice { get; set; }
    }
}
