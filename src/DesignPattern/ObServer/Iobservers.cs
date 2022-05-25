using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObServer
{
    interface Iobserver
    {
        void update(string celebrity, string tweet);
    }
}
