namespace S1xxExchangeset.Types.interfaces
{
    public interface IIdentifier : IComplexType
    {
        string Ident { get; set; }
        string EditionNumber { get; set; }
        string Date { get; set; }
    }
}
