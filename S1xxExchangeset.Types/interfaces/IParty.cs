namespace S1xxExchangeset.Types.interfaces
{
    public interface IParty : IComplexType
    {
        ICIOrganisation Organisation { get; set; }
    }
}