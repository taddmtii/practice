namespace InterviewPractice.OrderService
{
    public class OrderService
    {
        private readonly IEmailService _emailService;

        // The interface is INJECTED here — OrderService never creates EmailService itself
        public OrderService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"Order #{order.Id} placed for {order.ProductName}");

            _emailService.SendEmail(
                to: order.CustomerEmail,
                subject: "Order Confirmed!",
                body: $"Thanks! Your order for {order.ProductName} (${order.TotalPrice}) is confirmed."
            );
        }
    }
}