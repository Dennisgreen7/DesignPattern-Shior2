using Prototype;


static T DeepCopy<T>(T self)
{
    var json = System.Text.Json.JsonSerializer.Serialize(self);
    T obj = System.Text.Json.JsonSerializer.Deserialize<T>(json);
    return obj;
}

Customer Customer = new Customer("Dennis Greenberg");
Bill b1=new Bill(Customer,4);
var b2 = b1.Clone();
Console.WriteLine(b1.Customer.CustomerName+" "+b1.Price);
Console.WriteLine(b2.Customer.CustomerName+" "+b2.Price);
Console.WriteLine("----------------------------------------");
b1.Customer.CustomerName = "Dennis";
b1.Price = 10;
Console.WriteLine(b1.Customer.CustomerName +" "+b1.Price);
Console.WriteLine(b2.Customer.CustomerName+" "+b2.Price);
Console.WriteLine("--------------------------------------- ");
Bill newBill = DeepCopy<Bill>(b1);
newBill.Customer.CustomerName = "New Customer";
newBill.Price = 14;
Console.WriteLine(b1.ToString());
Console.WriteLine(b2.ToString());
Console.WriteLine(newBill.ToString());
Console.ReadLine();

