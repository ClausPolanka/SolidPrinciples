using NUnit.Framework;
using SolidPrinciples.DIP;

namespace SolidPrinciples.UnitTests.DIP
{
    [TestFixture]
    public class ResponseWriterTest
    {
        [Test]
        public void CreateHtmlResponseForCustomer()
        {
            var customer = new Customer { Name = "Name1" };
            var responseKind = ResponseKind.HTML;
            string response = new ResponseWriter().CreateResponse(customer, responseKind);
            Assert.That(response, Is.StringContaining("html"), "response format");
            Assert.That(response, Is.StringContaining("Name1"), "response");
        }

        [Test]
        public void CreateXmlResponseForCustomer()
        {
            var customer = new Customer { Name = "Name1" };
            string response = new ResponseWriter().CreateResponse(customer, responseKind: null);
            Assert.That(response, Is.StringContaining("<customer>"), "response format");
            Assert.That(response, Is.StringContaining("Name1"), "response");
        }
    }
}
