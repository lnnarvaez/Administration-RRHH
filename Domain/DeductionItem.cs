using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    internal class DeductionItem: PayrollMovement
    {
        public decimal GetEffectOnTotal()
        {
            return this.Amount;
        }
    }//End-Class
}//End-namespace
