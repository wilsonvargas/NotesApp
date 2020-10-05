using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.WebClient.Services
{
    public sealed class BackendService
    {
        private HttpClient client;
        public static BackendService Instance { get; } = new BackendService();
        private BackendService()
        {
            client = new HttpClient { BaseAddress = new Uri("http://webapi:8888") };
        }


        public async Task<T> Get<T>(string requestUri, string token = "", Dictionary<string, string> parameters = null)
        {
            if (parameters != null)
            {
                requestUri = $"{requestUri}?{string.Join("&", parameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}";
            }
            HttpResponseMessage response = await GetHttpResponse(requestUri, token);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                T cloudResponse = JsonConvert.DeserializeObject<T>(content);
                return cloudResponse;
            }
            else
            {
                return default(T);
            }

        }

        public async Task<HttpResponseMessage> GetHttpResponse(string requestUri, string token = "")
        {
            HttpResponseMessage response = await client.GetAsync(requestUri);
            return response;
        }

        public async Task<HttpResponseMessage> PostHttpResponse<T>(T item, string requestUrl, string token = "")
        {
            string json = JsonConvert.SerializeObject(item);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(requestUrl, content);
            return response;
        }
    }
}
