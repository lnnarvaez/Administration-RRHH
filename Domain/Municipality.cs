namespace Administration_RRHH.Domain
{
    internal class Municipality
    {
        /* -------------------------------------------------------------------------- */
        /*                               CLASS ATTRIBUTES                             */
        /* -------------------------------------------------------------------------- */
        public int MunicipalityId { get; set; } //Gestionado por la base de datos
        public Region region { get; set; } //Relación de composición, un municipio pertenece a una región
        public string MunicipalityCode { get; set; } //Código único del municipio
        public string MunicipalityName { get; set; }
        public bool Enabled { get; set; } //Indica si el municipio está habilitado o no


        /* -------------------------------------------------------------------------- */
        /*                               Constructor                                  */
        /* -------------------------------------------------------------------------- */
        public Municipality ()
        {
           
        }

        // Constructor para crear un municipio con todos sus atributos
        public Municipality(Region region, string municipalityCode, string municipalityName, bool enabled)
        {
            this.region = region;
            MunicipalityCode = municipalityCode;
            MunicipalityName = municipalityName;
            Enabled = enabled;
        }

        /* -------------------------------------------------------------------------- */
        /*                               Metodos                             */
        /* -------------------------------------------------------------------------- */
        /// <summary>
        /// Agrega un nuevo municipio a la base de datos. Este método se encarga de validar los datos 
        /// del municipio y luego interactuar con el repositorio para guardar la información en la base de datos. 

        /// </summary>
        /// <returns>Retorna el ID del nuevo municipio creado.</returns>
        public int AddMunicipality()
        {
            // Lógica para agregar el municipio a la base de datos
            // Retorna el ID del nuevo municipio creado
            return 0; // Placeholder, se debe implementar la lógica real
        }   

        public Municipality GetMunicipalityByCode(string code)
        {
            // Lógica para obtener un municipio por su código desde la base de datos
            return null; // Placeholder, se debe implementar la lógica real
        }
        public List<Municipality> GetAllMunicipalities()
        {
            // Lógica para obtener todos los municipios desde la base de datos
            return new List<Municipality>(); // Placeholder, se debe implementar la lógica real
        }
        public void UpdateMunicipality(string code)
        {
            // Lógica para actualizar un municipio existente en la base de datos
        }

        public bool RemoveMunicipality(string code)
        {
            // Lógica para eliminar un municipio de la base de datos
            return false; // Placeholder, se debe implementar la lógica real
        }

    }//end class
} //end namespace
