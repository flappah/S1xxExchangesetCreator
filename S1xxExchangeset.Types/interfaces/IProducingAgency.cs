namespace S1xxExchangeset.Types.interfaces
{
    public interface IProducingAgency : IComplexType
    {
        string OrganisationName { get; set; }
        IContactInfo ContactInfo { get; set; }
        IRole[] Roles { get; set; }
    }
}
