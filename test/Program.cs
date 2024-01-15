using System;
using TelegramBotEngineLib;
using TelegramBotEngineLib.Metods;

namespace test // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool work=true;
        static void Main(string[] args)
        {
            var tb = new TelegramBot("6028827229:AAFqd7LI2kxE3ic7zyvsd2Qmqg59E9msXUg");
            int i=0;
            while(i<10){
                System.Threading.Thread.Sleep(5000);
                tb.GetUpdate();
           /*Console.WriteLine("Hello World!"+i);
            if (i==1)
            if (i==3)
            {
                //tb.SendMessage("892039860","Відповідь з продвинутих методів");
                var data = new { cd
                    chat_id = "892039860", 
                    text = "Відповідь" ,
                    parse_mode="HTML",
                    reply_Markup = new {
            ReplyMarkupType = "force_reply",
            ResizeKeyboard = true
        }};
                tb.Send("sendMessage",data);
                }
            i++;*/
            }
        }
    }    
}