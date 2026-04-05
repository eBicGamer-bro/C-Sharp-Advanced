namespace Assignment_1_C__Advanced
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException()
        {

        }
        public InsufficientBalanceException(string message) : base(message)
        {
        }
        public InsufficientBalanceException(string? message, Exception innerException) : base(message, innerException)
        {
        }
    }
    public class BankAccount
    {
        private string name;
        private double balance;
        public BankAccount(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
                throw new InsufficientBalanceException("Insufficient Balance!");
            else balance -= amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Fares", 900);
            try
            {
                account.Withdraw(1000);
            }catch(InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
