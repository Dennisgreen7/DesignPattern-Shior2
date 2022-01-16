using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Bill:IPrototype<Bill>
    {
        public Customer Customer { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public Bill(Customer customer,int price)
        {
            Customer = customer;
            Date = DateTime.Now;
            Price= price;   
        }

        public Bill Clone() 
        {
            Bill bill = new Bill(this.Customer.Clone(),Price);
            return bill;    
        }
        public override string ToString()
        {
            return this.Customer.CustomerName +" Paid "+ Price+" Date "+ Date;
        }
    }
}
