using System.ServiceModel;

namespace Try.Dotnet.Roslyn.Source
{
    /// <summary>
    /// Property services contract
    /// </summary>
    [ServiceContract]
    public interface IPropertyServices
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        Property GetProperty(Credentials credentials, int id);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void AddProperty(Credentials credentials, Property property);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void UpdateProperty(Credentials credentials, Property property);

        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        void DeleteProperty(Credentials credentials, int id);
    }
}