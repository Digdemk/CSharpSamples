using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.InterfaceSample
{
    public class PrintOperation
    {
        public static void PrintPage(IPrint print)
        {
            Console.WriteLine("yazdırılıyor...");
            Console.WriteLine(print.PageContent);
            Console.WriteLine(print.Count + " adet yazdırıldı...");
        }
    }
}
