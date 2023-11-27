using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Cashier_Registry
{
    static class Database
    {
        private static HttpClient Client = new HttpClient();
        private static async Task<Item> LoadInformation(string Id)
        {
            string apiUrl = $"https://future-dev.online/cashier_registry/information/item/{Id}";
            HttpResponseMessage response = await Client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonData = await response.Content.ReadAsStringAsync();              
                var data = JsonConvert.DeserializeObject<Item>(jsonData);
                
                return data;
            }
            return null;
        }
        public static async Task<Item> GetData(string Id)
        {
            return await LoadInformation(Id);
        }
    }
}
