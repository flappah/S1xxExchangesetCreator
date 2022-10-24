using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    [Serializable]
    public class S100_ExchangeCatalogue : ComplexTypeBase, IS100_ExchangeCatalogue
    {       
        /// <summary>
        ///     If true, object is empy=ty
        /// </summary>
        public override bool IsEmpty => throw new NotImplementedException();

        public string AlgorithmMethod { get; set; }
        public bool? CompressionFlag { get; set; }
        public IContact Contact { get; set; }
        public string DataReplacement { get; set; }
        public string ExchangeCatalogueComment { get; set; }
        public string ExchangeCatalogueDescription { get; set; }
        public string ExchangeCatalogueName { get; set; }
        public IIdentifier Identifier { get; set; }
        public string[] MetaDataLanguage { get; set; }
        public bool? ReplacedData { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public string SourceMedia { get; set; }
        public IDatasetDiscoveryMetadata[] DatasetDiscoveryMetadata { get; set; }
        public ISupportFileDiscoveryMetadata[] SupportFileDiscoveryMetaData { get; set; }
        public IS100_CatalogueMetadata[]S100_CatalogueMetaData { get; set; }

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

            if (Identifier != null && Identifier.IsEmpty == false)
            {
                Identifier.Namespace = Namespace;
                Identifier.NamespacePrefix = NamespacePrefix;
                Identifier.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("identifier");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (Contact != null && Contact.IsEmpty == false)
            {
                Contact.Namespace = Namespace;
                Contact.NamespacePrefix = NamespacePrefix;
                Contact.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("contact");
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (ProductSpecification != null && ProductSpecification.IsEmpty == false)
            {
                ProductSpecification.Namespace = Namespace;
                ProductSpecification.NamespacePrefix = NamespacePrefix;
                ProductSpecification.WriteXml(writer);
            }

            writer.WriteStartElement("metadataLanguage");
            if (MetaDataLanguage != null && MetaDataLanguage.Length > 0)
            {
                foreach (string language in MetaDataLanguage)
                {
                    writer.WriteString(language);
                }
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueName", Namespace);
            if (String.IsNullOrEmpty(ExchangeCatalogueName) == false)
            {
                writer.WriteString(ExchangeCatalogueName);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueDescription", Namespace);
            if (String.IsNullOrEmpty (ExchangeCatalogueDescription ) == false)
            {
                writer.WriteString(ExchangeCatalogueDescription);
            }
            else
            {
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
            }
            writer.WriteEndElement();

            if (String.IsNullOrEmpty(ExchangeCatalogueComment) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "exchangeCatalogueComment", Namespace);
                writer.WriteString(ExchangeCatalogueComment);
                writer.WriteEndElement();
            }

            if (CompressionFlag != null)
            {
                writer.WriteStartElement(NamespacePrefix, "compressionFlag", Namespace);
                writer.WriteString((bool) CompressionFlag ? "true" : "false");
                writer.WriteEndElement();
            }

            //if (String.IsNullOrEmpty(AlgorithmMethod) == false)
            //{
            //    writer.WriteStartElement(NamespacePrefix, "algorithmMethod", Namespace);
            //    writer.WriteString(AlgorithmMethod);
            //    writer.WriteEndElement();
            //}

            if (String.IsNullOrEmpty(SourceMedia) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "sourceMedia", Namespace);
                writer.WriteString(SourceMedia);
                writer.WriteEndElement();
            }

            if (ReplacedData != null)
            {
                writer.WriteStartElement(NamespacePrefix, "replacedData", Namespace);
                writer.WriteString((bool)ReplacedData ? "true" : "false");
                writer.WriteEndElement();
            }

            if (String.IsNullOrEmpty(DataReplacement) == false)
            {
                writer.WriteStartElement(NamespacePrefix, "dataReplacement", Namespace);
                writer.WriteString(DataReplacement);
                writer.WriteEndElement();
            }

            if (DatasetDiscoveryMetadata != null && DatasetDiscoveryMetadata.Length > 0)
            {
                foreach (var datasetDiscoveryMetadataItem in DatasetDiscoveryMetadata)
                {
                    writer.WriteStartElement(NamespacePrefix, "datasetDiscoveryMetadata", Namespace);

                    datasetDiscoveryMetadataItem.Namespace = Namespace;
                    datasetDiscoveryMetadataItem.NamespacePrefix = NamespacePrefix;
                    datasetDiscoveryMetadataItem.WriteXml(writer);

                    writer.WriteEndElement();
                }
            }

            if (SupportFileDiscoveryMetaData != null && SupportFileDiscoveryMetaData.Length > 0)
            {
                foreach(ISupportFileDiscoveryMetadata supportFileMetaDataItem in SupportFileDiscoveryMetaData)
                {
                    supportFileMetaDataItem.Namespace = Namespace;
                    supportFileMetaDataItem.NamespacePrefix = NamespacePrefix;
                    supportFileMetaDataItem.WriteXml(writer);
                }
            }

            if (S100_CatalogueMetaData != null)
            {
                foreach(IS100_CatalogueMetadata catalogueMetaDataItem in S100_CatalogueMetaData)
                {
                    catalogueMetaDataItem.Namespace = Namespace;
                    catalogueMetaDataItem.NamespacePrefix = NamespacePrefix;
                    catalogueMetaDataItem.WriteXml(writer);
                }
            }

            writer.WriteEndElement();
        }
    }
}
