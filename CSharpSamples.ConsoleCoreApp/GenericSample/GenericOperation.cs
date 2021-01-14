using CSharpSamples.ConsoleCoreApp.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp.GenericSample
{
    public class GenericOperation<T> : IGeneric<T> where T : BaseDto
    {
        public List<T> GetAll()
        {
            return null;
        }

        public void Add(T entity)
        {

        }

        public void Remove(T entity)
        {
                
        }
    }
}
