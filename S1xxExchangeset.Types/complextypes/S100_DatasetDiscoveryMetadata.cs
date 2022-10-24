using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class S100_DatasetDiscoveryMetadata : ComplexTypeBase, IS100_DatasetDiscoveryMetadata
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string DataProtection { get; set; }
        public string ProtectionScheme { get; set; }
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
        public string IssueTime { get; set; }
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
        public IPT_Locale DefaultLocale { get; set; }
        public IPT_Locale OtherLocale { get; set; }
        public string MetadataFileIdentifier { get; set; }
        public 
        public string MetadataDateStamp { get; set; }

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
            writer.WriteStartElement(NamespacePrefix, "S100_DatasetDiscoveryMetadata", Namespace);

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

            writer.WriteStartElement(NamespacePrefix, "digitalSignatureReference", Namespace);
            if (String.IsNullOrEmpty(DigitalSignatureReference) == false)
            {
                writer.WriteString(DigitalSignatureReference);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            writer.WriteStartElement(NamespacePrefix, "digitalSignatureValue", Namespace);
            if (String.IsNullOrEmpty(DigitalSignatureValue) == false)
            {
                writer.WriteString(DigitalSignatureValue);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (String.IsNullOrEmpty(Copyright) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "copyright", Namespace);
                writer.WriteString(Copyright);
                writer.WriteEndElement();
            }

            if (Classification != null && Classification.IsEmpty == false)
            {
                Classification.Namespace = Namespace;
                Classification.NamespacePrefix = NamespacePrefix;
                Classification.WriteXml(writer);
            }

            if (!String.IsNullOrEmpty(Purpose))
            {
                writer.WriteStartElement(NamespacePrefix, "purpose", Namespace);
                writer.WriteString(Purpose);
                writer.WriteEndElement();
            }

            if (SpecificUsage != null && SpecificUsage.IsEmpty == false)
            {
                SpecificUsage.Namespace = Namespace;
                SpecificUsage.NamespacePrefix = NamespacePrefix;
                SpecificUsage.WriteXml(writer);
            }

            if (!String.IsNullOrEmpty(EditionNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "editionNumber", Namespace);
                writer.WriteString(EditionNumber);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(UpdateNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "updateNumber", Namespace);
                writer.WriteString(UpdateNumber);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(UpdateApplicationDate) &&
                DateTime.TryParse(UpdateApplicationDate, out DateTime updateApplicationDate))
            {
                writer.WriteStartElement(NamespacePrefix, "updateApplicationDate", Namespace);
                writer.WriteString(updateApplicationDate.ToString("yyyy-MM-dd"));
                writer.WriteEndElement();
            }

            writer.WriteStartElement(NamespacePrefix, "issueDate", Namespace);
            if (!String.IsNullOrEmpty(IssueDate) &&
                DateTime.TryParse(IssueDate, out DateTime issueDateValue))
            {
                writer.WriteString(issueDateValue.ToString("yyyy-MM-dd"));
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            writer.WriteStartElement(NamespacePrefix, "issueTime", Namespace);
            if (!String.IsNullOrEmpty(IssueTime) &&
                DateTime.TryParse(IssueTime, out DateTime issueTimeValue))
            {
                writer.WriteString(issueTimeValue.ToString("HH:mm:ss"));
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (ProductSpecification != null && ProductSpecification.IsEmpty == false)
            {
                ProductSpecification.Namespace = Namespace;
                ProductSpecification.NamespacePrefix = NamespacePrefix;
                ProductSpecification.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "productSpecification", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (ProducingAgency != null && ProducingAgency.IsEmpty == false)
            {
                ProducingAgency.Namespace = Namespace;
                ProducingAgency.NamespacePrefix = NamespacePrefix;
                ProducingAgency.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "producingAgency", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(OptimumDisplayScale) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "optimumDisplayScale", Namespace);
                writer.WriteString(OptimumDisplayScale);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(MaximumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "maximumDisplayScale", Namespace);
                writer.WriteString(MaximumDisplayScale);
                writer.WriteEndElement();
            }

            if (!String.IsNullOrEmpty(MinimumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "minimumDisplayScale", Namespace);
                writer.WriteString(MinimumDisplayScale);
                writer.WriteEndElement();
            }

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

            if (DataCoverage != null && DataCoverage.Length > 0)
            {
                foreach(IDataCoverage datacoverage in DataCoverage)
                {
                    datacoverage.Namespace = Namespace;
                    datacoverage.NamespacePrefix = NamespacePrefix;
                    datacoverage.WriteXml(writer);
                }
            }

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
