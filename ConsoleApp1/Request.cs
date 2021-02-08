using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Request: IRequest
    {
        public static string URI { get; set; }

        public void SetURI(string uri)
        {
            URI = uri;
        }

        public string Query()
        {
            WebRequest request = WebRequest.Create(URI);
            WebResponse response = request.GetResponse();
            string responseFromServer = string.Empty;
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                responseFromServer += reader.ReadToEnd();
                // Display the content.
            }

            // Close the response.
            response.Close();
            return (responseFromServer);
        }


    }
}

