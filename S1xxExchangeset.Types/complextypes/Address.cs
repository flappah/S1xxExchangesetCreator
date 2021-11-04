using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Address : ComplexTypeBase, IAddress
    {
        public ICIAddress CIAddress { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return CIAddress == null || CIAddress.IsEmpty;
            }
        }

        public override XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public override void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Write XML to XmlWriter 
        /// </summary>
        /// <param name="writer">writer to write XML to</param>
        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(NamespacePrefix, "Address", Namespace);

            if (CIAddress != null && CIAddress.IsEmpty == false)
            {
                CIAddress.Namespace = Namespace;
                CIAddress.NamespacePrefix = NamespacePrefix;
                CIAddress.WriteXml(writer);
            }

            writer.WriteEndElement();
        }
    }
}
