using System.IO;
using System.Net;
using System.Text;

namespace HastebinApi
{
    
    public static class HttpWrap
    {
      
      
        public static string PostAsync(string url, string data)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            using (var stream = request.GetRequestStream())
            {
                var writer = new StreamWriter(stream);
                writer.Write(data);
                writer.Flush();
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }


       

 


    }
}






