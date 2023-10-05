namespace CoreEscuela.entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }// ID unico de cada curso con private 
        public string Nombre { get; set; } // Nombre del curso
        public TiposJornada Jornada { get; set; } // Jornada del curso
        public Curso() => UniqueId = System.Guid.NewGuid().ToString(); // Genera un ID unico para cada curso

    }
}