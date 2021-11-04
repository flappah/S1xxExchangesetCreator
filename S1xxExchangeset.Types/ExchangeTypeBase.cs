using S1xxExchangeset.Types.interfaces;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types
{
    public abstract class ExchangeTypeBase : IExchangeType
    {
        public string NamespacePrefix { get; set; }
        public string Namespace { get; set; }

        public abstract XmlSchema GetSchema();
        public abstract void ReadXml(XmlReader reader);
        public abstract void WriteXml(XmlWriter writer);
    }
}
