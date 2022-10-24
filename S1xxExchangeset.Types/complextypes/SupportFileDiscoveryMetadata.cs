using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class SupportFileDiscoveryMetadata : ComplexTypeBase, ISupportFileDiscoveryMetadata
    {
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string Purpose { get; set; }
        public string EditionNumber { get; set; }
        public string IssueDate { get; set; }
        public ISupportFileSpecification SupportFileSpecification { get; set; }
        public string DataType { get; set; }
        public string OtherDataTypeDescription { get; set; }
        public string DataTypeVersion { get; set; }
        public string Comment { get; set; }
        public string DigitalSignatureReference { get; set; }
        public string DigitalSignatureValue { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(FileName) &&
                    String.IsNullOrEmpty(FileLocation) &&
                    String.IsNullOrEmpty(Purpose) &&
                    String.IsNullOrEmpty(EditionNumber) &&
                    String.IsNullOrEmpty(IssueDate) &&
                    (SupportFileSpecification == null || SupportFileSpecification.IsEmpty) &&
                    String.IsNullOrEmpty(DataType);
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
            writer.WriteStartElement(NamespacePrefix, "supportFileDiscoveryMetadata", Namespace);

            //public string FileName { get; set; }
            writer.WriteStartElement(NamespacePrefix, "fileName", Namespace);
            if (!String.IsNullOrEmpty(FileName))
            {
                writer.WriteString(FileName);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string FileLocation { get; set; }
            writer.WriteStartElement(NamespacePrefix, "fileLocation", Namespace);
            if (!String.IsNullOrEmpty(FileLocation))
            {
                writer.WriteString(FileLocation);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string Purpose { get; set; }
            writer.WriteStartElement(NamespacePrefix, "purpose", Namespace);
            if (!String.IsNullOrEmpty(Purpose))
            {
                writer.WriteString(Purpose);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string EditionNumber { get; set; }
            writer.WriteStartElement(NamespacePrefix, "editionNumber", Namespace);
            if (!String.IsNullOrEmpty(EditionNumber))
            {
                writer.WriteString(EditionNumber);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string IssueDate { get; set; }
            writer.WriteStartElement(NamespacePrefix, "issueDate", Namespace);
            if (!String.IsNullOrEmpty(IssueDate) &&
                DateTime.TryParse(IssueDate, out DateTime issuedateValue))
            {
                writer.WriteString(issuedateValue.ToString("yyyy-MM-dd"));
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public ISupportFileSpecification SupportFileSpecification { get; set; }
            if (SupportFileSpecification != null && SupportFileSpecification.IsEmpty == false)
            {
                SupportFileSpecification.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("supportFileSpecification");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            //public string DataType { get; set; }
            writer.WriteStartElement(NamespacePrefix, "dataType", Namespace);
            if (!String.IsNullOrEmpty(DataType))
            {
                writer.WriteString(DataType);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (String.IsNullOrEmpty(OtherDataTypeDescription) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "otherDataTypeDescription", Namespace);
                writer.WriteString(OtherDataTypeDescription);
                writer.WriteEndElement();
            }

            writer.WriteStartElement(NamespacePrefix, "dataTypeVersion", Namespace);
            if (!String.IsNullOrEmpty(DataTypeVersion))
            {
                writer.WriteString(DataTypeVersion);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (String.IsNullOrEmpty(Comment) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "comment", Namespace);
                writer.WriteString(Comment);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(DigitalSignatureReference) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureReference", Namespace);
                writer.WriteString(DigitalSignatureReference);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(DigitalSignatureValue) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureValue", Namespace);
                writer.WriteString(DigitalSignatureValue);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
