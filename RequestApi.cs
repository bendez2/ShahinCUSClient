using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Nastol
{
    public class RequestApi
    {
        private string _urlApi = "https://apis.api-mauijobs.site/";
        private string _urlApiLocal = "http://127.0.0.1:25565/";

        public async Task<string> SendAPostRequstAsync(string nameController, string json)
        {
            HttpContent content = new StringContent(json);
            HttpClient client = new HttpClient();

            content.Headers.ContentType = MediaTypeHeaderValue.Parse(@"application/json");
            HttpResponseMessage response = await client.PostAsync(_urlApi + nameController, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;

                return await responseContent.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }

        public async Task<string> SendAPutRequestAsync(string nameController, string json)
        {
            HttpContent content = new StringContent(json);
            HttpClient client = new HttpClient();

            content.Headers.ContentType = MediaTypeHeaderValue.Parse(@"application/json");
            HttpResponseMessage response = await client.PutAsync(_urlApi + nameController, content);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;

                return await responseContent.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }

        public async Task<string> SendAGetRequstAsync(string nameController, int idUser)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", CurrentUser.user.Access_token);

            HttpResponseMessage response = await client.GetAsync(_urlApi + nameController + "/" + idUser);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                HttpContent responseContent = response.Content;

                return await responseContent.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }
    }
}
