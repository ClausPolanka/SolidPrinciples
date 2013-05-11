namespace SolidPrinciples.DIP
{

    public class XmlSerializer
    {
        public string SerializeToXml(Customer customer)
        {
            return "<customer>" + customer.Name + "</customer>";
        }
    }
}