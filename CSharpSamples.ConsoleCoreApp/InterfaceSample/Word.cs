using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.InterfaceSample
{
    public class Word :IPrint
    {

        public string FontType { get; set; }

        //Print edilebilmesi için gerekli özellikler
        public string PageContent { get; set; }
        public int Count { get; set; }

    }
}
