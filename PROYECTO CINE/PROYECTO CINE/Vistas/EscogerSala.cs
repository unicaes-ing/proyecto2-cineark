using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_CINE.Vistas;

namespace PROYECTO_CINE.Vistas
{
    class EscogerSala
    {
        public static int opcSala;
        public static int funcion;
        private static bool valido;
        public static void Sala()
        {
            do
            {
                string title = "---------------- CINEARK ® ----------------";
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title);
                Program.MenuInicial();
                Console.SetCursorPosition(70, 10);
                Console.WriteLine("-------SALAS DISPONIBLES--------");
                Console.SetCursorPosition(65, 13);
                Console.WriteLine("[1]------------------SALA DOBLADA.");
                Console.SetCursorPosition(65, 15);
                Console.WriteLine("[2]------------------SALA 3D SUBTITULADA");
                Console.SetCursorPosition(65, 17);
                Console.WriteLine("[3]------------------SALA 3D DOBLADA");


                Console.SetCursorPosition(50, 20);
                Console.WriteLine("SELECCIONE UNA SALA");
                Console.SetCursorPosition(50, 21);
                valido = int.TryParse(Console.ReadLine(), out opcSala);
            } while (valido == false || opcSala < 1 || opcSala > 3);

            do
            {
                Console.Clear();
                switch (opcSala)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine();
                        AsciiSala3Ddob();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Program.MenuInicial();
                        Console.SetCursorPosition(65, 20);
                        Console.WriteLine("SELECCIONA  LA FUNCIÓN QUE DESEAS ");
                        Console.SetCursorPosition(50, 22);
                        Console.WriteLine("ESCRIBIR '1' PARA LA FUNCIÓN DE LAS  ------------00:05HRS");
                        Console.SetCursorPosition(50, 24);
                        Console.WriteLine("ESCRIBIR '2' PARA LA FUNCIÓN DE LAS  ------------10:30HRS");
                        Console.SetCursorPosition(50, 26);
                        Console.WriteLine("ESCRIBIR '3' PARA LA FUNCIÓN DE LAS  ------------21:45HRS");
                        Console.WriteLine();



                        break;
                    case 2:

                        Console.WriteLine();
                        Console.WriteLine();
                        AsciiSala3Dsub();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Program.MenuInicial();
                        Console.SetCursorPosition(65, 20);
                        Console.WriteLine("SELECCIONA  LA FUNCIÓN QUE DESEAS ");
                        Console.SetCursorPosition(50, 22);
                        Console.WriteLine("ESCRIBIR '1' PARA LA FUNCIÓN DE LAS  ------------12:15HRS");
                        Console.SetCursorPosition(50, 24);
                        Console.WriteLine("ESCRIBIR '2' PARA LA FUNCIÓN DE LAS  ------------13:30HRS");
                        Console.SetCursorPosition(50, 26);
                        Console.WriteLine("ESCRIBIR '3' PARA LA FUNCIÓN DE LAS  ------------15:45HRS");


                        break;
                    case 3:

                        Console.WriteLine();
                        Console.WriteLine();
                        AsciiSalaDob();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Program.MenuInicial();
                        Console.SetCursorPosition(65, 20);
                        Console.WriteLine("SELECCIONA  LA FUNCIÓN QUE DESEAS ");
                        Console.SetCursorPosition(50, 22);
                        Console.WriteLine("ESCRIBIR '1' PARA LA FUNCIÓN DE LAS  ------------14:45HRS");
                        Console.SetCursorPosition(50, 24);
                        Console.WriteLine("ESCRIBIR '2' PARA LA FUNCIÓN DE LAS ------------22:30HRS");
                        Console.SetCursorPosition(50, 26);
                        Console.WriteLine("ESCRIBIR '3' PARA LA FUNCIÓN DE LAS ------------22:30HRS");
                        break;
                }

                Console.SetCursorPosition(50, 29);
                Console.WriteLine("SELECCIONE UNA FUNCIÓN.");
                Console.SetCursorPosition(50, 30);
                valido = int.TryParse(Console.ReadLine(), out funcion);

            } while (valido == false || funcion < 1 || funcion > 3);

            funcion -= 1;
            
                Console.SetCursorPosition(60, 34);
                Console.WriteLine("PRESIONA <ENTER> PARA RESERVAR TUS ASIENTOS");
                Console.SetCursorPosition(60, 35);
                Console.ReadLine();
                Console.Clear();
                Vistas.TicketCliente.TicketsXpersona();
                Console.ReadLine();
                Console.Clear();
            
            
        }
        public static void AsciiSala3Ddob()
        {
          Console.WriteLine("                                       ███████╗ █████╗ ██╗      █████╗     ██████╗ ██████╗     ██████╗  ██████╗ ██████╗ ");
          Console.WriteLine("                                       ██╔════╝██╔══██╗██║     ██╔══██╗    ╚════██╗██╔══██╗    ██╔══██╗██╔═══██╗██╔══██╗");
          Console.WriteLine("                                       ███████╗███████║██║     ███████║     █████╔╝██║  ██║    ██║  ██║██║   ██║██████╔╝");
          Console.WriteLine("                                       ╚════██║██╔══██║██║     ██╔══██║     ╚═══██╗██║  ██║    ██║  ██║██║   ██║██╔══██╗");
          Console.WriteLine("                                       ███████║██║  ██║███████╗██║  ██║    ██████╔╝██████╔╝    ██████╔╝╚██████╔╝██████╔╝");
          Console.WriteLine("                                       ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝    ╚═════╝ ╚═════╝     ╚═════╝  ╚═════╝ ╚═════╝ ");
       
        }
        public static  void AsciiSala3Dsub()
        {
            Console.WriteLine("                                     ███████╗ █████╗ ██╗      █████╗     ██████╗ ██████╗     ███████╗██╗   ██╗██████╗ ");
            Console.WriteLine("                                     ██╔════╝██╔══██╗██║     ██╔══██╗    ╚════██╗██╔══██╗    ██╔════╝██║   ██║██╔══██╗");
            Console.WriteLine("                                     ███████╗███████║██║     ███████║     █████╔╝██║  ██║    ███████╗██║   ██║██████╔╝");
            Console.WriteLine("                                     ╚════██║██╔══██║██║     ██╔══██║     ╚═══██╗██║  ██║    ╚════██║██║   ██║██╔══██╗");
            Console.WriteLine("                                     ███████║██║  ██║███████╗██║  ██║    ██████╔╝██████╔╝    ███████║╚██████╔╝██████╔╝");
            Console.WriteLine("                                     ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝    ╚═════╝ ╚═════╝     ╚══════╝ ╚═════╝ ╚═════╝ ");
        }
        public static void AsciiSalaDob()
        {
            Console.WriteLine("                                     ███████╗ █████╗ ██╗      █████╗     ██████╗  ██████╗ ██████╗ ██╗      █████╗ ██████╗  █████╗ ");
            Console.WriteLine("                                     ██╔════╝██╔══██╗██║     ██╔══██╗    ██╔══██╗██╔═══██╗██╔══██╗██║     ██╔══██╗██╔══██╗██╔══██╗");
            Console.WriteLine("                                     ███████╗███████║██║     ███████║    ██║  ██║██║   ██║██████╔╝██║     ███████║██║  ██║███████║");
            Console.WriteLine("                                     ╚════██║██╔══██║██║     ██╔══██║    ██║  ██║██║   ██║██╔══██╗██║     ██╔══██║██║  ██║██╔══██║");
            Console.WriteLine("                                     ███████║██║  ██║███████╗██║  ██║    ██████╔╝╚██████╔╝██████╔╝███████╗██║  ██║██████╔╝██║  ██║");
            Console.WriteLine("                                     ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝");
        }   
    }
}
