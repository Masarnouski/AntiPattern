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
        string path = "Log.txt";
        public void Log(string m)
        {
            File.AppendText(path).Write(m);
        }
    }
}
