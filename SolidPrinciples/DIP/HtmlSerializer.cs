namespace SolidPrinciples.DIP
{

    public class HtmlSerializer
    {
        public string SerializeToHtml(Customer customer)
        {
            return "<html><head><title>Customer Details</title></head>" +
                   "<body><table><tr><td>Customer</td></tr><td>" + customer.Name + 
                   "</td></table></body></html>";
        }
    }
}