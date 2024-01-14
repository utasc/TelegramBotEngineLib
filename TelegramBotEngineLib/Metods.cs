namespace TelegramBotEngineLib.Metods
{
    public static class Metods{

        public static void SendMessage(this TelegramBot bot,string chatId,string message)
        {

                var data = new { chat_id = chatId, text = message };
                bot.Send("sendMessage",data);
        
        }
    }
}