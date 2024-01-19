using Newtonsoft.Json.Linq;
using TelegramBotEngineLib.Classes;

namespace TelegramBotEngineLib
{

    public class MsgEventArgs
    {
        public MsgEventArgs( TelegramBot bot,JToken msg )
        {
            Bot=bot;
            MassageJToken = msg;
        }
        public TelegramBot Bot;

        public JToken MassageJToken { get;private set; }

        messageT msg=null;
        public messageT MassageClass 
        { 
            get 
            {
                if(msg==null)
                msg=MassageJToken.ToObject<messageT>();
                return msg;
            }
        }

        public string MassageString{get => MassageJToken.ToString();}
    }
}