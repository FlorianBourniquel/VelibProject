using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace ServerSoapVelib
{
    public class Velib : IVelib
    {
        public List<Ville> GetVille()
        {
            var request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts?apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
            // Get the response.
            var response = request.GetResponse();
            // Get the stream containing content returned by the server.
            var dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(dataStream);
            // Read the content.  
            var responseFromServer = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Ville>>(responseFromServer);
        }
    }
}