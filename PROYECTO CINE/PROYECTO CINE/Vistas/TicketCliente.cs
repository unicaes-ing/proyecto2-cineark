using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_CINE.Vistas;

namespace PROYECTO_CINE.Vistas
{
    class TicketCliente
    {
        public static int ticketAdulto = 0;
        public static int ticketMayor = 0;
        public static int ticketNiño = 0;
        public static double totalPrecioAdulto = 0;
        public static double totalPrecioMayor = 0;
        public static double totalPrecioNiño = 0;
        public static double totalApagar = 0;
        public static void Ticket()
        {
            Random r = new Random();
            int aleatorio = r.Next(10000, 91239);
            Console.WriteLine("                                            ╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║        ██████╗  ██╗  ███╗   ██╗  ███████╗   █████╗   ██████╗   ██╗  ██       ║");
            Console.WriteLine("                                            ║       ██╔════╝  ██║  ████╗  ██║  ██╔════╝  ██╔══██╗  ██╔══██╗  ██║ ██╔       ║");
            Console.WriteLine("                                            ║       ██║       ██║  ██╔██╗ ██║  █████╗    ███████║  ██████╔╝  █████╔╝       ║");
            Console.WriteLine("                                            ║       ██║       ██║  ██║╚██╗██║  ██╔══╝    ██╔══██║  ██╔══██╗  ██╔═██╗       ║");
            Console.WriteLine("                                            ║       ╚██████╗  ██║  ██║ ╚████║  ███████╗  ██║  ██║  ██║  ██║  ██║  ██       ║");
            Console.WriteLine("                                            ║        ╚═════╝  ╚═╝  ╚═╝  ╚═══╝  ╚══════╝  ╚═╝  ╚═╝  ╚═╝  ╚═╝  ╚═╝  ╚═       ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ║                                                                              ║");
            Console.WriteLine("                                            ╚══════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("DOCUMENTO EQUIVALENTE A FACTURA NÚMERO FCT-" + aleatorio);
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("BOLETO DE ENTRADA A CINEARCK");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("PELICULA: ");
            Console.SetCursorPosition(45, 16);
            Console.WriteLine(MenuCartelera.opc);
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("EN SALA: ");
            Console.SetCursorPosition(45, 20);
            Console.WriteLine(EscogerSala.opcSala);
            Console.SetCursorPosition(50, 19);
            Console.WriteLine("[1]SALA DOBLADA");
            Console.SetCursorPosition(50, 20);
            Console.WriteLine("[2]SALA 3D SUBTITULADA");
            Console.SetCursorPosition(50, 21);
            Console.WriteLine("[3]SALA 3D DOBLADA");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("FECHA: MARTES 8 DE OCTUBRE DE 2019");
            Console.SetCursorPosition(100, 23);
            Console.WriteLine("HORA: 04:35 p.m.");
            Console.SetCursorPosition(45, 26);
            Console.WriteLine("CANT. BOLETOS DE ADULTO");
            Console.SetCursorPosition(45, 27);
            Console.WriteLine(ticketAdulto);
            Console.SetCursorPosition(45, 29);
            Console.WriteLine("CANT. BOLETOS DE ADULTO MAYOR");
            Console.SetCursorPosition(45, 30);
            Console.WriteLine(ticketMayor);
            Console.SetCursorPosition(45, 32);
            Console.WriteLine("CANT. BOLETOS DE NIÑO");
            Console.SetCursorPosition(45, 33);
            Console.WriteLine(ticketNiño);
            Console.SetCursorPosition(60, 34);
            Console.WriteLine("TOTAL DE LA COMPRA:");
            Console.SetCursorPosition(80, 34);
            Console.WriteLine("$ "+totalApagar);







            Console.WriteLine();

        }
        public static void TicketsXpersona(double precioAdulto = 4.25, double precioMayor = 3.25, double PrecioNiño = 2.25)
        {

            Console.WriteLine("TICKET PARA ADULTO -------$4.25");
            Console.WriteLine();
            Console.WriteLine("CUANTOS TICKETS SON PARA ADULTO?");
            ticketAdulto += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("TICKET PARA ADULTO MAYOR-------$3.25");
            Console.WriteLine();
            Console.WriteLine("CUANTOS TICKETS SON PARA ADULTO MAYOR?");
            ticketMayor += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("TICKET PARA NIÑO -------$3.25");
            Console.WriteLine();
            Console.WriteLine("CUANTOS TICKETS SON PARA NIÑO?");
            ticketNiño += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total a pagar por adulto :");
            totalPrecioAdulto = ticketAdulto * precioAdulto;
            Console.WriteLine(totalPrecioAdulto);
            Console.WriteLine();
            Console.WriteLine("Total a pagar por adulto mayor :");
            totalPrecioMayor = ticketMayor * precioMayor;
            Console.WriteLine(totalPrecioMayor);
            Console.WriteLine("Total a pagar por niño: ");
            totalPrecioNiño = ticketNiño * PrecioNiño;
            Console.WriteLine(totalPrecioNiño);
            Console.WriteLine();
            Console.WriteLine("Total a pagar: ");
            totalApagar = totalPrecioAdulto + totalPrecioMayor + totalPrecioNiño;
            Console.WriteLine(totalApagar);

            int totalBoletos = ticketAdulto + ticketMayor + ticketNiño;

            int silla = 0;
            char fila;
            bool[,] butacas = Program.Butacas[EscogerSala.funcion];
            int cont;

            for (int i = 0; i < totalBoletos; i++)
            {
                bool bandera = false;
                do
                {
                    Console.Clear();
                    Vistas.EscogerAsiento.Asiento(butacas);

                    Console.SetCursorPosition(140, 4);
                    Console.WriteLine("INGRESE LA FILA QUE DESEA");
                    Console.SetCursorPosition(140, 5);
                    fila = Convert.ToChar(Console.ReadLine().ToUpper());

                    Console.SetCursorPosition(140, 7);
                    Console.WriteLine("INGRESE LA SILLA QUE DESEA");
                    Console.SetCursorPosition(140, 8);
                    silla = Convert.ToInt32(Console.ReadLine());

                    
                    int cont2 = 0;
                    for (int j = 65; j <= 74; j++)
                    {
                        if (fila == (char)j)
                        {
                            if (butacas[cont2, (silla - 1)] == false)
                            {
                                bandera = true;
                                break;
                            }
                        }
                        cont2++;
                    }

                } while (bandera == false);


                cont = 0;
                for (int j = 65; j <= 74; j++)
                {
                    if (fila == (char)j)
                    {
                        butacas[cont, (silla - 1)] = true;
                        break;
                    }
                    cont++;
                }
            }

            Console.Clear();
            Vistas.EscogerAsiento.Asiento(butacas);

            Console.SetCursorPosition(140, 12);
            Console.WriteLine("PRESIONA <ENTER> CONTINUAR");
            Console.ReadKey();
            Console.Clear();
            //Factura
            Ticket();
            Console.SetCursorPosition(60, 42);
            Console.Write("PRESIONA <ENTER> REGRESAR AL MENÚ PRINCIPAL");
            Console.ReadKey();
            Console.Clear();
            //Menu
            Program.Menus();

        }
    }
}
                               