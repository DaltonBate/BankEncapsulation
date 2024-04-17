namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var daltonsaccount = new BankAccount();
           
            Console.WriteLine("How much would you like to deposit?");

            var amountToDep = double.Parse(Console.ReadLine());

            daltonsaccount.Deposit(amountToDep);

            Console.WriteLine($"Thank you! Your balance is now {daltonsaccount.GetBalance()}"); 
        }
    }
}
