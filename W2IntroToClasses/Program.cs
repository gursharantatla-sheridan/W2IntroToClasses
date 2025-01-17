namespace W2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product();
            //Product p2 = new Product(101, "Laptop", 1200);


            AccountWithMethods myAcc = new AccountWithMethods(500);
            Console.WriteLine("Balance = " + myAcc.GetBalance().ToString("C"));

            myAcc.Deposit(100);
            Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));

            try
            {
                myAcc.Withdraw(3000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));
        }
    }
}
