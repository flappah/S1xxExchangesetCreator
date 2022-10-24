using S1xxExchangeset.Types.complextypes;

namespace S1xxExchangeset.Types.interfaces
{
    public interface IS100_CatalogueMetadata : IComplexType
    {
        string[] FileName { get; set; }
        string[] FileLocation { get; set; }
        string[] Scope { get; set; }
        string[] VersionNumber { get; set; }
        string[] IssueDate { get; set; }
        IProductSpecification[] ProductSpecification { get; set; }
        string DigitalSignatureReferences { get; set; }
        string DigitalSignatureValue { get; set; }
        PTLocale DefaultLocale { get; set; }
        PTLocale OtherLocale { get; set; }
    }
}
