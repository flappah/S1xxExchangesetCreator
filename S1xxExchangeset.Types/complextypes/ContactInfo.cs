using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class ContactInfo : ComplexTypeBase, IContactInfo
    {
        public ICIContact CIContact { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty 
        { 
            get
            {
                return CIContact == null || CIContact.IsEmpty;
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
            writer.WriteStartElement(NamespacePrefix, "contactInfo", Namespace);

            if (CIContact != null && CIContact.IsEmpty == false)
            {
                CIContact.Namespace = Namespace;
                CIContact.NamespacePrefix = NamespacePrefix;
                CIContact.WriteXml(writer);
            }

            writer.WriteEndElement();
        }
    }
}
