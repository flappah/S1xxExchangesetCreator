using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Classification : ComplexTypeBase, IClassification
    {
        public string CodeList { get; set; }
        public string CodeListValue { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(CodeList) &&
                        String.IsNullOrEmpty(CodeListValue);
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
            writer.WriteStartElement(NamespacePrefix, "classification", Namespace);
            writer.WriteAttributeString("gco", "isoType", @"http://www.isotc211.org/2005/gco");

            writer.WriteStartElement("gmd", "MD_ClassificationCode", "http://www.isotc211.org/2005/gmd");
            writer.WriteAttributeString("codeList", CodeList ?? @"http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/gmxCodelists.xml#CI_ClassificationCode");
            writer.WriteAttributeString("codeListValue", CodeListValue ?? "unclassified");

            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
