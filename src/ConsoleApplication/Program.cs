//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        private static int count = 0;
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            Train t1= new Train ("Last Train To London");
            Train t2= new Train ("Last Train To London");
            Train t3= new Train ("Runaway Train");
            

            while (Program.count <= 100)
            {
                var Train = new Train("t");
                Console.WriteLine($"Contador Program: {Program.count}");
                Program.count++;
            }
        }
    }
}