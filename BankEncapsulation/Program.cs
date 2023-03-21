namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ninasAccount = new BankAccount(); //Calling the constructor

            ninasAccount.GetBalance();

            Console.WriteLine();
            Console.WriteLine("How much do you want to deposit?");
            var depAmount = double.Parse(Console.ReadLine());

            ninasAccount.Deposit(depAmount);

            ninasAccount.GetBalance();
        }
    }
}
