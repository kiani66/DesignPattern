using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    abstract class Handler
    {
        private Handler _successor;

        public Handler successor
        {
            get { return _successor; }
            set { _successor = value; }
        }
        public void setsuccessor(Handler successor)
        {
            this._successor = successor;
        }
        public abstract void Sendcheckforsignature(Cheque cheque);
    }
}
