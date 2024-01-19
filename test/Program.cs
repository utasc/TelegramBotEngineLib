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
            tb.onMassageReceive+=readMsg;
            while(i<10){
                System.Threading.Thread.Sleep(5000);
                tb.GetUpdate();
            }
        }

        private static void readMsg(object? sender, MsgEventArgs e)
        {
            Console.WriteLine(e.MassageClass.from.first_name+": "+e.MassageClass.text);
        }
    }    
}