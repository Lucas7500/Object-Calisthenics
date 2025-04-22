namespace ObjectCalisthenics.Rule_7.After
{
    internal class OrderValidator
    {
        public void Validate(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            if (order.Id == Guid.Empty)
            {
                throw new ArgumentException("Order ID cannot be empty.");
            }
        }
    }
}
