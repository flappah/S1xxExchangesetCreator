namespace S1xxExchangeset.Types.interfaces
{
    public interface IS100_ExchangeCatalogue : IComplexType
    {
        string AlgorithmMethod { get; set; }
        bool? CompressionFlag { get; set; }
        IContact Contact { get; set; }
        string DataReplacement { get; set; }
        string ExchangeCatalogueComment { get; set; }
        string ExchangeCatalogueDescription { get; set; }
        string ExchangeCatalogueName { get; set; }
        IIdentifier Identifier { get; set; }
        string[] MetaDataLanguage { get; set; }
        bool? ReplacedData { get; set; }
        IProductSpecification ProductSpecification { get; set; }
        string SourceMedia { get; set; }

        IDatasetDiscoveryMetadata[] DatasetDiscoveryMetadata { get; set; }
        ISupportFileDiscoveryMetadata[] SupportFileDiscoveryMetaData { get; set; }
        IS100_CatalogueMetadata[] S100_CatalogueMetaData { get; set; }

    }
}