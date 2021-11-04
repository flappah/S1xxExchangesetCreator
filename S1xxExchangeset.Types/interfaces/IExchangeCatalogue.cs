namespace S1xxExchangeset.Types.interfaces
{
    public interface IExchangeCatalogue : IExchangeType
	{
		IIdentifier Identifier { get; set; }
		IContact Contact { get; set; }
		IProductSpecification ProductSpecification { get; set; }
		string MetadataLanguage { get; set; }
		string ExchangeCatalogueName { get; set; }
		string ExchangeCatalogueDescription { get; set; }
		string ExchangeCatalogueComment { get; set; }
		string CompressionFlag { get; set; }
		string SourceMedia { get; set; }
		string ReplacedData { get; set; }
		IDatasetDiscoveryMetadata DatasetDiscoveryMetadata { get; set; }
		ISupportFileDiscoveryMetadata[] SupportFileDiscoveryMetadata { get; set; }
		IS100_CatalogueMetadata S100_CatalogueMetadata { get; set; }
	}
}
