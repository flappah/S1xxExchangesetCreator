namespace S1xxExchangeset.Types.interfaces
{
    public interface IProductSpecification :IComplexType
    {
        string Name { get; set; }
        string Version { get; set; }
        string Date { get; set; }
    }
}
