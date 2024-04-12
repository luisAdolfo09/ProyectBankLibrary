using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectBankLibrary
{
   public class SerializadorJson : ISerializer
    {
        public T Deserialize<T>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<T>(json);
        }

        public void Serialize<T>(T obj, string fileName)
        {
            string json = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, json);
        }
    }
}
