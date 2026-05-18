using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class PayrollMovement
    {
        //Declaración de propiedades
        public long MovementId { get; set; }
        public long PayrollId { get; set; }
        public string Description { get; set; } // Mapea a AccruedType o DeductionType
        public decimal Amount { get; set; }

        //public abstract decimal GetEffectOnTotal();

    }//End-Class
}//End-namespace
