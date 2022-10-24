using S1xxExchangeset.Types.interfaces;

namespace S1xxExchangeset.Types.interfaces
{
    public interface ICIResponsibility : IComplexType
    {
        IParty[] Party { get; set; }
        IRole Role { get; set; }
    }
}