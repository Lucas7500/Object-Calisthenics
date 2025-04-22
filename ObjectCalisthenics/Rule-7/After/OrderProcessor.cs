namespace ObjectCalisthenics.Rule_7.After
{
    internal class OrderProcessor(
        OrderValidator orderValidator,
        PaymentProcessor paymentProcessor,
        Notifier notifier,
        InventoryManager inventoryManager,
        ShippingService shippingService)
    {
        public void Process(Order order)
        {
            orderValidator.Validate(order);
            paymentProcessor.Process(order);
            notifier.SendConfirmation(order);
            inventoryManager.UpdateStock(order);
            shippingService.InitiateShipping(order);
        }
    }
}
