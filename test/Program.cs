using System;
using TelegramBotEngineLib;
using TelegramBotEngineLib.Metods;

namespace test // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool work=true;
        static async Task  Main(string[] args)
        {
            var tb = new TelegramBot("6028827229:AAFqd7LI2kxE3ic7zyvsd2Qmqg59E9msXUg",
            new{
                json_in_terminal=true,
                auto_update=1000
            });
            int i=0;
            tb.onMassageReceive+=readMsg;

            await Task.Delay(-1);
        }

        private static void readMsg(object? sender, MsgEventArgs e)
        {
            Console.WriteLine(e.MassageClass.from.first_name+": "+e.MassageClass.text);
            if(e.MassageClass.text=="qwerty")
            e.Bot.Send("getChat",new {chat_id = e.MassageClass.chat.id});
        }
    }    
}