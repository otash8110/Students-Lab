using System.Xml;

namespace Adapter.Services
{
    public class Library
    {
        private readonly string xmlString = @"
                        <Books>
                            <Book><Date>2022-11-16T00:00:00</Date></Book>
                            <Book><Date>2022-11-15T00:00:00</Date></Book>
                        </Books>
                        ";

        public XmlDocument GetBooksXML()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);
            return xmlDocument;
        }
    }
}
