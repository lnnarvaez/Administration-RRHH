using Region = Administration_RRHH.Domain.Region;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class RegionBusiness
    {
        /* -- -------------------------------------------------------------------------------------------- -- */
        /*                          Declaración de métodos de la clase RegionBusiness                         */
        /* -- -------------------------------------------------------------------------------------------- -- */

        private Region _region;

        /* -- -------------------------------------------------------------------------------------------- -- */
        /*                          Constructor
        /* -- -------------------------------------------------------------------------------------------- -- */

        public RegionBusiness (Region region)
        {
            _region = region;
        }

        public int AddRegion ()
        {
            //Si ya existe una región con el mismo código, lanzar una excepción para evitar duplicados
            if (_region.isUniqueRegionCode(_region.RegionCode))
            {
                throw new Exception($"El código de región '{_region.RegionCode}' ya existe. " +
                    $"Por favor, elija un código diferente.");
            }

            // Si el código de región es único, proceder a agregar la nueva región a la base de datos
            return _region.AddRegion();  
        }//end AddRegion

    }//End class
} //End namespace
