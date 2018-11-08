using Try.Dotnet.Roslyn.Sources.Attributes;

namespace Try.Dotnet.Roslyn.Sources
{
    /// <summary>
    /// Property services contract
    /// </summary>
    [ServiceContract]
    public interface IPropertyServices
    {
        [OperationContract]
        Property GetProperty(Credentials credentials, int id);

        [OperationContract]
        void AddProperty(Credentials credentials, Property property);

        [OperationContract]
        void UpdateProperty(Credentials credentials, Property property);

        [OperationContract]
        void DeleteProperty(Credentials credentials, int id);
    }
}