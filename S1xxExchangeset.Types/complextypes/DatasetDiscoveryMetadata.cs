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
        public IClassification Classification { get; set; }
        public string Purpose { get; set; }
        public ISpecificUsage SpecificUsage { get; set; }
        public string EditionNumber { get; set; }
        public string UpdateApplicationDate { get; set; }
        public string IssueDate { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public IProducingAgency ProducingAgency {get;set;}
        public string MaximumDisplayScale { get; set; }
        public string MinimumDisplayScale { get; set; }
        public string HorizontalDatumReference { get; set; }
        public string HorizontalDatumValue { get; set; }
        public string VerticalDatum { get; set; }
        public string SoundingDatum { get; set; }
        public string DataType { get; set; }
        public string DataTypeVersion { get; set; }
        public IDataCoverage DataCoverage { get; set; }
        public string Comment { get; set; }
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
                    (DataCoverage == null || DataCoverage.IsEmpty) &&
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
            if (!String.IsNullOrEmpty(FileName))
            {
                writer.WriteStartElement(NamespacePrefix, "fileName", Namespace);
                writer.WriteString(FileName);
                writer.WriteEndElement();
            }

            //public string FilePath { get; set; }
            if (!String.IsNullOrEmpty(FilePath))
            {
                writer.WriteStartElement(NamespacePrefix, "filePath", Namespace);
                writer.WriteString(FilePath);
                writer.WriteEndElement();
            }

            //public string Description { get; set; }
            if (!String.IsNullOrEmpty(Description))
            {
                writer.WriteStartElement(NamespacePrefix, "description", Namespace);
                writer.WriteString(Description);
                writer.WriteEndElement();
            }

            //public string DataProtection { get; set; }
            if (!String.IsNullOrEmpty(DataProtection))
            {
                writer.WriteStartElement(NamespacePrefix, "dataProtection", Namespace);
                writer.WriteString(DataProtection);
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
            if (!String.IsNullOrEmpty(Purpose))
            {
                writer.WriteStartElement(NamespacePrefix, "purpose", Namespace);
                writer.WriteString(Purpose);
                writer.WriteEndElement();
            }

            //public ISpecificUsage SpecificUsage { get; set; }
            if (SpecificUsage != null && SpecificUsage.IsEmpty == false)
            {
                SpecificUsage.Namespace = Namespace;
                SpecificUsage.NamespacePrefix = NamespacePrefix;
                SpecificUsage.WriteXml(writer);
            }

            //public string EditionNumber { get; set; }
            if (!String.IsNullOrEmpty(EditionNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "editionNumber", Namespace);
                writer.WriteString(EditionNumber);
                writer.WriteEndElement();
            }

            //public string UpdateApplicationDate { get; set; }
            if (!String.IsNullOrEmpty(UpdateApplicationDate))
            {
                writer.WriteStartElement(NamespacePrefix, "updateApplicationDate", Namespace);
                writer.WriteString(UpdateApplicationDate);
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
                ProductSpecification.Namespace = Namespace;
                ProductSpecification.NamespacePrefix = NamespacePrefix;
                ProductSpecification.WriteXml(writer);
            }

            //public IProducingAgency ProducingAgency { get; set; }
            if (ProducingAgency != null && ProducingAgency.IsEmpty == false)
            {
                ProducingAgency.Namespace = Namespace;
                ProducingAgency.NamespacePrefix = NamespacePrefix;
                ProducingAgency.WriteXml(writer);
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
            if (!String.IsNullOrEmpty(HorizontalDatumReference))
            {
                writer.WriteStartElement(NamespacePrefix, "horizontalDatumReference", Namespace);
                writer.WriteString(HorizontalDatumReference);
                writer.WriteEndElement();
            }

            //public string HorizontalDatumValue { get; set; }
            if (!String.IsNullOrEmpty(HorizontalDatumValue))
            {
                writer.WriteStartElement(NamespacePrefix, "horizontalDatumValue", Namespace);
                writer.WriteString(HorizontalDatumValue);
                writer.WriteEndElement();
            }

            //public string VerticalDatum { get; set; }
            if (!String.IsNullOrEmpty(VerticalDatum))
            {
                writer.WriteStartElement(NamespacePrefix, "verticalDatum", Namespace);
                writer.WriteString(VerticalDatum);
                writer.WriteEndElement();
            }

            //public string SoundingDatum { get; set; }
            if (!String.IsNullOrEmpty(SoundingDatum))
            {
                writer.WriteStartElement(NamespacePrefix, "soundingDatum", Namespace);
                writer.WriteString(SoundingDatum);
                writer.WriteEndElement();
            }

            //public string DataType { get; set; }
            if (!String.IsNullOrEmpty(DataType))
            {
                writer.WriteStartElement(NamespacePrefix, "dataType", Namespace);
                writer.WriteString(DataType);
                writer.WriteEndElement();
            }

            //public string DataTypeVersion { get; set; }
            if (!String.IsNullOrEmpty(DataTypeVersion))
            {
                writer.WriteStartElement(NamespacePrefix, "dataTypeVersion", Namespace);
                writer.WriteString(DataTypeVersion);
                writer.WriteEndElement();
            }

            //public IDataCoverage DataCoverage { get; set; }
            if (DataCoverage != null && DataCoverage.IsEmpty == false)
            {
                DataCoverage.Namespace = Namespace;
                DataCoverage.NamespacePrefix = NamespacePrefix;
                DataCoverage.WriteXml(writer);
            }

            //public string Comment { get; set; }
            if (!String.IsNullOrEmpty(Comment))
            {
                writer.WriteStartElement(NamespacePrefix, "comment", Namespace);
                writer.WriteString(Comment);
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
