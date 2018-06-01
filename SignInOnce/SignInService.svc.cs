using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace SignInOnce
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SignInService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SignInService.svc or SignInService.svc.cs at the Solution Explorer and start debugging.
    public class SignInService : ISignInService
    {       
        public SignInStatus SignIn(string Connector, string Login, string Password)
        
        {               
            SignInStatus status = new SignInStatus();
            status.Status = "-1";
            status.AccessToken = "";

            if (Connector != null && Login != null && Password != null)
            {
                if (Connector.Equals("GoogleDrive") && Login.Equals("user@gmail.com") && Password.Equals("123456"))
                {
                    status.Status = "Ok";
                    status.AccessToken = "12345678990abcdefgh";
                }
            }

            // Serialize the results as JSON
           // DataContractJsonSerializer serializer = new DataContractJsonSerializer(status.GetType());
          //  MemoryStream memoryStream = new MemoryStream();
          //  serializer.WriteObject(memoryStream, status);

            // Return the results serialized as JSON
           // string json = Encoding.Default.GetString(memoryStream.ToArray());
            return status;
            
        }
        /*
        public FolderStatus GetFolders(string AccessToken)
        {
            FolderStatus status = new FolderStatus();
            status.Folder = new string[2];
            status.Status = "-1";

            if (AccessToken != null)
            {
                if (AccessToken.Equals("1234"))
                {
                    status.Status = "Ok";
                    status.Folder[0] = "folder1";
                    status.Folder[1] = "folder2";
                }
            }
            return status;
        }

        public string UploadFile(string AccessToken, string FolderName, string Filenames, Boolean Override)
        {
            string status = "-1";

            if (AccessToken != null)
            {
                if (AccessToken.Equals("1234"))
                {
                    status = "Ok";                   
                }
            }
            return status;
        }*/

        public string EchoWithGet(string s)
        {
            return "Huy GET said " + s;
        }

        public string EchoWithPost(string s)
        {
            return "Huy POST said " + s;
        }
    }
}
