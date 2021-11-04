using System.Xml.Serialization;

namespace S1xxExchangeset.Types.interfaces
{
    public interface IExchangeType : IXmlSerializable
    {
        string NamespacePrefix { get; set; }
        string Namespace { get; set; }
    }
}
