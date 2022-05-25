using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObServer
{
    interface Isubject
    {
        void Register(ObServer.Iobserver iobserver);
        void UnRegister(ObServer.Iobserver iobserver);
        void Notify(string tweet);
    }
}
