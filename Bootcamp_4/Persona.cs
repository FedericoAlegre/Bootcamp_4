using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_4
{
    class Persona
    {
        protected string nombre;
        protected int edad;
        protected int dni;

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public override string ToString()
        {
            return $"\nNombre: {Nombre}\nEdad: {Edad}\nDNI: {Dni}";
        }
        
        public bool EsMayorDeEdad()
        {
            if (Edad > 18) return true;
            else return false;
        }
    }
}
