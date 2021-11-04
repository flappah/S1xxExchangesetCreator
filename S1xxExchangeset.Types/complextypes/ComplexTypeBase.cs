using S1xxExchangeset.Types.interfaces;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public abstract class ComplexTypeBase : IComplexType
    {
        public string NamespacePrefix { get; set; }
        public string Namespace { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public abstract bool IsEmpty { get; }
        public abstract XmlSchema GetSchema();
        public abstract void ReadXml(XmlReader reader);

        /// <summary>
        ///     Write XML to XmlWriter 
        /// </summary>
        /// <param name="writer">writer to write XML to</param>
        public abstract void WriteXml(XmlWriter writer);
    }
}
