using System.Collections.Generic;

namespace MedicationOrders.Models
{
    public interface IOrderRepository
    {
        Order GetOrder(int id);
        IEnumerable<Order> GetOrders();
    }
}
