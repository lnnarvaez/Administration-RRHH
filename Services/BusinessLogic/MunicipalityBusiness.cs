using Administration_RRHH.Domain;

namespace Administration_RRHH.Services.BusinessLogic
{
    internal class MunicipalityBusiness
    {
        private Municipality _municipality;

        public MunicipalityBusiness () 
        { 
            _municipality = new Municipality();
        }

        public MunicipalityBusiness(Municipality municipality)
        {
            _municipality = municipality;
        }

        #region
        public int AddMunicipality  ()
        {
            //Si ya existe una región con el mismo código, lanzar una excepción para evitar duplicados
            if (_municipality.isUniqueMunicipalityCode(_municipality.MunicipalityCode))
            {
                throw new Exception($"El código de municipio '{_municipality.MunicipalityCode}' ya existe. " +
                    $"Por favor, elija un código diferente.");
            }

            // Si el código de municipio es único, proceder a agregar el nuevo municipio a la base de datos
            return _municipality.InsertMunicipality();
        }

        public List<Municipality>? ReadMunicipalities()
        {
            try
            {
                return _municipality.ListMunicipality();
            }
            catch (Exception ex)
            {
                throw new Exception("Intento fallido al leer los municipios.", ex);
            } //end try-catch
        }

        #endregion
    }//End class
}//end namespace
