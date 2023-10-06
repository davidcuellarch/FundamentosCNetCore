using System;
using CoreEscuela.entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi", 2012, TiposEscuela.Primaria, Ciudad: "Bogota", Pais: "Colombia");

            escuela.Cursos = new Curso[] // arreglo de cursos 
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };
            
            ImprimirCursosEscuela(escuela);

            


            
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("==================");
            WriteLine("Cursos de la escuela");
            WriteLine("==================");
            if (escuela?.Cursos != null)// valida que la escuela y los cursos no sean nulos el operador ? es para validar que no sea nulo
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre} - ID: {curso.UniqueId}");// for each para imprimir los cursos
                }
            }
            else
            {
                WriteLine("No hay cursos");
            }


        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Nombre} - ID: {curso.UniqueId}");// for each para imprimir los cursos
            }

        }
    }
}