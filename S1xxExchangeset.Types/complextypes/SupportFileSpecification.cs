using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class SupportFileSpecification : ComplexTypeBase, ISupportFileSpecification
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Date { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(Name) &&
                    String.IsNullOrEmpty(Version) &&
                    String.IsNullOrEmpty(Date);
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
            writer.WriteStartElement(NamespacePrefix, "supportFileSpecification", Namespace);

            if (String.IsNullOrEmpty(Name))
            {
                writer.WriteStartElement(NamespacePrefix, "name", Namespace);
                writer.WriteString(Name);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(Version))
            {
                writer.WriteStartElement(NamespacePrefix, "version", Namespace);
                writer.WriteString(Version);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(Date))
            {
                writer.WriteStartElement(NamespacePrefix, "date", Namespace);

                if (DateTime.TryParse(Date, out DateTime datetimeValue))
                {
                    writer.WriteString(datetimeValue.ToString("yyyy-MM-dd"));
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
