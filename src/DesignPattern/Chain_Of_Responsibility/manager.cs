using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Chain_Of_Responsibility
{
    class manager : Handler
    {
        public override void Sendcheckforsignature(Cheque cheque)
        {
            if (cheque.amount > 1000000 && cheque.amount<2000000)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Check number {cheque.chequeNumber} with the amount {cheque.amount}$ was signed by the manager");
            }
            else
            {
                successor.Sendcheckforsignature(cheque);
            }
        }
    }
}
