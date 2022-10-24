using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class S100_CatalogueMetadata : ComplexTypeBase, IS100_CatalogueMetadata
    {
        public string[] FileName { get; set; }
        public string[] FileLocation { get; set; }
        public string[] Scope { get; set; }
        public string[] VersionNumber { get; set; }
        public string[] IssueDate { get; set; }
        public IProductSpecification[] ProductSpecification { get; set; }
        public string DigitalSignatureReferences { get; set; }
        public string DigitalSignatureValue { get; set; }
        public PTLocale DefaultLocale { get; set; }
        public PTLocale OtherLocale { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get {
                return (FileName == null || FileName.Length == 0) &&
                    (FileLocation == null || FileLocation.Length == 0) &&
                    (Scope == null || Scope.Length == 0) &&
                    (VersionNumber == null || VersionNumber.Length == 0) &&
                    (IssueDate == null || IssueDate.Length == 0) &&
                    (ProductSpecification == null || ProductSpecification.Length == 0) &&
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

            foreach (string fileNameItem in FileName)
            {
                writer.WriteStartElement(NamespacePrefix, "fileName", Namespace);
                if (String.IsNullOrEmpty(fileNameItem) == false)
                {
                    writer.WriteString(fileNameItem);
                }
                else
                {
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                }
                writer.WriteEndElement();
            }

            foreach (string fileLocationItem in FileLocation)
            {
                writer.WriteStartElement(NamespacePrefix, "fileLocation", Namespace);
                if (String.IsNullOrEmpty(fileLocationItem) == false)
                {
                    writer.WriteString(fileLocationItem);
                }
                else
                {
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                }
                writer.WriteEndElement();
            }

            foreach (string scopeItem in Scope)
            {
                writer.WriteStartElement(NamespacePrefix, "scope", Namespace);
                if (String.IsNullOrEmpty(scopeItem) == false)
                {
                    writer.WriteString(scopeItem);
                }
                else
                {
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                }
                writer.WriteEndElement();
            }

            foreach (string versionNumberItem in VersionNumber)
            {
                writer.WriteStartElement(NamespacePrefix, "versionNumber", Namespace);
                if (String.IsNullOrEmpty(versionNumberItem) == false)
                {
                    writer.WriteString(versionNumberItem);
                }
                else
                {
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                }
                writer.WriteEndElement();
            }

            foreach (string issueDateItem in IssueDate)
            {
                writer.WriteStartElement(NamespacePrefix, "issueDate", Namespace);
                if (String.IsNullOrEmpty(issueDateItem) == false)
                {
                    writer.WriteString(issueDateItem);

                    if (DateTime.TryParse(issueDateItem, out DateTime issuedateValue))
                    {
                        writer.WriteString(issuedateValue.ToString("yyyy-MM-dd"));
                    }
                }
                else
                {
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                }
                writer.WriteEndElement();
            }

            foreach (IProductSpecification productSpecificationItem in ProductSpecification)
            {
                if (productSpecificationItem != null && productSpecificationItem.IsEmpty == false)
                {
                    productSpecificationItem.WriteXml(writer);
                }
                else
                {
                    writer.WriteStartElement(NamespacePrefix, "productSpecification", Namespace);
                    writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
                    writer.WriteEndElement();
                }
            }

            if (String.IsNullOrEmpty(DigitalSignatureReferences) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureReference", Namespace);
                writer.WriteString(DigitalSignatureReferences);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(DigitalSignatureValue) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignatureValue", Namespace);
                writer.WriteString(DigitalSignatureValue);
                writer.WriteEndElement();
            }

            writer.WriteStartElement(NamespacePrefix, "defaultLocale", Namespace);
            if (DefaultLocale != null)
            {
                DefaultLocale.WriteXml(writer);
            }
            else
            {
                writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
            }
            writer.WriteEndElement();

            if (OtherLocale != null)
            {
                writer.WriteStartElement(NamespacePrefix, "otherLocale", Namespace);
                OtherLocale.WriteXml(writer);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
