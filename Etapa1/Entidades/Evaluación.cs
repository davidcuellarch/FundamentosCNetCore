using System;
using System.Runtime.InteropServices;
namespace CoreEscuela.entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }// ID unico de cada alumno con private
        public string Nombre { get; set; } // Nombre del alumno

        public Alumno Alumno { get; set; } // Nombre del alumno que presenta la evaluacion
        public Asignatura Asignatura { get; set; } // Nombre de la asignatura relacionada a la evaluación

        public float Nota { get; set; } // Nota de la evaluación

        public Evaluaciones() => UniqueId = System.Guid.NewGuid().ToString(); // Genera un ID unico para cada alumno
    }
}