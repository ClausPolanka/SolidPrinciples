namespace SolidPrinciples.SRP
{
    public class BankAccount
    {
        private string accountNumber;
        private double amount;

        public BankAccount(string accountNumber, double amount)
        {
            this.accountNumber = accountNumber;
            this.amount = amount;
        }

        public void Withdraw(double amount)
        {
            this.amount -= amount;
        }

        public void Deposit(double amount)
        {
            this.amount += amount;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public double GetAmount()
        {
            return amount;
        }
    }
}