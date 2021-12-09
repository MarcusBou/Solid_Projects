using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace AWebsite
{
    class WebReader: IDataReader
    {
        WebRequest request;
        WebResponse response;


        public void CreateRequest(string path)
        {
            request = WebRequest.Create(path);
            request.Credentials = CredentialCache.DefaultCredentials;
        }

        public void GetResponse()
        {
            response = request.GetResponse();
        }

        public string GetResponseString()
        {
            string serverResponse;

            using (Stream dataStream = response.GetResponseStream())
            
                StreamReader reader = new StreamReader(dataStream);
                serverResponse = reader.ReadToEnd();
            }
            response.Close();
            return serverResponse;
        }
    }
}
