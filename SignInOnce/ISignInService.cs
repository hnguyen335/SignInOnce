using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SignInOnce
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISignInService" in both code and config file together.
    [ServiceContract]
    public interface ISignInService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        SignInStatus SignIn(string Connector, string Login, string Password);
        /*
        [OperationContract]
        [WebGet]
        FolderStatus GetFolders(string AccessToken);

        [OperationContract]
        [WebInvoke]
        string UploadFile(string AccessToken, string FolderName, string Filenames, Boolean Override);
        */
        [OperationContract]
        [WebGet]
        string EchoWithGet(string s);

        [OperationContract]
        [WebInvoke]
        string EchoWithPost(string s);
    }

    [DataContract]
    public class SignInStatus
    {      

        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public string Status { get; set; }
    }

    [DataContract]
    public class FolderStatus
    {        
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string[] Folder { get; set; }

       
    }
}
