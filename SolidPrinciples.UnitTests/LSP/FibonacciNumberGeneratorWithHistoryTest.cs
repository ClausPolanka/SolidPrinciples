using System;
using NUnit.Framework;
using SolidPrinciples.LSP;

namespace SolidPrinciples.UnitTests.LSP
{
    [TestFixture]
    public class FibonacciNumberGeneratorWithHistoryTest
    {
        [Test]
        public void WhenSequenceIsRequestedSequenceLengthIsStored()
        {
            var sut = new FinbonacciNumberGeneratorWithHistory();
            sut.GetSequenceOfLength(8);
            Assert.That(8, Is.EqualTo(sut.LastSequenceLength), "sequence length");
        }

        [Test]
        public void CannotRequestSequenceOfLengthLessThanEight()
        {
            var sut = new FinbonacciNumberGeneratorWithHistory();
            Assert.Throws<ArgumentException>(() => sut.GetSequenceOfLength(7));
        }
    }
}