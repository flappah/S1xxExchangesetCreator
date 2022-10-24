using S1xxExchangeset.Types.interfaces;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class PTLocale : ComplexTypeBase, IPT_Locale
    {
        public string Language { get; set; }
        public string Country { get; set; }
        public string CharacterEncoding { get; set; }

        public override bool IsEmpty => String.IsNullOrEmpty(Language)

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
        /// <param name="writer">writer to write XML to</param
        public override void WriteXml(XmlWriter writer)
        {
            NamespacePrefix = "lan";
            Namespace = "http://standards.iso.org/iso/19115/-3/lan/1.0";

            writer.WriteStartElement(NamespacePrefix, "PT_Locale", Namespace);
            writer.WriteStartElement(NamespacePrefix, "language", Namespace);
            if (String.IsNullOrEmpty(Language) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "languageCode", Namespace);
                writer.WriteString(Language);
                writer.WriteEndElement();
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (String.IsNullOrEmpty(Country) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "country", Namespace);
                writer.WriteStartElement(NamespacePrefix, "CountryCode", Namespace);
                writer.WriteString(Country);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteStartElement(NamespacePrefix, "characterEncoding", Namespace);
            if (String.IsNullOrEmpty(CharacterEncoding) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "MD_CharacterSetCode", Namespace);
                writer.WriteString(CharacterEncoding);
                writer.WriteEndElement();
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
