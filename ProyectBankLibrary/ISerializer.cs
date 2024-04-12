using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectBankLibrary
{
    public interface ISerializer
    {
        /////
        public void Serialize<T>(T obj, string fileName);
        public T Deserialize<T>(string fileName);
    }
}
