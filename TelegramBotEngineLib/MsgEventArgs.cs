using Newtonsoft.Json.Linq;
using TelegramBotEngineLib.Classes;

namespace TelegramBotEngineLib
{
    public class MsgEventArgs:JsonEventArgs
    {
        Message msg;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MsgEventArgs(TelegramBot bot, JToken msg) : base(bot, msg)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Bot=bot;
            JsonToken = msg;
        }

        public Message MassageClass 
        { 
            get 
            {
                if(msg==null)
#pragma warning disable CS8601 // Possible null reference assignment.
                msg=JsonToken.ToObject<Message>();
#pragma warning restore CS8601 // Possible null reference assignment.
                return msg;
            }
        }

        public string MassageString{get => JsonToken.ToString();}
    }
}