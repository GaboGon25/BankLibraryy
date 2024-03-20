using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibraryy
{
    public interface IFileRepository
    {
        void OpenOrCreateFile();
        void OpenFile();
        void WriteRecordFile();
        string? ReadNextRecord();
        void ResetFilePointer();
        void CloseFile();
    }
}
