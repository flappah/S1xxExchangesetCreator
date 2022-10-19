using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class S100_CatalogueMetadata : ComplexTypeBase, IS100_CatalogueMetadata
    {
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string Scope { get; set; }
        public string VersionNumber { get; set; }
        public string IssueDate { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public string DigitalSignatureReferences { get; set; }
        public string DigitalSignatureValue { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get {
                return String.IsNullOrEmpty(FileName) &&
                    String.IsNullOrEmpty(FileLocation) &&
                    String.IsNullOrEmpty(Scope) &&
                    String.IsNullOrEmpty(VersionNumber) &&
                    String.IsNullOrEmpty(IssueDate) &&
                    (ProductSpecification == null || ProductSpecification.IsEmpty) &&
                    String.IsNullOrEmpty(DigitalSignatureValue) &&
                    String.IsNullOrEmpty(DigitalSignatureReferences);
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
            writer.WriteStartElement(NamespacePrefix, "S100_CatalogueMetadata", Namespace);

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

            //public string Scope { get; set; }
            if (!String.IsNullOrEmpty(Scope))
            {
                writer.WriteStartElement(NamespacePrefix, "scope", Namespace);
                writer.WriteString(Scope);
                writer.WriteEndElement();
            }

            //public string VersionNumber { get; set; }
            if (!String.IsNullOrEmpty(VersionNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "versionNumber", Namespace);
                writer.WriteString(VersionNumber);
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

            //public IProductSpecification ProductSpecification { get; set; }
            if (ProductSpecification != null && ProductSpecification.IsEmpty == false)
            {
                ProductSpecification.WriteXml(writer);
            }

            //public string DigitalSignatureReferences { get; set; }
            if (!String.IsNullOrEmpty(DigitalSignatureReferences))
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureReference", Namespace);
                writer.WriteString(DigitalSignatureReferences);
                writer.WriteEndElement();
            }

            //public string DigitalSignatureValue { get; set; }
            if (!String.IsNullOrEmpty(DigitalSignatureValue))
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureValue", Namespace);
                writer.WriteString(DigitalSignatureValue);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
