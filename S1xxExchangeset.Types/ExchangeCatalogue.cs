using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types
{
    public class ExchangeCatalogue : ExchangeTypeBase, IExchangeCatalogue
    {
        public IIdentifier Identifier { get; set; }
        public IContact Contact { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public string MetadataLanguage { get; set; }
        public string ExchangeCatalogueName { get; set; }
        public string ExchangeCatalogueDescription { get; set; }
        public string ExchangeCatalogueComment { get; set; }
        public string CompressionFlag { get; set; }
        public string SourceMedia { get; set; }
        public string ReplacedData { get; set; }
        public IDatasetDiscoveryMetadata DatasetDiscoveryMetadata { get; set; }
        public ISupportFileDiscoveryMetadata[] SupportFileDiscoveryMetadata { get; set; }
        public IS100_CatalogueMetadata S100_CatalogueMetadata { get; set; }

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
            writer.WriteStartElement(NamespacePrefix, "S100_ExchangeCatalogue", Namespace);

            //public IIdentifier Identifier { get; set; }
            if (Identifier != null && Identifier.IsEmpty == false)
            {
                Identifier.Namespace = Namespace;
                Identifier.NamespacePrefix = NamespacePrefix;
                Identifier.WriteXml(writer);
            }

            //public IContact Contact { get; set; }
            if (Contact != null && Contact.IsEmpty == false)
            {
                Contact.Namespace = Namespace;
                Contact.NamespacePrefix = NamespacePrefix;
                Contact.WriteXml(writer);
            }

            //public IProductSpecification ProductSpecification { get; set; }
            if (ProductSpecification != null && ProductSpecification.IsEmpty == false)
            {
                ProductSpecification.Namespace = Namespace;
                ProductSpecification.NamespacePrefix = NamespacePrefix;
                ProductSpecification.WriteXml(writer);
            }

            //public string MetadataLanguage { get; set; }
            if (!String.IsNullOrEmpty(MetadataLanguage))
            {
                writer.WriteStartElement(NamespacePrefix, "metadataLanguage", Namespace);
                writer.WriteString(MetadataLanguage);
                writer.WriteEndElement();
            }

            //public string ExchangeCatalogueName { get; set; }
            if (!String.IsNullOrEmpty(ExchangeCatalogueName))
            {
                writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueName", Namespace);
                writer.WriteString(ExchangeCatalogueName);
                writer.WriteEndElement();
            }

            //public string ExchangeCatalogueDescription { get; set; }
            if (!String.IsNullOrEmpty(ExchangeCatalogueDescription))
            {
                writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueDescription", Namespace);
                writer.WriteString(ExchangeCatalogueDescription);
                writer.WriteEndElement();
            }

            //public string ExchangeCatalogueComment { get; set; }
            if (!String.IsNullOrEmpty(ExchangeCatalogueComment))
            {
                writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueComment", Namespace);
                writer.WriteString(ExchangeCatalogueComment);
                writer.WriteEndElement();
            }

            //public string CompressionFlag { get; set; }
            if (!String.IsNullOrEmpty(CompressionFlag))
            {
                writer.WriteStartElement(NamespacePrefix, "compressionFlag", Namespace);
                writer.WriteString(CompressionFlag);
                writer.WriteEndElement();
            }

            //public string SourceMedia { get; set; }
            if (!String.IsNullOrEmpty(SourceMedia))
            {
                writer.WriteStartElement(NamespacePrefix, "sourceMedia", Namespace);
                writer.WriteString(SourceMedia);
                writer.WriteEndElement();
            }

            //public string ReplacedData { get; set; }
            if (!String.IsNullOrEmpty(ReplacedData))
            {
                writer.WriteStartElement(NamespacePrefix, "replacedData", Namespace);
                writer.WriteString(ReplacedData);
                writer.WriteEndElement();
            }

            //public IDatasetDiscoveryMetadata DatasetDiscoveryMetadata { get; set; }
            if (DatasetDiscoveryMetadata != null && DatasetDiscoveryMetadata.IsEmpty == false)
            {
                DatasetDiscoveryMetadata.Namespace = Namespace;
                DatasetDiscoveryMetadata.NamespacePrefix = NamespacePrefix;
                DatasetDiscoveryMetadata.WriteXml(writer);
            }

            //public ISupportFileDiscoveryMetadata[] SupportFileDiscoveryMetadata { get; set; }
            if (SupportFileDiscoveryMetadata != null && SupportFileDiscoveryMetadata.Length > 0)
            {
                foreach (ISupportFileDiscoveryMetadata supportFileMetaData in SupportFileDiscoveryMetadata)
                {
                    if (supportFileMetaData.IsEmpty == false)
                    {
                        supportFileMetaData.Namespace = Namespace;
                        supportFileMetaData.NamespacePrefix = NamespacePrefix;
                        supportFileMetaData.WriteXml(writer);
                    }
                }
            }

            //public IS100_CatalogueMetadata S100_CatalogueMetadata { get; set; }
            if (S100_CatalogueMetadata != null && S100_CatalogueMetadata.IsEmpty == false)
            {
                S100_CatalogueMetadata.Namespace = Namespace;
                S100_CatalogueMetadata.NamespacePrefix = NamespacePrefix;
                S100_CatalogueMetadata.WriteXml(writer);
            }

            writer.WriteEndElement();
        }
    }
}