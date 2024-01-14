
using System.Text;

namespace TelegramBotEngineLib
{
    public class TelegramBot
    {
        string _token;
        public TelegramBot(string token)
        {
            _token=token;
        Console.WriteLine("run post");
           Send("getMe");
        Console.WriteLine("posted");
        }
        public  readonly HttpClient client = new HttpClient();
        int getUpdatesoffset=0;
        public void GetUpdate()
        {
            Send("getUpdates",new { update_id = getUpdatesoffset});
        }
        
        public void Send(string METHOD_NAME,object? pairData =null){

                string postData = Newtonsoft.Json.JsonConvert.SerializeObject(pairData!=null?pairData:"{}");

                StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");

           _= PostDataAsync(METHOD_NAME,content);
        }
        async Task PostDataAsync(string METHOD_NAME,StringContent data)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {

                string apiUrl = "https://api.telegram.org/bot"+_token+"/"+METHOD_NAME;
                // Виконати асинхронний POST-запит
                HttpResponseMessage response = await client.PostAsync(apiUrl, data);//

                // Перевірка статусу відповіді
                if (response.IsSuccessStatusCode)
                {
                    // Отримати текст відповіді
                    string result = await response.Content.ReadAsStringAsync();

                    // Виклик функції для обробки результату
                    ProcessResult(result);
                }
                else
                {
                    Console.WriteLine($"Помилка: {response.StatusCode}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
        static void ProcessResult(string result)
    {
        // Функція для обробки отриманого результату
        Console.WriteLine($"Отриманий результат: {result}");
    }
    }
}