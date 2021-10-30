namespace InventoryManagement.Models.Dtos
{
    public class StockVsSoldItemsResponse
    {
        public string ProductName { get; set; }
        public float SoldItems { get; set; }
        public float UnitsInStock { get; set; }
    }

}
