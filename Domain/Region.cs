using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Administration_RRHH.Domain
{
    internal class Region
    {
        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de propiedades de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public int RegionId { get; set; } //Manipulado directamente por la base de datos, no se asigna manualmente.
        public string RegionCode { get; set; }
        public string Description { get; set; } //Nombre de la región
        public bool Enabled { get; set; } //Indica si la región está activa o no

        // -- --------------------------------------------------------------------------------------- -- */
        //                          Declaración de Constructores de la clase Region
        // -- --------------------------------------------------------------------------------------- -- */
        public Region () 
        {
            RegionCode = string.Empty;
            Description = string.Empty;
            Enabled = true;
        }

        // Constructor con parámetros para facilitar la creación de objetos Region con datos específicos.
        public Region(string regionCode, string description, bool enabled)
        {
            RegionCode = regionCode;
            Description = description;
            Enabled = enabled;
        }

        // -- --------------------------------------------------------------------------------------- -- */
        //                          Metodos adicionales (si es necesario) para la clase Region
        // -- --------------------------------------------------------------------------------------- -- */

        public int AddRegion()
        {
            // Lógica para agregar la región a la base de datos
            // Retorna el ID de la nueva región creada
            return 0; // Placeholder, se implementará la lógica real posteriormente
        }

        public Region GetRegionByCode(int filter)
        {
            // Lógica para obtener una región específica por su ID desde la base de datos
            return new Region(); // Placeholder, se implementará la lógica real posteriormente
        }


        public List<Region> ListRegion ()
        {
            // Lógica para obtener una lista de regiones desde la base de datos
            return new List<Region>(); // Placeholder, se implementará la lógica real posteriormente
        }


        public void ModificRegion(string code)
        {
            // Lógica para actualizar la información de la región en la base de datos
        }

        public bool  InhabilityRegion ()
        {
            // Lógica para eliminar o deshabilitar la región en la base de datos
            return true; // Placeholder, se implementará la lógica real posteriormente
        } 

    }//end class
}//end namespace
