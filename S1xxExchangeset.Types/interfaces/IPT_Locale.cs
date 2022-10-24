namespace S1xxExchangeset.Types.interfaces
{
    public interface IPT_Locale : IComplexType
    {
        string CharacterEncoding { get; set; }
        string Country { get; set; }
        string Language { get; set; }

    }
}