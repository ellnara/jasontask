using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public Pro pro { get; set; }
        public List<OrderItem> order;
    }
}
