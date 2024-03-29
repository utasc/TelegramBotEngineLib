using TelegramBotEngineLib.Classes;

namespace TelegramBotEngineLib.Metods
{
    public static class Metods{

        public static void SendMessage(this TelegramBot bot,string chatId,string message)
        {
                var data = new { chat_id = chatId, text = message };
                bot.Send("sendMessage",data);        
        }

        public static void SendMessage(this Chat chat,TelegramBot bot,string message)
        {
                var data = new { chat_id = chat.id, text = message };
                bot.Send("sendMessage",data);        
        }
        public static void SendMessage(this Message masage,TelegramBot bot,string message)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var data = new { chat_id = masage.chat.id, text = message };
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                bot.Send("sendMessage",data);        
        }
        public static void SendMessage(this MsgEventArgs masagedata, string message)
        {
                var data = new { chat_id = masagedata.MassageClass.chat.id, text = message };
                masagedata.Bot.Send("sendMessage",data);        
        }
        public static void pinChatMessage(this MsgEventArgs massage,TelegramBot bot)
        {
                var data = new { chat_id = massage.MassageClass.chat.id, message_id = massage.MassageClass.message_id };
                bot.Send("pinChatMessage",data);        
        }
    }
}