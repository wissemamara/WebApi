using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RestApiPerson
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPerson" in both code and config file together.
    [ServiceContract]
    public interface IPerson
    {
        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate="findAll",ResponseFormat=WebMessageFormat.Json)]
        List<Person>findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{Id}", ResponseFormat = WebMessageFormat.Json)]
        Person find(int Id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", RequestFormat = WebMessageFormat.Json)]
        bool create(Person person);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", RequestFormat = WebMessageFormat.Json)]
        bool edit(Person person);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", RequestFormat = WebMessageFormat.Json)]
        bool delete(Person person);


    }
}
