using System;
using System.Collections.Generic;
using CoreEscuela.entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.DibujarLinea();
            Printer.WriteTittle("BIENVENIDOS A LA ESCUELA");
            Printer.BeebSound(10000, cantidad: 10);
            Printer.DibujarLinea();
            WriteLine(engine.Escuela);
            Printer.DibujarLinea();
            

        }
    }
}

