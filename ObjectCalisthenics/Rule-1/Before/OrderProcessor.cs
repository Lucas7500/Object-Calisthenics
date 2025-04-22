namespace ObjectCalisthenics.Rule_1.Before
{
    internal class OrderProcessor
    {
        internal void ProcessOrder(Order order)
        {
            if (order != null)
            {
                if (order.IsPaid)
                {
                    if (order.HasStock())
                    {
                        ShipOrder(order);
                    }
                }
            }
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
