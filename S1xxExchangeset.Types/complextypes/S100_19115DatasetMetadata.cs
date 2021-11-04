using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class S100_19115DatasetMetadata : ComplexTypeBase, IS100_19115DatasetMetadata
    {
        public string FileName { get; set; }
        public string Label { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(FileName) &&
                    String.IsNullOrEmpty(Label);
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
            writer.WriteStartElement(NamespacePrefix, "S100_19115DatasetMetadata", Namespace);

            if (!String.IsNullOrEmpty(FileName))
            {
                writer.WriteStartElement("gmx", "FileName", @"http://www.isotc211.org/2005/gmx");
                writer.WriteAttributeString("src", FileName);
                writer.WriteString(Label);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
