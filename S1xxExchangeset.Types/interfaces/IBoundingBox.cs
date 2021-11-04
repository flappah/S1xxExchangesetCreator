namespace S1xxExchangeset.Types.interfaces
{
    public interface IBoundingBox : IComplexType
    {
        double WestBoundLongitude { get; set; }
        double EastBoundLongitude { get; set; }
        double SouthBoundLatitude { get; set; }
        double NorthBoundLatitude { get; set; }
    }
}
