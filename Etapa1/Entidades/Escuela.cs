namespace CoreEscuela.entidades
{
    class Escuela 
    {
        string nombre = "";
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; } = "";
        public string Ciudad { get; set; } = "";

        public TiposEscuela TipoEscuela { get; set; }// este es un tipo de dato enumerado que se encuentra en TiposEscuelas.cs

        public Escuela (string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

         public Escuela (string nombre, int año, 
                            TiposEscuela tipo, string Pais = "", 
                            string Ciudad = "") 
         {
            
            (Nombre, AñoDeCreacion) = (nombre, año);// asignacion de tuplas 
            this.Pais = Pais;
            this.Ciudad = Ciudad;
            
         }
      
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\"{System.Environment.NewLine}Fundación: {AñoDeCreacion} {System.Environment.NewLine}Tipo: {TipoEscuela} {System.Environment.NewLine}Pais: {Pais} {System.Environment.NewLine}Ciudad: {Ciudad}";
        }
        

    }
} // END: abpxx6d04wxr