using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Customer:IPrototype<Customer>
    {
        public string CustomerName { get; set; }

        public Customer(string customerName)
        {
            CustomerName = customerName;
        }

        public Customer Clone()
        {
            Customer clone = new Customer(this.CustomerName);
            return clone;   
        }
    }
}
