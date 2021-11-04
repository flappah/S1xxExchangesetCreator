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
            writer.WriteStartElement(NamespacePrefix, "datasetDiscoveryMetadata", Namespace);

            //public string FileName { get; set; }
            if (!String.IsNullOrEmpty(FileName))
            {
                writer.WriteStartElement(NamespacePrefix, "fileName", Namespace);
                writer.WriteString(FileName);
                writer.WriteEndElement();
            }

            //public string FileLocation { get; set; }
            if (!String.IsNullOrEmpty(FileLocation))
            {
                writer.WriteStartElement(NamespacePrefix, "fileLocation", Namespace);
                writer.WriteString(FileLocation);
                writer.WriteEndElement();
            }

            //public string Purpose { get; set; }
            if (!String.IsNullOrEmpty(Purpose))
            {
                writer.WriteStartElement(NamespacePrefix, "purpose", Namespace);
                writer.WriteString(Purpose);
                writer.WriteEndElement();
            }

            //public string EditionNumber { get; set; }
            if (!String.IsNullOrEmpty(EditionNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "editionNumber", Namespace);
                writer.WriteString(EditionNumber);
                writer.WriteEndElement();
            }

            //public string IssueDate { get; set; }
            if (!String.IsNullOrEmpty(IssueDate))
            {
                writer.WriteStartElement(NamespacePrefix, "issueDate", Namespace);
                writer.WriteString(IssueDate);

                if (DateTime.TryParse(IssueDate, out DateTime issuedateValue))
                {
                    writer.WriteString(issuedateValue.ToString("yyyy-MM-dd"));
                }

                writer.WriteEndElement();
            }

            //public ISupportFileSpecification SupportFileSpecification { get; set; }
            if (SupportFileSpecification != null && SupportFileSpecification.IsEmpty == false)
            {
                SupportFileSpecification.WriteXml(writer);
            }

            //public string DataType { get; set; }
            if (!String.IsNullOrEmpty(DataType))
            {
                writer.WriteStartElement(NamespacePrefix, "dataType", Namespace);
                writer.WriteString(DataType);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
