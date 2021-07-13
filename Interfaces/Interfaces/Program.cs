using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new OrderProcessor
            {
                DataPlaced = DateTime.Now, TotalPrice = 100f
            };
            orderProcessor.Process(order);
        }
    }
}
