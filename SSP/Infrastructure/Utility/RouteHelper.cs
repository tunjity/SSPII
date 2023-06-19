using ExcelDataReader.Log;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using System.Text;

namespace SSP.Infrastructure.Utility
{

    public class RouteHelper
    {
        public static string ProxyHelper(ApiLinkDTO payload)
        {
            var response = string.Empty;
            Dictionary<string, string> headers = null;
            try
            {
                if (string.IsNullOrWhiteSpace(payload.method))
                    return response;

                if (!string.IsNullOrWhiteSpace(payload.headers))
                {
                    headers = JsonConvert.DeserializeObject<Dictionary<string, string>>(payload.headers);
                }
                payload.method = payload.method.ToUpper();
                var clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
                };

                using (var _client = new HttpClient(clientHandler))
                {
                    #region header_initialize:

                    _client.DefaultRequestHeaders.Accept.Clear();
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            _client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }

                    #endregion

                    HttpResponseMessage resp;
                    switch (payload.method)
                    {
                        case "POST":

                            var content = new StringContent(payload.body, Encoding.UTF8, "application/json");
                            resp = _client.PostAsync(payload.final_url, content).Result;
                            if (resp.StatusCode == HttpStatusCode.OK)
                            {
                                response = resp.Content.ReadAsStringAsync().Result;
                            }
                            break;

                        case "GET":
                            resp = _client.GetAsync(payload.final_url).Result;
                            if (resp.StatusCode == HttpStatusCode.OK)
                            {
                                response = resp.Content.ReadAsStringAsync().Result;
                            }
                            break;
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
              //  LogManager.SendErrorToText(ex);
                return response;
            }

        }
    }

    public class ApiLinkDTO
    {
        public string method { get; set; }
        public string final_url { get; set; }
        public string headers { get; set; }
        public string body { get; set; }
    }
}
