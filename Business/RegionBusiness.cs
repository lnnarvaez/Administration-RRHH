using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Application
{
    internal class RegionBusiness
    {
        /* --------------------------------------------------------*/
        /*      ----    Declaración de propiedades      ----      */
        /* --------------------------------------------------------*/

        public int RegionId { get; set; }
        public string RegionCode { get; set; } 
        public string Description { get; set; }
        public bool Disponibilidad { get; set; }

        /* --------------------------------------------------------*/
        /*      ----    Constructores      ----                    */
        /* --------------------------------------------------------*/

        // Constructor sin parámetros
        public RegionBusiness()
        {
            // Constructor por defecto
        }

        public RegionBusiness(int regionId, string regionCode, string description, bool disponibilidad)
        {
            RegionId = regionId;
            RegionCode = regionCode;
            Description = description;
            Disponibilidad = disponibilidad;
        }

        /* --------------------------------------------------------*/
        /*      ----    Métodos             ---                    */
        /* --------------------------------------------------------*/

    }//End class
}//end namespace
