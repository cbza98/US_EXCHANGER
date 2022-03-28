using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace US_EXCHANGER.Helpers
{
    public class RestCall
    {
        public static IRestResponse RequestUS(string urlRequest, Method method, object body = null)
        {
            var res = new RestClient(urlRequest);
            ServicePointManager.ServerCertificateValidationCallback = MyCertHandler;
            var json = JsonConvert.SerializeObject(body);
            var request = new RestRequest(method);
            if (body != null)
            {
                request.AddHeader("Accept", "application/json");
                request.AddJsonBody(json);
            }
            var response = res.Execute(request);
            return response;
        }
        public static bool MyCertHandler(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
    }
}
