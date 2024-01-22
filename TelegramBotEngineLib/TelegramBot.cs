using System.Text;
using Newtonsoft.Json.Linq;

namespace TelegramBotEngineLib
{
    public class TelegramBot
    {
        string _token;
        readonly HttpClient client = new HttpClient();
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
                if(jToken.ContainsKey("updates_offset"))
                {
                    var q =(int)jToken["updates_offset"];
                    if(q>0)
                    getUpdatesoffset=q;
                }            
                if(jToken.ContainsKey("auto_update"))
                {
                    int q =(int)jToken["auto_update"];
                    if(q>0)
                    {
                        auto_update=q;
                        autoupdate();
                    }
                }
            }
        }
        #region flags
        bool json_in_terminal=false;
        int auto_update=0;
        long getUpdatesoffset=0;
        #endregion
        
        void autoupdate()
        {
            Thread newThread = new Thread(auto);
            newThread.Start();
        }
        void auto()
        {
            System.Threading.Thread.Sleep(auto_update);
            string postData = Newtonsoft.Json.JsonConvert.SerializeObject(new { offset = getUpdatesoffset});
            StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
            PostDataAsync("getUpdates",content,true);
        }
        public void GetUpdate()
        {
            Send("getUpdates",new { offset = getUpdatesoffset});
        }
        public async void Send(string METHOD_NAME,object? pairData =null){
            string postData = Newtonsoft.Json.JsonConvert.SerializeObject(pairData!=null?pairData:"{}");
            StringContent content = new StringContent(postData, Encoding.UTF8, "application/json");
            await PostDataAsync(METHOD_NAME,content);
        }

        
        async Task PostDataAsync(string METHOD_NAME,StringContent data,bool reDo=false)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string apiUrl = "https://api.telegram.org/bot"+_token+"/"+METHOD_NAME;

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, data);
                    // Обробка відповіді
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        if(json_in_terminal)
                        {Console.WriteLine(result);}
                        ProcessResult(result);
                    }
                    else
                    {
                        Console.WriteLine("POST request failed. Status code: " + response.StatusCode);
                    }
                     auto();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
        void ProcessResult(string result)
        {
            // Функція для обробки отриманого результату
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
        private void _msg(JToken msg)
        {
            onMassageReceive?.Invoke(this, new MsgEventArgs(this,msg));
        }
        public event EventHandler<MsgEventArgs> onMassageReceive;
    }
}