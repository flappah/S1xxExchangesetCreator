namespace S1xxExchangeset.Types.interfaces
{
    public interface IDatasetDiscoveryMetadata : IComplexType
    {
         string FileName { get; set; }
         string FilePath { get; set; }
         string Description { get; set; }
         string DataProtection { get; set; }
         IClassification Classification { get; set; }
         string Purpose { get; set; }
         ISpecificUsage SpecificUsage { get; set; }
         string EditionNumber { get; set; }
         string UpdateApplicationDate { get; set; }
         string IssueDate { get; set; }
         IProductSpecification ProductSpecification { get; set; }
         IProducingAgency ProducingAgency { get; set; }
         string MaximumDisplayScale { get; set; }
         string MinimumDisplayScale { get; set; }
         string HorizontalDatumReference { get; set; }
         string HorizontalDatumValue { get; set; }
         string VerticalDatum { get; set; }
         string SoundingDatum { get; set; }
         string DataType { get; set; }
         string DataTypeVersion { get; set; }
         IDataCoverage DataCoverage { get; set; }
         string Comment { get; set; }
         IS100_19115DatasetMetadata S100_19115DatasetMetadata { get; set; }
    }
}
