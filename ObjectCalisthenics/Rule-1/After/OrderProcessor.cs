namespace ObjectCalisthenics.Rule_1.After
{
    internal class OrderProcessor
    {
        internal void ProcessOrder(Order order)
        {
            if (!CanProcess(order))
            {
                return;
            }

            ShipOrder(order);
        }

        private static bool CanProcess(Order order)
        {
            return order != null && order.IsPaid && order.HasStock();
        }

        private static void ShipOrder(Order order)
        {
            // Logic to ship the order
        }

        public class Order
        {
            public bool IsPaid { get; set; }

            public bool HasStock()
            {
                // Check stock availability
                return true; // Placeholder for actual stock check
            }
        }
    }
}
