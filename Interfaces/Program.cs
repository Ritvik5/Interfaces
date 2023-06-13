namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Interface concepts!!!\n");

            GoldCustomer obj = new GoldCustomer();
            obj.Name = "Ramesh";
            obj.Address = "Bangalore";
            obj.productAmount = 100;


            Console.WriteLine("Name = " + obj.Name + "\nAddress = " + obj.Address + "\nProductAmount = " + obj.productAmount +
                                        "\nProductAmount after discount = " + obj.CalculateDiscount() + "\nGreetingMessage = " + obj.GreetingMessage());

            SilverCustomer obj2 = new SilverCustomer();
            obj2.Name = "Suresh";
            obj2.Address = "Bangalore";
            obj2.productAmount = 100;
            Console.WriteLine("\nName = " + obj2.Name + "\nAddress = " + obj2.Address + "\nProductAmount = " + obj2.productAmount +
                                        "\nProductAmount after discount = " + obj2.CalculateDiscount() + "\nGreetingMessage = " + obj2.GreetingMessage());

            Console.Read();
        }
    }
}