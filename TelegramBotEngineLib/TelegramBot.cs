
using System.Text;
using Newtonsoft.Json.Linq;

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
            Send("getUpdates",new { offset = getUpdatesoffset});            
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
                    Console.WriteLine($"Помилка HttpClient: {response.StatusCode}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
         void ProcessResult(string result)
    {            // Функція для обробки отриманого результату
            Console.WriteLine($"Отриманий результат: {result}");
            JObject json = JObject.Parse(result);
            if((bool?)(json?["ok"])== true)
            {
                if(json.ContainsKey("result"))
                {        
                    if(json["result"] is JArray){
                        // Отримання значення "result"
                        JArray resultArray = (JArray)json["result"];
                        // Отримання об'єкта "result" (перший елемент у масиві)
                        if(resultArray.Count>0){
                            JObject resultObject = (JObject)resultArray[0];
                            if (resultObject.ContainsKey("update_id"))
                            getUpdatesoffset = (int)(resultObject["update_id"])+1;
                        }
                    }else{

                    }
                }
            }
    }
    }
}