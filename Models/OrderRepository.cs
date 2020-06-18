using System.Collections.Generic;

namespace MedicationOrders.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context) =>
            _context = context;
  
        public IEnumerable<Order> GetOrders() =>
            _context.Orders;
 
        public Order GetOrder(int id) => _context.Orders.Find(id); 
    }
}
