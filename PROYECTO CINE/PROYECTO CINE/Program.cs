using System;
using System.IO;
using System.Runtime.InteropServices;
using PROYECTO_CINE.Vistas;
using System.Collections;
using System.Collections.Generic;

//ANDY ROLDAN
//CARLOS CASTANEDA
//RODRIGO VALIENTE
//LUIS ALFONZO

namespace PROYECTO_CINE
{
    class Program
    {
        public static List<bool[,]> Butacas = new List<bool[,]> { new bool[10,10], new bool[10, 10], new bool[10, 10] };
        public static string nombre;
        int opc;
        public static void MenuInicial()
       {
            Console.WriteLine("                                    ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;          ");
            Console.WriteLine("                                   ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;          ");
            Console.WriteLine("                                  ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;         ");
            Console.WriteLine("                                 ;:::::                                                                                    :::::;        ");
            Console.WriteLine("                               ;::::::   :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::   :::::;       ");
            Console.WriteLine("                             ;:::::::   :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::    :::::;     ");
            Console.WriteLine("                             ;::::::   ::::::::                                                                     ::::::::   ::::::;     ");
            Console.WriteLine("                             ;:::::   :::::::::                                                                     :::::::::   :::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::   ::::::::::                                                                     ::::::::::   ::::;     ");
            Console.WriteLine("                             ;::::    :::::::::                                                                     :::::::::   :::::;     ");
            Console.WriteLine("                             ;::::::   ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::   ::::::;      ");
            Console.WriteLine("                               ;:::::   ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::   :::::;      ");
            Console.WriteLine("                                ;:::::                                                                                      :::::;        ");
            Console.WriteLine("                                 ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;         ");
            Console.WriteLine("                                  ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;          ");
            Console.WriteLine("                                  ;::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::;           ");
        }
        static void Main(string[] args)
        {
            Menus();
            
            
        }

        public static void Menus()
        {
         
                MenuInicial();
                Console.SetCursorPosition(70, 7);
                Console.WriteLine("SELECIONA UNA OPCIÓN");
                Console.SetCursorPosition(65, 9);
                Console.WriteLine("[1]------------DESPACHO DE BOLETOS");
                Console.SetCursorPosition(65, 11);
                Console.WriteLine("[2]------------ESTADÍSTICAS DE VENTA");
                Console.SetCursorPosition(65, 13);
                Console.WriteLine("[3]------------CONFIGURACIÓN DE CINEARK");
                Console.SetCursorPosition(65, 15);
                Console.WriteLine("[4]------------SALIR ");
            int opc;
            do
            {
                Console.SetCursorPosition(60, 20);
                Console.WriteLine("ESCRIBE EL NÚMERO DE LA OPCIÓN");
                Console.SetCursorPosition(60, 21);
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        VentaBoletos();
                        break;
                    case 2:
                        Console.Clear();
                        Estadisticas();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Configuracion();
                        break;
                    case 4:
                        Console.Clear();
                        Environment.Exit(0);
                        
                        break;
                }
            } while (opc < 1 || opc > 4);
               
        
               
            
                
            
        }
        public static void VentaBoletos()
        {
            string nombre;
            Random r = new Random();
            int a = r.Next(0, 9);
            int b = r.Next(0, 9);
            int c = r.Next(0, 9);
            int d = r.Next(0, 9);
            int e = r.Next(0, 9);
            int f = r.Next(0, 9);

            string title = "---------------- CINEARK ® ----------------";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine();
            MenuInicial();
            /////
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(56, 9);
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(56, 10);
            Console.WriteLine("║                                                        ║");
            Console.SetCursorPosition(56, 11);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(49, 10);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(57, 10);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            nombre = Console.ReadLine();
            /////
            Console.SetCursorPosition(55, 22);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("T  A  R  J  E  T  A    C  L  U  B    C  I  N  E  A  R  K");
            Console.SetCursorPosition(60, 14);
            Console.WriteLine("M á s   v i e n e s ,   m á s   g a n a s");
            Console.SetCursorPosition(66, 16);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.SetCursorPosition(66, 17);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(66, 18);
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.SetCursorPosition(68, 17);
            Console.WriteLine("T  C  C  A  R  K  - {0}   {1}   {2}   {3}   {4}   {5}", a, b, c, d, e, f);
            Console.WriteLine();
            Console.ResetColor();
            Console.SetCursorPosition(70, 24);
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.SetCursorPosition(70, 25);
            Console.WriteLine("║                                         ║");
            Console.SetCursorPosition(70, 26);
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.SetCursorPosition(60, 25);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("»»»»»»»»»»»» S  U  P  E  R   F  A  N  Á  T  I  C  O");
            /////
            Console.SetCursorPosition(60, 35);
            Console.WriteLine("Presione [ENTER] para continuar...");
            Console.SetCursorPosition(96, 35);
            Console.ReadKey();
            MenuCartelera.Cartelera();
            Console.ReadKey();


        }

        public static void Estadisticas()
        {
            MenuInicial();
            Console.SetCursorPosition(65, 7);
            Console.WriteLine("TOTAL DE TICKETS VENDIDOS DE ADULTO");
            Console.SetCursorPosition(65, 8);
            Console.WriteLine(TicketCliente.ticketAdulto);
            Console.WriteLine();
            Console.SetCursorPosition(65, 10);
            Console.WriteLine("TOTAL DE TICKETS VENDIDOS DE ADULTO MAYOR");
            Console.SetCursorPosition(65, 11);
            Console.WriteLine(TicketCliente.ticketMayor);
            Console.WriteLine();
            Console.SetCursorPosition(65, 13);
            Console.WriteLine("TOTAL DE TICKETS VENDIDOS DE NIÑO");
            Console.SetCursorPosition(65, 14);
            Console.WriteLine(TicketCliente.ticketNiño);
            Console.WriteLine();
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("TOTAL DE INGRESOS AL CINE");
            Console.SetCursorPosition(65, 17);
            Console.WriteLine("$" + TicketCliente.totalApagar);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(55, 22);
            Console.Write("PRESIONE <ENTER> PARA VOLVER AL MENÚ PRINCIPAL");
            Console.ReadKey();
            Console.Clear();
            Menus();

             
            
        }
        /*Butacas[0] = new bool[10, 10];*/
        public static void Configuracion()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRESIONA [1] PARA RESETEAR TODOS LOS BOLETOS");           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("DIGITA EL NÚMERO DE LA ACCIÓN ");
            int reset = Convert.ToInt32(Console.ReadLine());
            switch (reset)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("RESETEADO SATISFACTORIAMENTE");
                    TicketCliente.ticketAdulto = 0;
                    TicketCliente.ticketMayor = 0;
                    TicketCliente.ticketNiño = 0;
                    TicketCliente.totalApagar = 0;
                    break;
                case 2:
                    Console.WriteLine("RESETEADO SATISFACTORIAMENTE");
                    Butacas[EscogerSala.funcion] = new bool[10, 10];
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("PRESIONE <ENTER> PARA VOLVER AL MENÚ PRINCIPAL");
            Console.ReadKey();
            Console.Clear();
            Menus();
            
        }
    } 

}
