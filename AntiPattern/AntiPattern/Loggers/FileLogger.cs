using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class FileLogger
    {
        public void Log(string m,string path)
        {
            File.AppendText(path).Write(m);
        }
    }
}
