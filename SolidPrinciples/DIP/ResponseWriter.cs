namespace SolidPrinciples.DIP
{
    public class ResponseWriter
    {
        public virtual string CreateResponse(Customer customer, ResponseKind responseKind)
        {
            if (responseKind == ResponseKind.HTML)
                return new HtmlSerializer().SerializeToHtml(customer);
            
            return new XmlSerializer().SerializeToXml(customer);
        }
    }
}