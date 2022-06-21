using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    public class Cheque
    {
        internal string chequeNumber { get; set; }
        internal decimal amount { get; set; }

        public Cheque(string ChequeNumber , decimal Amount)
        {
            this.chequeNumber = ChequeNumber;
            this.amount = Amount;
        }
    }
}
