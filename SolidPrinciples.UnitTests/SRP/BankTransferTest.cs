using NUnit.Framework;
using SolidPrinciples.SRP;

namespace SolidPrinciples.UnitTests.SRP
{
    [TestFixture]
    public class BankTransferTest
    {
        [Test]
        public void TransferAmountFromPayerToPayee()
        {
            var payer = new BankAccount(accountNumber: "1", amount: 1.0);
            var payee = new BankAccount(accountNumber: "2", amount: 0.0);
            var sut = new BankTransfer(payer, payee, amount: 1.0);
            sut.Execute();
            Assert.That(payer.GetAmount(), Is.EqualTo(0.0), "amount");
            Assert.That(payee.GetAmount(), Is.EqualTo(1.0), "amount");
        }

        [Test]
        public void SerializeBankTransferToXml()
        {
            var payer = new BankAccount(accountNumber: "1", amount: 1.0);
            var payee = new BankAccount(accountNumber: "2", amount: 0.0);
            var sut = new BankTransfer(payer, payee, amount: 1.0);
            var xml = sut.ToXml();
            Assert.That(xml, Is.StringContaining(payer.GetAccountNumber()), "payer accountnumber");
            Assert.That(xml, Is.StringContaining(payee.GetAccountNumber()), "payee accountnumber");
            Assert.That(xml, Is.StringContaining("1.0"), "amount");
        }
    }
}
