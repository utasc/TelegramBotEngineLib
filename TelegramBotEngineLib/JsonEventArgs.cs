using Newtonsoft.Json.Linq;

namespace TelegramBotEngineLib
{
    public class JsonEventArgs
    {
        public JsonEventArgs( TelegramBot bot,JToken msg )
        {
            Bot=bot;
            JsonToken = msg;
        }
        public TelegramBot Bot;

        public JToken JsonToken;

    }
}