using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {

        //Atributos
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }

        public int Edad { get; set; }

        //Métodos
        //Función
        public string EsMayorEdad(int edadMinima)
        {
            string mensaje = "Es menor de Edad";
            if (Edad>edadMinima)            
                mensaje = "Es Mayor de Edad";
            return mensaje;            
        }
        //Procedimientos
        public void AsignarNombresCompletos()
        {
            NombresCompletos = string.Concat(Nombres, " ", Apellidos);
        }







    }
}