using BooksWebApp.Data.Dtos;
using BooksWebApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace BooksWebApp.UI.DataAccess
{
    public class BooksAccess
    {
        public static string Url = "https://www.googleapis.com/books/v1/volumes?q=";
        public static string ApiKey = "AIzaSyA7aG25WobVtWe3OgQz-sl8W53zHpk1uqw";
        public async static Task<BookDto> Search(string query)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync($"{Url}{query}&key={ApiKey}");

                if (result.IsSuccessStatusCode)
                {
                    var options = new JsonSerializerOptions();
                    options.PropertyNameCaseInsensitive = true;

                    var reponse = await result.Content.ReadAsStringAsync();
                    var resobject = JsonSerializer.Deserialize<VolumenModel>(reponse, options);
                    Console.WriteLine(resobject);
                }
            }

            return  null;
        }
    }
}
