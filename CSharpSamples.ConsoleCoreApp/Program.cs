using CSharpSamples.ConsoleCoreApp.Dto;
using CSharpSamples.ConsoleCoreApp.GenericSample;
using CSharpSamples.ConsoleCoreApp.InterfaceSample;
using System;

namespace CSharpSamples.ConsoleCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Product product = new Product("Tie", 300);

            //    CategoryDto categoryDto = new CategoryDto("Tekstil");

            //    GenericOperation<string> genericOperation = new GenericOperation<string>();

            //    genericOperation.Add("örnek data");

            //    GenericOperation<int> genericOperation2 = new GenericOperation<int>();
            //    genericOperation2.Add(5);

            GenericOperation<CategoryDto> genericOperation = new GenericOperation<CategoryDto>();

            Word word = new Word();
            word.Count = 2;
            word.PageContent = "word yazdırılacak içerik";

            PrintOperation.PrintPage(word);


        }
    }
}
