using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.InterfaceSample
{
    class Excel :IPrint
    {
        //Kendi özellikleri
        public string SheetCount { get; set; }
        //Print edilebilmesi için gerekli özellikler
        public string PageContent { get; set; }
        public int Count { get; set; }
    }
}
