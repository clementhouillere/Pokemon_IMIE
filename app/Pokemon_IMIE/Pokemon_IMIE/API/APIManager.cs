using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using toto = Windows.Web.Http;

namespace App2.API
{
    public class APIManager
    {
        public async Task<T> GetFromAPI<T>()
        {
            T item = default(T);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://62.210.106.228:7777");

                HttpResponseMessage response = await client.GetAsync("dresseurs");

                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<T>(result);
                }
            }
            return item;
        }

        public async Task<T> GetFromAPI<T>(long id)
        {
            T item = default(T);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://62.210.106.228:7777");

                HttpResponseMessage response = await client.GetAsync("dresseurs/" + id);

                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<T>(result);
                }
            }
            return item;
        }

        public async Task<Boolean> PostToAPI<T>(T item)
        {
            Boolean isOK = false;

            using (toto.HttpClient client = 
                new toto.HttpClient())
            {
                toto.HttpRequestMessage message = 
                    new toto.HttpRequestMessage(
                        toto.HttpMethod.Post, 
                        new Uri("http://pokeapi.co/api/v2/"));

                var test = JsonConvert.SerializeObject(item);

                message.Content = 
                    new toto.HttpStringContent(
                        test);

                message.Content.Headers.ContentType =
                    new toto.Headers.HttpMediaTypeHeaderValue("application/json");

                toto.HttpResponseMessage response =
                    await client.SendRequestAsync(message);

                if (response.IsSuccessStatusCode)
                {
                    isOK = true;
                }
            }

            return isOK;
        }
    }
}
