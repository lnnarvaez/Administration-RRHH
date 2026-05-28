using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    internal class Region
    {
        //Declaración de propiedades
        public int RegionId { get; set; } //Identificador único de la región manejado por la base de datos
        public string DepartmentCode { get; set; }
        public string Description { get; set; }
        public bool Disponibilidad { get; set; }

        //Constructor sin parametros que inicializa las propiedades con valores predeterminados
        public Region ()
        {
            RegionId = 0;
            DepartmentCode = string.Empty;
            Description = string.Empty;
            Disponibilidad = true;
        }

        //Constructor con parámetros para inicializar las propiedades con valores específicos
        public Region(int regionId, string departmentCode, string description, bool disponibilidad)
        {
            RegionId = regionId;
            DepartmentCode = departmentCode;
            Description = description;
            Disponibilidad = disponibilidad;
        }

        //Método para mostrar la información de la región
        public List<Region> ShowInformation (string filter)
        {
            //Imprime la información de la región
            return new List<Region> { this };
        }

        public Region ShowInformation()
        {
            //Retorna la información de la región
            return this;
        }

        public int SaveRegion()
        {
            //Lógica para agregar la región a la base de datos
            //Retorna el ID de la región agregada
            return 0;
        }

        public int EditRegion()
        {
            //Lógica para actualizar la región en la base de datos
            //Retorna el ID de la región actualizada
            return 0;
        }   

        public int RemoveRegion()
        {
            return 0;
        }

    }//end class
}//end namespace
