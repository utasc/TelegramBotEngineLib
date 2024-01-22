using Newtonsoft.Json.Linq;
using TelegramBotEngineLib.Classes;

namespace TelegramBotEngineLib
{
    public class MsgEventArgs:JsonEventArgs
    {
        messageT msg=null;

        public MsgEventArgs(TelegramBot bot, JToken msg) : base(bot, msg)
        {
            Bot=bot;
            JsonToken = msg;
        }

        public messageT MassageClass 
        { 
            get 
            {
                if(msg==null)
                msg=JsonToken.ToObject<messageT>();
                return msg;
            }
        }

        public string MassageString{get => JsonToken.ToString();}
    }
}