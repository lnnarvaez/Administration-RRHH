using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administration_RRHH.Models
{
    public class Department
    {
        /* ----------------------------------------------------------- */
        /*            Campos de la clase Department                    */
        /* ----------------------------------------------------------- */

        private string _departmentCode;
        private string _departmentName;
        private string _departmentDescription;
        private bool _isActive;

        /* ----------------------------------------------------------- */
        /*            Métodos de propiedades                           */
        /* ----------------------------------------------------------- */
        public string DepartmentCode 
        { 
            get {
                return _departmentCode; 
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department code cannot be null or empty.");
                }
                _departmentCode = value;
            }
        }

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }
        public string DepartmentDescription { get => _departmentDescription; set => _departmentDescription = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        /* ----------------------------------------------------------- */
        /*                  Constructores                              */
        /* ----------------------------------------------------------- */
        public Department()
        {
            _departmentCode = "DPTO-";  // Valor por defecto, se espera que el código sea asignado posteriormente
            _departmentName = string.Empty;
            _departmentDescription= string.Empty;
            _isActive = true;   // Por defecto, el departamento se considera activo al crearse
        }//end - constructor

        public Department(string departmentCode, string departmentName, 
                          string departmentDescription, 
                          bool isActive)
        {
            if (string.IsNullOrWhiteSpace(departmentCode))
            {
                throw new ArgumentException("Department code cannot be null or empty.");
            }
            _departmentCode = departmentCode;
            _departmentName = departmentName;
            _departmentDescription = departmentDescription;
            _isActive = isActive;
        }//end - constructor

        /* ----------------------------------------------------------- */
        /*                          Métodos                            */
        /* ----------------------------------------------------------- */

        public int AddDepartment()
        {
            // Lógica para agregar el departamento a la base de datos
            // Retorna un código de estado o el ID del departamento agregado
            return 1; // Placeholder, se debe implementar la lógica real
        }

        public int UpdateDepartment()
        {
            // Lógica para actualizar el departamento en la base de datos
            // Retorna un código de estado o el número de registros afectados
            return 1; // Placeholder, se debe implementar la lógica real
        }
         public int DeleteDepartment()
        {
            // Lógica para eliminar el departamento de la base de datos
            // Retorna un código de estado o el número de registros afectados
            return 1; // Placeholder, se debe implementar la lógica real
        }
    }//end - class
}// end - namespace