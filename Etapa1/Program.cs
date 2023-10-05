using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi",2012, TiposEscuela.Primaria, Ciudad: "Bogota", Pais: "Colombia");
                        
            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso(){Nombre = "101"};
            arregloCursos[1] = new Curso(){Nombre = "201"};
            arregloCursos[2] = new Curso(){Nombre = "301"};

            Console.WriteLine(escuela);
            System.Console.WriteLine("==============");
            System.Console.WriteLine($"cursos habilitados en la escuela {escuela.Nombre}");
            ImprimirCursos(arregloCursos);
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre} - ID: {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}