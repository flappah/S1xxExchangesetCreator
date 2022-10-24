using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class ProductSpecification : ComplexTypeBase, IProductSpecification
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Date { get; set; }
        public string Number { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(Name) &&
                    String.IsNullOrEmpty(Version) &&
                    String.IsNullOrEmpty(Date) && 
                    String.IsNullOrEmpty(Number);
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
            writer.WriteStartElement(NamespacePrefix, "productSpecification", Namespace);

            if (!String.IsNullOrEmpty(Name))
            {
                writer.WriteStartElement(NamespacePrefix, "name", Namespace);
                writer.WriteString(Name);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(Version))
            {
                writer.WriteStartElement(NamespacePrefix, "version", Namespace);
                writer.WriteString(Version);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(Date))
            {
                writer.WriteStartElement(NamespacePrefix, "date", Namespace);
                writer.WriteString(Date);

                if (DateTime.TryParse(Date, out DateTime dateValue))
                {
                    writer.WriteString(dateValue.ToString("yyyy-MM-dd"));
                }

                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(Number) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "number", Namespace);
                writer.WriteString(Number);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
