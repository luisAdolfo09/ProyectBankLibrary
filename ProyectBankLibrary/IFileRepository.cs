using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectBankLibrary
{
    public interface IFileRepository
    {
        void OpenOrCreateFile();

        void OpenFile();

        void WriteRecordToFile();

        string? ReadNextRecord();

        void ResetFilePointer();

        void CloseFile();
    }
}
