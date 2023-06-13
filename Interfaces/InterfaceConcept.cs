using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }

        decimal productAmount { get; set; }

        decimal CalculateDiscount();
    }

    public interface ICustomerGreeting : ICustomer
    {
        string GreetingMessage();
    }

    public abstract class Customer : ICustomer, ICustomerGreeting
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public decimal productAmount { get; set; }
        public abstract decimal CalculateDiscount();

        public abstract string GreetingMessage();
    }

    public class GoldCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 10;
        }

        public override string GreetingMessage()
        {
            return "Thank You ;-) ";
        }
    }

    public class SilverCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            return productAmount - 20;
        }

        public override string GreetingMessage()
        {
            return " Thank you. Visit again.";
        }
    }
}
