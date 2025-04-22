namespace ObjectCalisthenics.Rule_6.Before
{
    internal class ShippingService
    {
        public decimal Calc(Order o)
        {
            var ct = o.CstType;
            var p = o.Prc;

            if (ct == "new")
            {
                return p * 0.95m;
            }

            return p * 1.1m;
        }

        public record Order(string CstType, decimal Prc);
    }
}
