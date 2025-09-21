using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace YouTubeSearchApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();

            var baseUrl = "https://www.googleapis.com/youtube/v3/search";

            Console.WriteLine("Enter your search query: ");
            var query = Console.ReadLine();

            // Дефиниране на параметрите на API за заявката за търсене
            var part = "snippet";
            var type = "video";
            var apiKey = "YOUR_API_KEY_HERE"; // Тук трябва да поставите вашия API ключ
            var url = $"{baseUrl}?part={part}&q={query}&type={type}&key={apiKey}";

            try
            {
                // Изпращане на заявка към YouTube API и прочитане на отговора
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Проверка на статуса на отговора
                if (!response.IsSuccessStatusCode)
                {
                    // Показване на статуса и съдържанието на отговора в случай на грешка
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error details: {errorResponse}");
                    return;
                }

                string responseBody = await response.Content.ReadAsStringAsync();

                var searchResponse = JsonConvert.DeserializeObject<YouTubeSearchApp>(responseBody);

                if (searchResponse.Items == null || searchResponse.Items.Count == 0)
                {
                    Console.WriteLine("No items found in the response.");
                    return;
                }

                foreach (var result in searchResponse.Items)
                {
                    string title = result.Snippet.Title;
                    string videoId = result.Id.VideoId;
                    string videoUrl = $"https://www.youtube.com/watch?v={videoId}";
                    Console.WriteLine($"{title}: {videoUrl}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
