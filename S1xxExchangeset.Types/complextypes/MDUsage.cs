using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class MDUsage : ComplexTypeBase, IMDUsage
    {
        public string SpecificUsage { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(SpecificUsage);
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
            writer.WriteStartElement(NamespacePrefix, "MD_Usage", Namespace);

            if (String.IsNullOrEmpty(SpecificUsage) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "specificUsage", Namespace);
                writer.WriteStartElement("gco", "characterString", @"http://www.isotc211.org/2005/gco");
                writer.WriteString(SpecificUsage);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
