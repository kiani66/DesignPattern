using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor
{
    class FileDataSource : DataSource
    {
        private string filePath;

        public FileDataSource(string filePath)
        {
            this.filePath = filePath;
        }
        public override string Read()
        {
            Console.WriteLine($"Data Read From {filePath}");
            return "";
        }

        public override void Write(string Data)
        {
            Console.WriteLine($"Date Worte To {filePath}");
        }
    }
}
