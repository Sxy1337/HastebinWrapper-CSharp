/*

Simple C# wrapper for Hastebin/Toptal API.
2022-07-02


*/




namespace HastebinApi
{
    public static class Api
    {

      
        public static string CreatePaste(string data)
        {
            string start = "{"+"\"" + "key"+ "\"" + ":" + "\"";
            string end = "\""+"}";
            string UrlTemplate = "https://www.toptal.com/developers/hastebin/";
            try
            {
             var url = "https://www.toptal.com/developers/hastebin/documents";
            var response = HttpWrap.PostAsync(url, data);
            //var responseObject = JsonConvert.DeserializeObject<dynamic>(response);
           // var key = responseObject.key;
            return UrlTemplate + response.TrimStart(start.ToCharArray()).TrimEnd(end.toCharArray());
            }
            catch (Exception e)
            {
                return e.Message;
            }
            }

            
            


            



        }
    }