using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class CIContact : ComplexTypeBase, ICIContact
    {
        public IAddress Address { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty 
        { 
            get
            {
                return Address == null || Address.IsEmpty;
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
            writer.WriteStartElement(NamespacePrefix, "CI_Contact", Namespace);
            writer.WriteStartElement(NamespacePrefix, "address", Namespace);

            if (Address != null && Address.IsEmpty == false)
            {
                Address.Namespace = Namespace;
                Address.NamespacePrefix = NamespacePrefix;
                Address.WriteXml(writer);
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
