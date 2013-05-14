using System;
using System.Globalization;

namespace SolidPrinciples.SRP
{
    public class BankTransfer
    {
        private BankAccount payer;
        private BankAccount payee;
        private double amount;

        public BankTransfer(BankAccount payer, BankAccount payee, double amount)
        {
            this.payer = payer;
            this.payee = payee;
            this.amount = amount;
        }

        public void Execute()
        {
            payer.Withdraw(amount);
            payee.Deposit(amount);
        }

        public string ToXml()
        {
            return "<BankTransfer amount='" + string.Format(new CultureInfo("en"), "{0:0.0}", amount) + "'>" +
                   "<Payer>" + payer.GetAccountNumber() + "</Payer>" +
                   "<Payee>" + payee.GetAccountNumber() + "</Payee>" +
                   "</BankTransfer>";
        }
    }
}
