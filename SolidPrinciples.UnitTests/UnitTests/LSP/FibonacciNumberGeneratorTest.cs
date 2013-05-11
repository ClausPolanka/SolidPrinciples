using NUnit.Framework;
using SolidPrinciples.LSP;

namespace SolidPrinciples.UnitTests.UnitTests.LSP
{
    [TestFixture]
    public class FibonacciNumberGeneratorTest
    {
        [Test]
        public void FirstFIveFibonacciNumbersShouldMatchSeries()
        {
            var sut = new FinbonacciNumberGenerator();
            int[] sequenceOfLength = sut.GetSequenceOfLength(5);
            Assert.That(sequenceOfLength, Is.EqualTo(new[] { 0, 1, 1, 2, 3 }));
        }
    }
}