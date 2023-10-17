using System;
using System.Runtime.InteropServices;
namespace CoreEscuela.entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }// ID unico de cada alumno con private
        public string Nombre { get; set; } // Nombre de la Asignatura

        public Asignatura() => UniqueId = System.Guid.NewGuid().ToString(); // Genera un ID unico para cada alumno
    }
}