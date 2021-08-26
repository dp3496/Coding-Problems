using System;
using System.Collections;
using System.Collections.Generic;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class MyIoc
    {
        private IDictionary<string, Type> _typeCollections = new Dictionary<string, Type>();
        public void RegisterObject<TI, T>() where T : IRunnable
        {
            var type = typeof(T);
            _typeCollections.Add(type.Name, type);
        }

        public T GetObject<T>(string name)
        {
            var typeName = typeof(T);
            object instance = null;

            if(_typeCollections.TryGetValue(name, out Type type))
            {
                instance = Activator.CreateInstance(type);
            }

            return (T)instance;
        }
    }   
}