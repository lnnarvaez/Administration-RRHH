using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Domain
{
    public class Individual
    {
            // --- Backing fields ---
            private string _idNumber = string.Empty;
            private string _name = string.Empty;
            private string _surname = string.Empty;
            private DateOnly _birthdate;

            // --- Propiedades con validación encapsulada ---
            public string IdNumber
            {
                get => _idNumber;
                set => _idNumber = !string.IsNullOrWhiteSpace(value)
                    ? value.Trim()
                    : throw new ArgumentException("IdNumber requerido.", nameof(IdNumber));
            }

            public string Name
            {
                get => _name;
                set => _name = !string.IsNullOrWhiteSpace(value)
                    ? value.Trim()
                    : throw new ArgumentException("Name requerido.", nameof(Name));
            }
            public string Surname
            {
                get => _surname;
                set => _surname = !string.IsNullOrWhiteSpace(value)
                    ? value.Trim()
                    : throw new ArgumentException("Surname requerido.", nameof(Surname));
            }

            public DateOnly Birthdate
            {
                get => _birthdate;
                set
                {
                    var max = DateOnly.FromDateTime(DateTime.Today.AddYears(-18));
                    var min = DateOnly.FromDateTime(DateTime.Today.AddYears(-70));

                    _birthdate = (value <= max && value >= min)
                        ? value
                        : throw new ArgumentOutOfRangeException(nameof(Birthdate),
                            $"La fecha debe estar entre {min} y {max}.");
                }
            }

            public string Inss { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string Address { get; set; } = string.Empty;

            //Para el manejo con persistencia
            protected Individual() { }

            // Constructor de dominio
            public Individual(string idNumber, string inss, string name, string surname,
                              DateOnly birthdate, string phone, string address)
            {
                IdNumber = idNumber;   // ← dispara validación del setter
                Inss = inss;
                Name = name;
                Surname = surname;
                Birthdate = birthdate;  // ← dispara validación de edad
                Phone = phone;
                Address = address;
            }
        
    }//end-Class
}//end-namespace
