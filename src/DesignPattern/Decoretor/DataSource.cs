using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor
{
    public abstract class  DataSource
    {
        public abstract void Write(string Data);
        public abstract string Read();
    }
}
