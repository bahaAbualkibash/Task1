using System;

namespace Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _ShippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _ShippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.InShipped)
                throw new InvalidOperationException("this order is already processed");

            order.Shipment = new Shipment
            {
                Cost = _ShippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}