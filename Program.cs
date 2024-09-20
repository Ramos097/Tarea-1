using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Estudiante
    {
        public string Nombre;
        private int Edad;
        public double Promedio;

        
        public Estudiante(string nombre, int edad, double promedio)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Promedio = promedio;
        }

       
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }

        
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Promedio: {Promedio}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            List<Estudiante> estudiantes = new List<Estudiante>();

            
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nIntroduce los datos del estudiante {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Promedio: ");
                double promedio = double.Parse(Console.ReadLine());

               
                Estudiante estudiante = new Estudiante(nombre, edad, promedio);
                estudiantes.Add(estudiante);
            }

            Console.WriteLine("\nEstudiantes con promedio mayor o igual a 70 aprueban:");

            int index = 0;


            while (index < estudiantes.Count)
            {
                Estudiante estudiante = estudiantes[index];

                if (estudiante.Promedio >= 70)
                {
                    estudiante.MostrarInfo();
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    estudiante.MostrarInfo();
                    Console.WriteLine("Reprobado");
                }


                    if (estudiante.EsMayorDeEdad())
                {
                    Console.WriteLine($"{estudiante.Nombre} es mayor de edad.");
                }
                else
                {
                    Console.WriteLine($"{estudiante.Nombre} no es mayor de edad.");
                }
                

                index++;
            }
            Console.WriteLine("\nPresiona cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
}