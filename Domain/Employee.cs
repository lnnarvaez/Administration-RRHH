using Administration_RRHH.Services.Persistence;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq; 
using System.Text.Json;

namespace Administration_RRHH.Domain
{
    public class Employee : Individual
    {

        #region Propiedades
        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Propiedades                            */
        /* -------------------------------------------------------------------------- */

        public int MunicipalityId { get; set; }
        public int MaritalStatusId { get; set; }
        public string Inss { get; set; }
        public string Email { get; set; }
        public int NumberChildren { get; set; }
        public bool IsActive { get; set; }

        #endregion

        #region Constructores
        /* -------------------------------------------------------------------------- */
        /*                      Declaración de Constructor                           */
        /* -------------------------------------------------------------------------- */
        public Employee() { }

        public Employee(string inss, string email, bool isActive, int numberChildren,
                        string idNumber, string name, string surname, DateOnly birthdate,
                        string phone, string address) :
                        base(idNumber, name, surname, birthdate, phone, address)
        {
            Inss = inss;
            Email = email;
            IsActive = isActive;
            NumberChildren = numberChildren;
        }

        #endregion
        /* -------------------------------------------------------------------------- */
        /*                           Declaración de Método                            */
        /* -------------------------------------------------------------------------- */

        /// <summary>
        /// Valida que la fecha de nacimiento del empleado no sea una fecha futura.
        /// </summary>
        /// <returns>Verdadero si la fecha es válida, falso en caso contrario</returns>
        public override bool ValidateBirthDate()
        {
            // Validar que la fecha de nacimiento no sea una fecha futura
            if (BirthDate > DateOnly.FromDateTime(DateTime.Today))
            {
                return false; // La fecha de nacimiento es inválida
            }
            return true; // La fecha de nacimiento es válida
        }

        public int InsertEmployee  ()
        {
            using InsertCommand insert = new InsertCommand(); //Crear instancia de comando de
                                                              //inserción para ejecutar la consulta SQL
            string sql = @"INSERT INTO Employee (Municipality_id, MaritalStatus_id, IdNumber, Inns, Names, Surname,
                                                Birthdate, NumberChildren, Email, Phone, Address) 
                          VALUES (@Municipality_id, @MaritalStatus_id, @IdNumber, @Inss, @Names, @Surname,
                                                @Birthdate, @NumberChildren, @Email, @Phone, @Address)";

            SqlParameter[] parametros = {
                                            new SqlParameter("@Municipality_id",   SqlDbType.Int) { Value = this.MunicipalityId },
                                            new SqlParameter("@MaritalStatus_id",   SqlDbType.Int) { Value = this.MaritalStatusId },
                                            new SqlParameter("@IdNumber", SqlDbType.NVarChar,  20) { Value = this.IdNumber },        
                                            new SqlParameter("@Inss", SqlDbType.NVarChar,  20) { Value = this.Inss },
                                            new SqlParameter("@Names", SqlDbType.NVarChar,  100) { Value = this.Name },
                                            new SqlParameter("@Surname", SqlDbType.NVarChar,  100) { Value = this.Surname },
                                            new SqlParameter("@Birthdate", SqlDbType.Date) { Value = this.BirthDate },
                                            new SqlParameter("@NumberChildren", SqlDbType.Int) { Value = this.NumberChildren },
                                            new SqlParameter("@Email", SqlDbType.NVarChar,  150) { Value = this.Email },
                                            new SqlParameter("@Phone", SqlDbType.NVarChar,  20) { Value = this.Phone },
                                            new SqlParameter("@Address", SqlDbType.NVarChar,  200) { Value = this.Address }
            };

            return insert.ExecuteInsert (sql, parametros); //Ejecutar la consulta de inserción y retornar el número de filas afectadas
        }   

        /// <summary>
        /// Lee el registro de un empleado especificado por su número de cédula
        /// </summary>
        /// <param name="idNumber">Número de cédula para filtrar al empleado</param>
        /// <returns>Empleado identificado por cédula. Null sino se encuentra</returns>
        public Employee GetEmployeeIdNumber (int idNumber)
        {
            return new Employee(); //Temporal mientras se defien BD
        }

        /// <summary>
        /// Lista un set de Empleados, segmentados por bloques de páginación 10 en 10
        /// </summary>
        /// <returns>Listado de Empleados ordenados de forma descendente por fecha de ingreso</returns>
        public List <Employee> ListEmployee ()
        { 
            return new List<Employee>(); // Pendiente de implementación con la base de datos
        }

        /// <summary>
        /// Modifica el registro de un empleado especificado por su número de cédula. 
        /// El método recibe el número de cédula del empleado a modificar y los nuevos 
        /// datos del empleado.
        /// </summary>
        /// <param name="idNumber"></param>
        public void ModifyEmployee (string idNumber)
        {
            // Pendiente de implementación con la base de datos
        }

        /// <summary>
        /// Deshabilita el registro de un empleado especificado por su número de cédula.
        /// </summary>
        /// <param name="idNumber"></param>
        public void DisableEmployee(string idNumber)
        {
            // Pendiente de implementación con la base de datos
        }   

    }//end-class
}//end-namespace