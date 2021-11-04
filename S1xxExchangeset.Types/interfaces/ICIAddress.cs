namespace S1xxExchangeset.Types.interfaces
{
    public interface ICIAddress : IComplexType
    {
        string DeliveryPoint { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
    }
}
