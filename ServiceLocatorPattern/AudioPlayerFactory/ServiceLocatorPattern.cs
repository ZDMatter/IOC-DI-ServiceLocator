using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.AudioPlayerFactory
{
    public class ServiceLocatorPattern
    {
        static Dictionary<string, object> serviceDictionary = new Dictionary<string, object>();

        public static void Register<T>(T service)
        {
            serviceDictionary[typeof(T).Name] = service;
        }

        public static T GetService<T>()
        {
            T instance = default(T);
            if(serviceDictionary.ContainsKey(typeof(T).Name) == true)
            {
                instance = (T)serviceDictionary[typeof(T).Name];
            }
            return instance;
        }
    }
}
