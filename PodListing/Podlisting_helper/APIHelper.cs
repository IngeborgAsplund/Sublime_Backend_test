using System.Net.Http.Headers;

namespace Podlisting_helper
{
    /// <summary>
    /// This class is used to fire up the connection with the API and help fetch the pods via the API endpoint for Sweden radio
    /// open API it initialize a 
    /// </summary>
    public static class APIHelper
    {
        public static HttpClient APIClient { get; set; }

        public static void Initialize()
        {
            APIClient = new HttpClient();
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}