using Regions = Administration_RRHH.Domain.Regions;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class RegionBusiness
    {
        #region Campos
        /* -- -------------------------------------------------------------------------------------------- -- */
        /*                          Declaración de métodos de la clase RegionBusiness                         */
        /* -- -------------------------------------------------------------------------------------------- -- */

        private Regions _region;

        #endregion

        #region Constructors
        /* -- -------------------------------------------------------------------------------------------- -- */
        /*                          Constructor
        /* -- -------------------------------------------------------------------------------------------- -- */

        public RegionBusiness() 
        { 
            _region = new Regions();
        }

        public RegionBusiness (Regions regions)
        {
            _region = regions;
        }

        #endregion

        #region Methods
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

        public List<Regions>? ReadRegions()
        {
            try
            {
                return _region.ListRegion();
            }
            catch (Exception ex)            
            {
                throw new Exception("Intento fallido al leer las regiones.", ex);
            } //end try-catch

        }
        #endregion 
    }//End class
} //End namespace
