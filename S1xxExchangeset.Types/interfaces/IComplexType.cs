using System.Xml.Serialization;

namespace S1xxExchangeset.Types.interfaces
{
    public interface IComplexType : IXmlSerializable
    {
        string NamespacePrefix { get; set; }
        string Namespace { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        bool IsEmpty { get; }
    }
}
