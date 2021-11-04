using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
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

            if (Identifier != null && Identifier.IsEmpty == false)
            {
                Identifier.WriteXml(writer);
            }









            writer.WriteEndElement();

        }
    }
}