using CSVApp.Common;
using CsvHelper;
using System;
using System.IO;
using System.Threading;

namespace CSVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                Console.WriteLine("start as exe");                
            } 
            else
            {
                Console.WriteLine("start as service");
            }
            Thread thread = new Thread(myFirstThread);
            thread.Start();           
        }
        static void myFirstThread()
        {
            Console.WriteLine("Hello world");
            Log.i("this is a test");
            Thread.Sleep(3000);
        }
    }
}
