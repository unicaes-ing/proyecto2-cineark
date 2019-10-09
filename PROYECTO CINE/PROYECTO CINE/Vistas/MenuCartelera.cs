using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_CINE.Vistas;

namespace PROYECTO_CINE
{
    class MenuCartelera
    {
        public static int opc;
        public static bool peli;
        public static void Cartelera()
        {           
           
            
           
                Console.Clear();
                string title = "---------------- CINETICKET ® ----------------";
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title);
                Console.WriteLine();
                Console.WriteLine();
                Program.MenuInicial();
                Console.SetCursorPosition(65, 10);
                Console.WriteLine("----------CARTELERA----------");
                Console.SetCursorPosition(60, 11);
                Console.WriteLine("...... 1. CAPITANA MARVEL ( +12 )");
                Console.SetCursorPosition(60, 12);
                Console.WriteLine("...... 2. ESO: PARTE 2 ( +15 )");
                Console.SetCursorPosition(60, 13);
                Console.WriteLine("...... 3. DUMBO ( Todo Público )");
                Console.SetCursorPosition(60, 14);
                Console.WriteLine("...... 4. DORA Y LA CIUDAD PERDIDA ( Todo público )");
                Console.SetCursorPosition(60, 15);
                Console.WriteLine("...... 5. ANABELLE 3 ( +12 )");
                Console.SetCursorPosition(60, 16);
                Console.WriteLine("...... 6. AVENGERS: END GAME ( +15 )");
                Console.SetCursorPosition(60, 17);
                Console.WriteLine("...... 7. REGRESAR AL MENÚ PRINCIPAL");
            Console.SetCursorPosition(50, 20);
            Console.WriteLine("QUE PELÍCULA DESEAS VER?");
            Console.SetCursorPosition(50, 21);


            do
            {
                if (int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            
                            string title1 = "---------------- CINEARK ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title1.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title1);
                            Console.WriteLine();
                            AsciiCapMArvel();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN B (PARA MAYORES DE 12 AÑOS)");
                            Console.WriteLine("ACCION Y AVENTURA");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("AMBIENTADA EN LA DECADA DE 1990, CAPITANA MARVEL DE MARVEL STUDIOS NOS \nPRESENTA UNA ORIGINAL Y NUEVA AVENTURA SITUADA EN UN PERIODO NUNCA ANTES VISTO EN \nEL UNIVERSO CINEMATOGRAFICO DE MARVEL. LA HISTORIA SIGUE A CAROL DANVERS, A QUIEN \nVEREMOS CONVERTIRSE EN UNA DE LAS HEROÍNAS MAS PODEROSAS DEL UNIVERSO CUANDO LA \nTIERRA QUEDA ATRAPADA EN MEDIO DE UNA GUERRA GALÁCTICA ENTRE DOS RAZAS ALIENÍGENAS");
                            Console.WriteLine();
                            Console.WriteLine("CRÉDITOS Y REPARTO: \nACTORES: BRIE LARSON, SAMUEL L. JACKSON. \nDIRECTORES: ANNA BODEN, RYAN FLECK.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 2:
                            string title2 = "---------------- CINEARK ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title2.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title2);
                            AsciiEso2();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN B (PARA MAYORES DE 18 AÑOS)");
                            Console.WriteLine("TERROR Y SUSPENSO");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("EN EL MISTERIOSO PUEBLO DE DERRY, UN MALVADO PAYASO LLAMADO PENNYWISE \nVUELVE 27 AÑOS DESPUÉS PARA ATORMENTAR A LOS YA ADULTOS MIEMBROS DEL CLUB DE LOS PERDEDORES QUE AHORA ESTAN MAS ALEJADOS UNO DE OTROS \nHASTA QUE UNA DEVASTADORA LLAMADA TELEFÓNICA LOS OBLIGA REGRESAR A DERRY");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 3:
                            string title3 = "---------------- CINEARK ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title3.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title3);
                            AsciiDumbo();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN A (PARA TODO PUBLICO)");
                            Console.WriteLine("FANTASIA Y AVENTURA");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("EL DUEÑO DE UN CIRCO EN APRIETOS CONTRATA A UN HOMBRE CON Y SUS DOS HIJOS PARA CUIDAR UN ELEFANTE RECIEN NACIDO QUE PUEDE VOLAR \nEL CIRCO SE RECUPERA INCREÍBLEMENTE, ATRAYENDO AL EMPRESARIO VANDEVERE QUIEN RECLUTA AL PECULIAR PAQUIDERMO PARA SU NUEVA AVENTURA DE ENTRETENIMIENTO, LA MÁS GRANDE DE LA VIDA ");
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 4:
                            string title4 = "---------------- CINEARK ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title4.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title4);
                            AsciiDora();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN A (PARA TODO PÚBLICO)");
                            Console.WriteLine("ACCION Y AVENTURA");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("DORA SE PONE AL FRENTE DE UN EQUIPO FORMADO POR SU AMIGO PELUDO BOTAS \nDIEGO, UN MISTERIOSO HABITANTE DE LA JUNGLA Y UN DESORGANIZADO GRUPO DE ADOLESCENTES \nEN UNA AVENTURA EN LA QUE DEBEN SALVAR A LOS PADRES DE DORA Y RESOLVER EL MISTERIO OCULTO TRAS UNA CIUDAD PERDIDA DE ORO.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 5:
                            string title5 = "---------------- CINEARK ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title5.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title5);
                            AsciiAnabelle();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN C (PARA MAYORES DE 18 AÑOS)");
                            Console.WriteLine("TERROR SOBRENATURAL, DRAMA Y MISTERIO");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("ED Y LORRAINE WARREN TRATAN DE ENCERRAR BAJO LLAVE A ANABELLE UNA MUÑECA POSEIDA \nCOMO DEMONOLOGOS LA COLOCARAN EN UNA VITRINA BENDECIDA COMO MEDIDA DE SEGURIDAD \nSIN EMBARGO, UNA NOCHE TERRORIFICA ANABELLE DEPERTARAN A OTROS ESPIIRITUS MALIIGNOS QUE SE ENCUENTRAN EN LA HABITACION Y QUE TENDRAN UNA NUEVA FIJACION \nLA HIJA PEQUEÑA DEL MATRIMONIO Y SUS AMIGOS. ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 6:
                            string title6 = "---------------- CINETICKET ® ----------------";
                            Console.SetCursorPosition((Console.WindowWidth - title6.Length) / 2, Console.CursorTop);
                            Console.WriteLine(title6);
                            AsciiAvengers();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("CLASIFICACIÓN B (PARA MAYORES DE 12 AÑOS)");
                            Console.WriteLine("ACCION Y CIENCIA FICCION");
                            Console.WriteLine();
                            Console.WriteLine("SINOPSIS");
                            Console.WriteLine("LOS VENGADORES RESTANTES DEBEN ENCONTRAR UNA MANERA DE RECUPERAR A SUS ALIADOS PARA UN ENFRENTAMIENTO EPICO CON THANOS \nEL MALVADO QUE DIEZMO EL PLANETA Y EL UNIVERSO.");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("PRESIONA <ENTER> PARA ESCOGER UNA SALA");
                            Console.ReadLine();
                            Console.Clear();
                            Vistas.EscogerSala.Sala();
                            break;
                        case 7:
                            Program.Menus();

                            break;


                    }
                }
                else
                {
                    Console.SetCursorPosition(80, 20);
                    Console.WriteLine("ESCRIBE UN NUMERO VALIDO");
                    Console.SetCursorPosition(50, 21);
                }

            } while (true);
                
            
           
        }

        public static void AsciiCapMArvel()
        {
            Console.WriteLine("                                ██████╗ █████╗ ██████╗ ██╗████████╗ █████╗ ███╗   ██╗ █████╗     ███╗   ███╗ █████╗ ██████╗ ██╗   ██╗███████╗██╗     ");
            Console.WriteLine("                               ██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗  ██║██╔══██╗    ████╗ ████║██╔══██╗██╔══██╗██║   ██║██╔════╝██║     ");
            Console.WriteLine("                               ██║     ███████║██████╔╝██║   ██║   ███████║██╔██╗ ██║███████║    ██╔████╔██║███████║██████╔╝██║   ██║█████╗  ██║     ");
            Console.WriteLine("                               ██║     ██╔══██║██╔═══╝ ██║   ██║   ██╔══██║██║╚██╗██║██╔══██║    ██║╚██╔╝██║██╔══██║██╔══██╗╚██╗ ██╔╝██╔══╝  ██║     ");
            Console.WriteLine("                               ╚██████╗██║  ██║██║     ██║   ██║   ██║  ██║██║ ╚████║██║  ██║    ██║ ╚═╝ ██║██║  ██║██║  ██║ ╚████╔╝ ███████╗███████╗");
            Console.WriteLine("                                ╚═════╝╚═╝  ╚═╝╚═╝     ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝    ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝╚══════╝");

        }
        public static void AsciiEso2()
        {
            Console.WriteLine("                               ███████╗███████╗ ██████╗        ██████╗  █████╗ ██████╗ ████████╗███████╗    ██████╗ ");
            Console.WriteLine("                               ██╔════╝██╔════╝██╔═══██╗██╗    ██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝    ╚════██╗");
            Console.WriteLine("                               █████╗  ███████╗██║   ██║╚═╝    ██████╔╝███████║██████╔╝   ██║   █████╗       █████╔╝");
            Console.WriteLine("                               ██╔══╝  ╚════██║██║   ██║██╗    ██╔═══╝ ██╔══██║██╔══██╗   ██║   ██╔══╝      ██╔═══╝ ");
            Console.WriteLine("                               ███████╗███████║╚██████╔╝╚═╝    ██║     ██║  ██║██║  ██║   ██║   ███████╗    ███████╗");
            Console.WriteLine("                               ╚══════╝╚══════╝ ╚═════╝        ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝    ╚══════╝");
        }      
        public static void AsciiDumbo()
        {
               Console.WriteLine("                            ██████╗ ██╗   ██╗███╗   ███╗██████╗  ██████╗ ");
               Console.WriteLine("                            ██╔══██╗██║   ██║████╗ ████║██╔══██╗██╔═══██╗");
               Console.WriteLine("                            ██║  ██║██║   ██║██╔████╔██║██████╔╝██║   ██║");
               Console.WriteLine("                            ██║  ██║██║   ██║██║╚██╔╝██║██╔══██╗██║   ██║");
               Console.WriteLine("                            ██████╔╝╚██████╔╝██║ ╚═╝ ██║██████╔╝╚██████╔╝");
               Console.WriteLine("                            ╚═════╝  ╚═════╝ ╚═╝     ╚═╝╚═════╝  ╚═════╝ ");
        }
        public static void AsciiDora()
        {
            Console.WriteLine("                               ██████╗  ██████╗ ██████╗  █████╗        ████████╗██╗  ██╗███████╗    ███╗   ███╗ ██████╗ ██╗   ██╗██╗███████╗");
            Console.WriteLine("                               ██╔══██╗██╔═══██╗██╔══██╗██╔══██╗██╗    ╚══██╔══╝██║  ██║██╔════╝    ████╗ ████║██╔═══██╗██║   ██║██║██╔════╝");
            Console.WriteLine("                               ██║  ██║██║   ██║██████╔╝███████║╚═╝       ██║   ███████║█████╗      ██╔████╔██║██║   ██║██║   ██║██║█████╗  ");
            Console.WriteLine("                               ██║  ██║██║   ██║██╔══██╗██╔══██║██╗       ██║   ██╔══██║██╔══╝      ██║╚██╔╝██║██║   ██║╚██╗ ██╔╝██║██╔══╝  ");
            Console.WriteLine("                               ██████╔╝╚██████╔╝██║  ██║██║  ██║╚═╝       ██║   ██║  ██║███████╗    ██║ ╚═╝ ██║╚██████╔╝ ╚████╔╝ ██║███████╗");
            Console.WriteLine("                               ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝          ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝ ╚═════╝   ╚═══╝  ╚═╝╚══════╝");
        }
        public static void AsciiAnabelle()
        {
            Console.WriteLine("                                █████╗ ███╗   ██╗███╗   ██╗ █████╗ ██████╗ ███████╗██╗     ██╗     ███████╗    ██████╗ ");
            Console.WriteLine("                               ██╔══██╗████╗  ██║████╗  ██║██╔══██╗██╔══██╗██╔════╝██║     ██║     ██╔════╝    ╚════██╗");
            Console.WriteLine("                               ███████║██╔██╗ ██║██╔██╗ ██║███████║██████╔╝█████╗  ██║     ██║     █████╗       █████╔╝");
            Console.WriteLine("                               ██╔══██║██║╚██╗██║██║╚██╗██║██╔══██║██╔══██╗██╔══╝  ██║     ██║     ██╔══╝       ╚═══██╗");
            Console.WriteLine("                               ██║  ██║██║ ╚████║██║ ╚████║██║  ██║██████╔╝███████╗███████╗███████╗███████╗    ██████╔╝");
            Console.WriteLine("                               ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═════╝ ╚══════╝╚══════╝╚══════╝╚══════╝    ╚═════╝ ");
        }
        public static void AsciiAvengers()
        {
              Console.WriteLine("              █████╗ ██╗   ██╗███████╗███╗   ██╗ ██████╗ ███████╗██████╗ ███████╗       ███████╗███╗   ██╗██████╗      ██████╗  █████╗ ███╗   ███╗███████╗");
              Console.WriteLine("             ██╔══██╗██║   ██║██╔════╝████╗  ██║██╔════╝ ██╔════╝██╔══██╗██╔════╝██╗    ██╔════╝████╗  ██║██╔══██╗    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝");
              Console.WriteLine("             ███████║██║   ██║█████╗  ██╔██╗ ██║██║  ███╗█████╗  ██████╔╝███████╗╚═╝    █████╗  ██╔██╗ ██║██║  ██║    ██║  ███╗███████║██╔████╔██║█████╗  ");
              Console.WriteLine("             ██╔══██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║██║   ██║██╔══╝  ██╔══██╗╚════██║██╗    ██╔══╝  ██║╚██╗██║██║  ██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  ");
              Console.WriteLine("             ██║  ██║ ╚████╔╝ ███████╗██║ ╚████║╚██████╔╝███████╗██║  ██║███████║╚═╝    ███████╗██║ ╚████║██████╔╝    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗");
              Console.WriteLine("             ╚═╝  ╚═╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝       ╚══════╝╚═╝  ╚═══╝╚═════╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
        }
    }
}
