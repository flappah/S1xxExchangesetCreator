namespace S1xxExchangeset.Types.interfaces
{
    public interface IDataCoverage : IComplexType
    {
        IBoundingBox BoundingBox { get; set; }
        string BoundingPolygon { get; set; }
        string OptimumDisplayScale { get; set; }
        string MaximumDisplayScale { get; set; }
        string MinimumDisplayScale { get; set; }
    }
}
