using System.Xml.Serialization;

namespace xmlbounty.Models
{
    [XmlRoot(ElementName = "document", Namespace = "")]
    public class DocumentDto
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("content")]
        public string Content { get; set; }

        [XmlAttribute("author")]
        public string Author { get; set; }
    }
}
