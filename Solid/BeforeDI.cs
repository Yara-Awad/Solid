using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class FileLogger
    {
        public void Log(string message)
        {
            // Write to file
        }
    }

    public class OrderService
    {
        private FileLogger _logger = new FileLogger();

        public void PlaceOrder()
        {
            _logger.Log("Order placed");
        }
    }

}
