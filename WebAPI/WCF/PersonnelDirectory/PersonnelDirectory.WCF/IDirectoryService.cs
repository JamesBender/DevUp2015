using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace PersonnelDirectory.WCF
{
    [ServiceContract(Namespace = "")]
    public interface IDirectoryService
    {
        [OperationContract]
        [WebGet(UriTemplate = "People")]
        List<Person> GetPeople();

        [OperationContract]
        [WebGet(UriTemplate = "People/{userId}")]
        Person GetPerson(string userId);

        [OperationContract]
        [WebInvoke(UriTemplate = "People/", Method = "POST")]
        string PostPerson(Person person);

        [OperationContract]
        [WebInvoke(UriTemplate = "People/{userId}",
            Method = "PUT")]
        string UpdatePerson(string userId, Person person);

        [OperationContract]
        [WebInvoke(UriTemplate = "People/{userId}",
            Method = "DELETE")]
        void DeletePerson(string userId);

        [OperationContract]
        [WebGet(UriTemplate = "People/js",
            ResponseFormat = WebMessageFormat.Json)]
        List<Person> GetJsonPeople();

        [OperationContract]
        [WebGet(UriTemplate = "People/{userId}/js",
            ResponseFormat = WebMessageFormat.Json)]
        Person GetJsonPerson(string userId);

        [OperationContract]
        [WebInvoke(UriTemplate = "People/js/", Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string PostJsonPerson(Person person);

        [OperationContract]
        [WebInvoke(UriTemplate = "People/{userId}/js", Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string UpdateJsonPerson(string userId, Person person);

    }
}