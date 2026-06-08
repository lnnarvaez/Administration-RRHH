using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    internal class AccruedItem: PayrollMovement
    {
        public decimal GetEffectOnTotal()
        {
           return this.Amount;
        } 

    }//end-Class
}//end-namespace
