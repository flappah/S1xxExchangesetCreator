﻿namespace S1xxExchangeset.Types.interfaces
{
    public interface IS100_DatasetDiscoveryMetadata : IComplexType
    {
        string FileName { get; set; }
        string FilePath { get; set; }
        string Description { get; set; }
        string DataProtection { get; set; }
        string ProtectionScheme { get; set; }
        string DigitalSignatureReference { get; set; }
        string DigitalSignatureValue { get; set; }
        string Copyright { get; set; }
        IClassification Classification { get; set; }
        string Purpose { get; set; }
        ISpecificUsage SpecificUsage { get; set; }
        string EditionNumber { get; set; }
        string UpdateNumber { get; set; }
        string UpdateApplicationDate { get; set; }
        string IssueDate { get; set; }
        string IssueTime { get; set; }
        IProductSpecification ProductSpecification { get; set; }
        IProducingAgency ProducingAgency { get; set; }
        string OptimumDisplayScale { get; set; }
        string MaximumDisplayScale { get; set; }
        string MinimumDisplayScale { get; set; }
        string HorizontalDatumReference { get; set; }
        string HorizontalDatumValue { get; set; }
        string VerticalDatum { get; set; }
        string SoundingDatum { get; set; }
        string DataType { get; set; }
        string OtherDataTypeDescription { get; set; }
        string DataTypeVersion { get; set; }
        IDataCoverage[] DataCoverage { get; set; }
        string Comment { get; set; }
        string[] LayerID { get; set; }
        IS100_19115DatasetMetadata S100_19115DatasetMetadata { get; set; }
    }
}
