namespace OrderProcessingApp.Models
{
    public class Order
    {
        public decimal? Amount { get; set; }
        public string? CustomerType { get; set; }
        public decimal? Discount { get; set; }
        public decimal? FinalAmount { get; set; }
    }
}
