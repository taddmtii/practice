namespace InterviewPractice
{


    public interface IOrderRepository {
        public void SaveOrder(string item);
    }

    public class OrderRepository : IOrderRepository
    {
        public void SaveOrder(string item) {
            Console.WriteLine($"Saving order... {item}");
        }
    }

    public class OrderService
    {

        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository orderRepository)
        {
            _repository = orderRepository;
        }

        public void PlaceOrder(string item) {
            _repository.SaveOrder(item);
        }
        
    }

}      
 
