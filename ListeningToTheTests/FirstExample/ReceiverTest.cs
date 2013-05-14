using NUnit.Framework;

namespace ListeningToTheTests.FirstExample
{
    [TestFixture]
    public class ReceiverTest
    {
        private const Request FIRST_REQUEST = null;
        private const Request SECOND_REQUEST = null;

        [Test]
        public void RejectsTheTestNotWithinTheSameDay()
        {
            var sut = new Receiver();
            sut.AcceptRequest(FIRST_REQUEST);
            Assert.False(sut.AcceptRequest(SECOND_REQUEST), "too late now");
        }
    }
}