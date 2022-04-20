using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PIDCoSmsPackage.Model;

namespace PIDCoSmsPackage
{
    public static class ServiceHttpClientExtension
    {
        public static async Task<ApiResultModel<T>> PostAsync<T>(string uri, object postData, string token = null)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress= new Uri("https://api.smszone.ir/api/");
                //client.DefaultRequestHeaders.Add("Accept","application/json");

                if (token!=null)
                    client.DefaultRequestHeaders.Add("Authorization", $"bearer {token}");

                var response = await client.PostAsync(uri, postData.ToHttpContent());

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(result);
                    return new ApiResultModel<T> { Status = HttpStatusCode.OK, Data = data };
                }
                else
                {
                    var tt = await response.Content.ReadAsStringAsync();
                }
                return new ApiResultModel<T> { Status = response.StatusCode };
            }
        }

        public static HttpContent ToHttpContent(this object data)
        {
            string output = JsonConvert.SerializeObject(data);
            var json = new StringContent(output, Encoding.UTF8, "application/json");
            return json;
        }
    }
}
