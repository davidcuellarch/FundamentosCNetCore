using System;
using System.Runtime.InteropServices;
namespace CoreEscuela.entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }// ID unico de cada alumno con private
        public string Nombre { get; set; } // Nombre del alumno

        public List<Evaluaciones> Evaluaciones { get; set; } // arreglo de evaluaciones
        
        public Alumno(){
            UniqueId = System.Guid.NewGuid().ToString(); // Genera un ID unico para cada alumno
            this.Evaluaciones = new List<Evaluaciones>();
        }
    }
}