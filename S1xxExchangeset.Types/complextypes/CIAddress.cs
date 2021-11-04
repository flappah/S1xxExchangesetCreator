using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class CIAddress : ComplexTypeBase, ICIAddress
    {
        public string DeliveryPoint { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(DeliveryPoint) &&
                    String.IsNullOrEmpty(City) &&
                    String.IsNullOrEmpty(PostalCode);
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
            writer.WriteStartElement(NamespacePrefix, "CI_Address", Namespace);

            if (String.IsNullOrEmpty(DeliveryPoint))
            {
                writer.WriteStartElement("gmd", "deliveryPoint", "http://www.isotc211.org/2005/gmd");
                writer.WriteStartElement("gco", "CharacterString", "http://www.isotc211.org/2005/gco");
                writer.WriteString(DeliveryPoint);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(City))
            {
                writer.WriteStartElement("gmd", "city", "http://www.isotc211.org/2005/gmd");
                writer.WriteStartElement("gco", "CharacterString", "http://www.isotc211.org/2005/gco");
                writer.WriteString(City);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(PostalCode))
            {
                writer.WriteStartElement("gmd", "postalCode", "http://www.isotc211.org/2005/gmd");
                writer.WriteStartElement("gco", "CharacterString", "http://www.isotc211.org/2005/gco");
                writer.WriteString(PostalCode);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
