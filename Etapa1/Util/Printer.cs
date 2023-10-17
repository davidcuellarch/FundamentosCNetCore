using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer// no permite crear instancias de esta clase
    {

        public static void DibujarLinea(int tamano = 20)
        {

            WriteLine("".PadLeft(tamano, '*'));

        }

        public static void WriteTittle(string titulo)
        {
            var tamaño = titulo.Length + 4; // 4 son los espacios en blanco adicionales a la cadena 
            DibujarLinea(tamaño);//utilizo lo de dibujar linea
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }

        public static void BeebSound(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }

    }
}