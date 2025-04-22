namespace ObjectCalisthenics.Rule_7.Before
{
    internal class OrderService
    {
        public void ProcessOrder(Order order)
        {
            ValidateOrder(order);
            ProcessPayment(order);
            SendConfirmation(order);
            UpdateStock(order);
            InitiateShipping(order);
        }

        private void ValidateOrder(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            if (order.Id == Guid.Empty)
            {
                throw new ArgumentException("Order ID cannot be empty.");
            }
        }

        private void ProcessPayment(Order order)
        {
            // Logic to process payment
        }

        private void SendConfirmation(Order order)
        {
            // Logic to send confirmation
        }

        private void UpdateStock(Order order)
        {
            // Logic to update stock
        }

        private void InitiateShipping(Order order)
        {
            // Logic to initiate shipping
        }

        public record Order(Guid Id);
    }
}
