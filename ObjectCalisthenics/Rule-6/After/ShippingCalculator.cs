namespace ObjectCalisthenics.Rule_6.After
{
    internal class ShippingCalculator
    {
        public decimal Calculate(Order order)
        {
            var customerType = order.CustomerType;
            var orderPrice = order.Price;

            if (customerType == "new")
            {
                return orderPrice * 0.95m;
            }

            return orderPrice * 1.1m;
        }

        public record Order(string CustomerType, decimal Price);
    }
}
