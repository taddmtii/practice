namespace InterviewPractice.OrderService
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
