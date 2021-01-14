using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.Dto
{
    public class BaseDto
    {
        public BaseDto(string name)
        {
            this.Name = name;
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
