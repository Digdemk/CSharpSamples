using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.InterfaceSample
{
    public interface IPrint
    {
        string PageContent { get; set; }
        int Count { get; set; }
    }
}
