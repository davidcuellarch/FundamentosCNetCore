﻿using System;
using CoreEscuela.entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012);
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogotá";
            Console.WriteLine(escuela.Nombre+" " +escuela.AñoDeCreacion +" " + escuela.Pais + " " + escuela.Ciudad);
        }
    }
}