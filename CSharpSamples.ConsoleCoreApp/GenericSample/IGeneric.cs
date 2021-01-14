using CSharpSamples.ConsoleCoreApp.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.GenericSample
{
    public interface IGeneric<T> where T: BaseDto
    {
        void Add(T entity);

        void Remove(T entity);
    }
}
