using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class DatasetDiscoveryMetadata : ComplexTypeBase, IDatasetDiscoveryMetadata
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string DataProtection { get; set; }
        public string ProtectionScheme { get; set; }
        public string DigitalSignature { get; set; }
        public string DigitalSignatureReference { get; set; }
        public string DigitalSignatureValue { get; set; }
        public string Copyright { get; set; }
        public IClassification Classification { get; set; }
        public string Purpose { get; set; }
        public ISpecificUsage SpecificUsage { get; set; }
        public string EditionNumber { get; set; }
        public string UpdateNumber { get; set; }
        public string UpdateApplicationDate { get; set; }
        public string IssueDate { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public IProducingAgency ProducingAgency {get;set;}
        public string OptimumDisplayScale { get; set; }
        public string MaximumDisplayScale { get; set; }
        public string MinimumDisplayScale { get; set; }
        public string HorizontalDatumReference { get; set; }
        public string HorizontalDatumValue { get; set; }
        public string VerticalDatum { get; set; }
        public string SoundingDatum { get; set; }
        public string DataType { get; set; }
        public string OtherDataTypeDescription { get; set; }
        public string DataTypeVersion { get; set; }
        public IDataCoverage[] DataCoverage { get; set; }
        public string Comment { get; set; }
        public string[] LayerID { get; set; }
        public IS100_19115DatasetMetadata S100_19115DatasetMetadata { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(FileName) &&
                    String.IsNullOrEmpty(FilePath) &&
                    String.IsNullOrEmpty(Description) &&
                    String.IsNullOrEmpty(DataProtection) &&
                    (Classification == null || Classification.IsEmpty) &&
                    String.IsNullOrEmpty(Purpose) &&
                    (SpecificUsage == null || SpecificUsage.IsEmpty) &&
                    String.IsNullOrEmpty(EditionNumber) &&
                    String.IsNullOrEmpty(UpdateApplicationDate) &&
                    String.IsNullOrEmpty(IssueDate) &&
                    (ProductSpecification == null || ProductSpecification.IsEmpty) &&
                    (ProducingAgency == null || ProducingAgency.IsEmpty) &&
                    String.IsNullOrEmpty(MaximumDisplayScale) &&
                    String.IsNullOrEmpty(MinimumDisplayScale) &&
                    String.IsNullOrEmpty(HorizontalDatumReference) &&
                    String.IsNullOrEmpty(HorizontalDatumValue) &&
                    String.IsNullOrEmpty(VerticalDatum) &&
                    String.IsNullOrEmpty(SoundingDatum) &&
                    String.IsNullOrEmpty(DataType) &&
                    String.IsNullOrEmpty(DataTypeVersion) &&
                    (DataCoverage == null || DataCoverage.Length == 0) &&
                    String.IsNullOrEmpty(Comment) &&
                    (S100_19115DatasetMetadata == null || S100_19115DatasetMetadata.IsEmpty);
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
            writer.WriteStartElement(NamespacePrefix, "fileName", Namespace);
            if (String.IsNullOrEmpty(FileName) == false)
            {
                writer.WriteString(FileName);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string FilePath { get; set; }
            writer.WriteStartElement(NamespacePrefix, "filePath", Namespace);
            if (String.IsNullOrEmpty(FilePath) == false)
            {
                writer.WriteString(FilePath);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string Description { get; set; }
            writer.WriteStartElement(NamespacePrefix, "description", Namespace);
            if (String.IsNullOrEmpty(Description) == false)
            {
                writer.WriteString(Description);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string DataProtection { get; set; }
            if (String.IsNullOrEmpty(DataProtection) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "dataProtection", Namespace);
                writer.WriteString(DataProtection);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(ProtectionScheme) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "protectionScheme", Namespace);
                writer.WriteString(ProtectionScheme);
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(DigitalSignature) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "digitalSignature", Namespace);
                writer.WriteString(DigitalSignature);
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

            if (String.IsNullOrEmpty(Copyright) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "copyright", Namespace);
                writer.WriteString(Copyright);
                writer.WriteEndElement();
            }

            //public IClassification Classification { get; set; }
            if (Classification != null && Classification.IsEmpty == false)
            {
                Classification.Namespace = Namespace;
                Classification.NamespacePrefix = NamespacePrefix;
                Classification.WriteXml(writer);
            }

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

            //public ISpecificUsage SpecificUsage { get; set; }
            if (SpecificUsage != null && SpecificUsage.IsEmpty == false)
            {
                SpecificUsage.Namespace = Namespace;
                SpecificUsage.NamespacePrefix = NamespacePrefix;
                SpecificUsage.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "specificUsage", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

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

            if (!String.IsNullOrEmpty(UpdateNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "updateNumber", Namespace);
                writer.WriteString(UpdateNumber);
                writer.WriteEndElement();
            }

            //public string UpdateApplicationDate { get; set; }
            if (!String.IsNullOrEmpty(UpdateApplicationDate) &&
                DateTime.TryParse(UpdateApplicationDate, out DateTime updateApplicationDate))
            {
                writer.WriteStartElement(NamespacePrefix, "updateApplicationDate", Namespace);
                writer.WriteString(updateApplicationDate.ToString("yyyy-MM-dd"));
                writer.WriteEndElement();
            }

            //public string IssueDate { get; set; }
            writer.WriteStartElement(NamespacePrefix, "issueDate", Namespace);
            if (!String.IsNullOrEmpty(IssueDate) &&
                DateTime.TryParse(IssueDate, out DateTime issuedateValue))
            {
                writer.WriteString(issuedateValue.ToString("yyyy-MM-dd"));
            }
            else
            {
                writer.WriteStartElement("issueDate");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            //public IProductSpecification ProductSpecification { get; set; }
            if (ProductSpecification != null && ProductSpecification.IsEmpty == false)
            {
                ProductSpecification.Namespace = Namespace;
                ProductSpecification.NamespacePrefix = NamespacePrefix;
                ProductSpecification.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("productSpecification");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            //public IProducingAgency ProducingAgency { get; set; }
            if (ProducingAgency != null && ProducingAgency.IsEmpty == false)
            {
                ProducingAgency.Namespace = Namespace;
                ProducingAgency.NamespacePrefix = NamespacePrefix;
                ProducingAgency.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("producingAgency");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(OptimumDisplayScale) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "optimumDisplayScale", Namespace);
                writer.WriteString(OptimumDisplayScale);
                writer.WriteEndElement();
            }

            //public string MaximumDisplayScale { get; set; }
            if (!String.IsNullOrEmpty(MaximumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "maximumDisplayScale", Namespace);
                writer.WriteString(MaximumDisplayScale);
                writer.WriteEndElement();
            }

            //public string MinimumDisplayScale { get; set; }
            if (!String.IsNullOrEmpty(MinimumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "minimumDisplayScale", Namespace);
                writer.WriteString(MinimumDisplayScale);
                writer.WriteEndElement();
            }

            //public string HorizontalDatumReference { get; set; }
            writer.WriteStartElement(NamespacePrefix, "horizontalDatumReference", Namespace);
            if (!String.IsNullOrEmpty(HorizontalDatumReference))
            {
                writer.WriteString(HorizontalDatumReference);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string HorizontalDatumValue { get; set; }
            writer.WriteStartElement(NamespacePrefix, "horizontalDatumValue", Namespace);
            if (!String.IsNullOrEmpty(HorizontalDatumValue))
            {
                writer.WriteString(HorizontalDatumValue);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string VerticalDatum { get; set; }
            writer.WriteStartElement(NamespacePrefix, "verticalDatum", Namespace);
            if (!String.IsNullOrEmpty(VerticalDatum))
            {
                writer.WriteString(VerticalDatum);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            //public string SoundingDatum { get; set; }
            writer.WriteStartElement(NamespacePrefix, "soundingDatum", Namespace);
            if (!String.IsNullOrEmpty(SoundingDatum))
            {
                writer.WriteString(SoundingDatum);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

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

            //public string DataTypeVersion { get; set; }
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

            //public IDataCoverage[] DataCoverage { get; set; }
            if (DataCoverage != null && DataCoverage.Length > 0)
            {
                foreach(IDataCoverage datacoverage in DataCoverage)
                {
                    datacoverage.Namespace = Namespace;
                    datacoverage.NamespacePrefix = NamespacePrefix;
                    datacoverage.WriteXml(writer);
                }
            }

            //public string Comment { get; set; }
            if (!String.IsNullOrEmpty(Comment))
            {
                writer.WriteStartElement(NamespacePrefix, "comment", Namespace);
                writer.WriteString(Comment);
                writer.WriteEndElement();
            }

            if (LayerID != null && LayerID.Length > 0)
            {
                foreach (string layerId in LayerID)
                {
                    writer.WriteStartElement(NamespacePrefix, "layerID", Namespace);
                    writer.WriteString(layerId);
                    writer.WriteEndElement();
                }
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "layerID", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            //public IS100_19115DatasetMetadata S100_19115DatasetMetadata { get; set; }
            if (S100_19115DatasetMetadata != null && S100_19115DatasetMetadata.IsEmpty == false)
            {
                S100_19115DatasetMetadata.Namespace = Namespace;
                S100_19115DatasetMetadata.NamespacePrefix = NamespacePrefix;
                S100_19115DatasetMetadata.WriteXml(writer);
            }

            writer.WriteEndElement();
        }
    }
}
