using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaración de Variables
            int edad = 33;
            string nombre = "Hugo";
            float sueldo = 8500;
            DateTime hoy = DateTime.Now;
            //Console.WriteLine(edad);
            //Console.WriteLine(nombre);
            //Console.WriteLine(sueldo);
            //Console.WriteLine(hoy);

            //Declaración de objetos
            Persona persona = new Persona();
            persona.Nombres = "Paola";
            persona.Apellidos = "Levano";
            persona.Edad = 34;          

            Persona persona1 = new Persona
            {
                Nombres = "Reyna",
                Apellidos = "Torrico",
                Edad = 5
            };

            List<Persona> personas = new List<Persona>();
            personas.Add(persona);
            personas.Add(persona1);

            foreach (var item in personas)           
            {
                string mensaje = item.EsMayorEdad(18);
                item.AsignarNombresCompletos();

                Console.WriteLine(mensaje);
                Console.WriteLine(item.NombresCompletos);
            }
            
            
                        
            Console.Read();


        }
    }
}
