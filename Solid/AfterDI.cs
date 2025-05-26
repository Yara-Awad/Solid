using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger2 : ILogger
    {
        public void Log(string message)
        {
            // Write to file
        }
    }

    public class OrderService2
    {
        private readonly ILogger _logger;

        public OrderService2(ILogger logger)
        {
            _logger = logger;
        }

        public void PlaceOrder()
        {
            _logger.Log("Order placed");
        }
    }

}
