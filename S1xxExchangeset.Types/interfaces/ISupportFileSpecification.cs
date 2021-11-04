namespace S1xxExchangeset.Types.interfaces
{
    public interface ISupportFileSpecification : IComplexType
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Date { get; set; }
    }
}
