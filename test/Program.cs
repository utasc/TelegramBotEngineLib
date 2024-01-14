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
            var tb = new TelegramBot("6028827229:AAFxcX-JnXIiaOd_THGCW7FuVZHll_o_nKw");
            int i=0;
            while(i<10){
                System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hello World!"+i);
            if (i==1)tb.GetUpdate();
            if (i==3)
            {
                //tb.SendMessage("892039860","Відповідь з продвинутих методів");
                var data = new { 
                    chat_id = "892039860", 
                    text = "Відповідь" ,
                    parse_mode="HTML",
                    reply_Markup = new {
            ReplyMarkupType = "force_reply",
            ResizeKeyboard = true
        }};
                tb.Send("sendMessage",data);
                }
            i++;
            }
        }
    }
    
}