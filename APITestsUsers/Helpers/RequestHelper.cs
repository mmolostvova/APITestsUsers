using System;
using RestSharp;

namespace APITestsUsers.Helpers
{
    public class RequestHelper
    {
        private RestClient _client;

        public RequestHelper(string requestUrl)
        {
            _client = new RestClient(requestUrl);           
        }

        public IRestResponse SendPostRequest(object body)
        {
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");            
            request.AddJsonBody(body);
            IRestResponse response = _client.Execute(request);
            return response;
        }
    }
}
