using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_CINE.Vistas;

namespace PROYECTO_CINE.Vistas
{
    class EscogerAsiento
    {

        public static void Asiento(bool[,] butacas)
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       J   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       I   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       H   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       G   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       F   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       E   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       D   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       C   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       B   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║             1           2           3           4           5           6           7           8           9           10          ║");
            Console.WriteLine("║           ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄      ▄    ▄        ║");
            Console.WriteLine("║       A   ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████      ██████        ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                                     ║");
            Console.WriteLine("║                                                       PANTALLA                                                                      ║");
            Console.WriteLine("║                         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                    ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            int x = 12, y = 38, y2 = 39;

            for (int i = 0; i < butacas.GetLength(0); i++)
            {
                for (int j = 0; j < butacas.GetLength(1); j++)
                {
                    if (butacas[i,j] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(x + (j * 12), y - (i * 4));
                        Console.WriteLine("▄    ▄");
                        Console.SetCursorPosition(x + (j * 12), y2 - (i * 4));
                        Console.WriteLine("██████");
                    }
                    Console.SetCursorPosition(x + (j * 12), y - (i * 4));
                    Console.WriteLine("▄    ▄");
                    Console.SetCursorPosition(x + (j * 12), y2 - (i * 4));
                    Console.WriteLine("██████");
                    Console.ResetColor();
                }
            }
        }
        

    }
}
