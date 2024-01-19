
using System.Reflection.Metadata;
using System.Text;
using Newtonsoft.Json.Linq;
using TelegramBotEngineLib.Classes;

namespace TelegramBotEngineLib
{
    public class TelegramBot
    {
        string _token;
        public TelegramBot(string token, object? pairData =null)
        {
            _token=token;

            if(pairData!=null)
            {
                JObject jToken = JObject.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(pairData));
                if(jToken.ContainsKey("json_in_terminal"))
                {
                    var q =(bool)jToken["json_in_terminal"];
                    if((bool)jToken["json_in_terminal"])
                    json_in_terminal=true;
                }
            }
           Send("getMe");
        }
        #region flags
        bool json_in_terminal=false;
        #endregion
        public  readonly HttpClient client = new HttpClient();
        long getUpdatesoffset=0;
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
                    if(json_in_terminal){Console.WriteLine(result);}
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
        private void _msg(JToken msg)
        {
            onMassageReceive?.Invoke(this, new MsgEventArgs(this,msg));
        }
        public event EventHandler<MsgEventArgs> onMassageReceive;            

        void ProcessResult(string result)
        {            // Функція для обробки отриманого результату
           // Console.WriteLine($"Отриманий результат: {result}");
            JObject json = JObject.Parse(result);
            if((bool?)(json?["ok"])== true)
            {
                if(json.ContainsKey("result"))
                {        
                    if(json["result"] is JArray){
                        // Отримання значення "result"
                        JArray resultArray = (JArray)json["result"];
                        // Отримання об'єкта "result" (перший елемент у масиві)
                        foreach(JToken j in resultArray)
                        {
                            if (j is JObject jObject && jObject.TryGetValue("update_id", out JToken updateIdToken))
                            {
                                getUpdatesoffset = updateIdToken.Value<long>()+1;
                            }
                            JToken messageToken = j.SelectToken("message");
                            if (messageToken != null)
                            {
                                _msg(messageToken);
                            }
                        }
                    }else{
                        //Якщо не масив

                        JObject resultArray = (JObject)json["result"];
                        //{"id":6028827229,"is_bot":true,"first_name":"Test_bot","username":"utasc_test_bot","can_join_groups":true,"can_read_all_group_messages":false,"supports_inline_queries":false}
                    }
                }
            }
        }
    }
}