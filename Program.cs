using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_votaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string espacio = "";
            int NroElector = 0; //Variable de Nemero de elector
            int opc; //variable opcion de Respuesta
            int fas_si = 0; //variable de Frecuencia absoluta simple si
            int fas_no = 0; //variable de Frecuencia absoluta simple no
            int fas_blanco = 0; //variable de Frecuencia absoluta simple blanco int fas nulo = 0; 
            int fas_nulo = 0;//Variable de Frecuencia absoluta simple nulo
            int fa_acum = 0; //Variable de Frecuencia absoluta acumulada
            int total_fa; //Variable del total de frecuencias absolutas simples
            double frs_si; //Variable de frecuencia relativa simple si double frs no; 
            double frs_no; //variable de frecuencia relativa simple no
            double frs_blanco; //Variable de frecuencia relativa simple blanco double frs nulo; 
            double frs_nulo;//Variable de frecuencia relativa simple nulo
            double fr_acum = 0; //variable de la frecuencia relativa acumulada double total fr;
            double total_fr;//variable del total de frecuencias relativas simple
            Console.Clear();

            do
            {
                NroElector++;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\tControl de votacion de Electores");
                    Console.WriteLine("\t*********************************");
                    Console.Write("\tElector ");
                    Console.WriteLine(NroElector);
                    Console.WriteLine("\tElija Respuesta: ");
                    Console.WriteLine("\ti. Si ");
                    Console.WriteLine("\t2. No ");
                    Console.WriteLine("\t3. Blanco ");
                    Console.WriteLine("\t4. Nulo ");
                    Console.Write("\topcion [1-4]:");
                    opc = int.Parse(Console.ReadLine());
                } while ((opc < 1) || (opc > 4));

                //obtener las frecuencias absolutas simples
                switch (opc)
                {
                    case 1://Eleccion si
                        fas_si++;
                        break;
                    case 2: //Eleccion no
                        fas_no++;
                        break;
                    case 3://Eleccion blanco
                        fas_blanco++;
                        break;
                    case 4://Eleccion nulo
                        fas_nulo++;
                        break;
                }

                frs_si = (fas_si / 20.00) * 100;//Eleccion si
                frs_no = (fas_no / 20.00) * 100;//Eleccion no
                frs_blanco = (fas_blanco / 20.00) * 100;//Eleccion blanco
                frs_nulo = (fas_nulo / 20.00) * 100;//Eleccion nulo
            } while (NroElector < 20);

            //Mostrando los resultados

            total_fa = fas_si + fas_no + fas_blanco + fas_nulo; //Total de frecuencias absolutas
            total_fr = frs_si + frs_no + frs_blanco + frs_nulo;//Total de frecuencias relativas 
            Console.Write("\n");
            Console.Write("{0:2}", "/tvalor");
            Console.Write("{0.25}", "Frec.Abs.Simple");
            Console.Write("{0.20}", "Frec.Abs.Acum");
            Console.Write("{0.20}", "Frec.Rel.Simple");
            Console.WriteLine("{0.20}", "Frec.Rel.Acum.");

            fa_acum = fas_si;//Asiganr los votos del si
            fr_acum = frs_si;//Asignar el porcentaje de los votos del si

            Console.Write("{0}{1}", espacio.PadRight(7, ' '), "Si".PadLeft(7, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fas_si.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fa_acum.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), frs_si.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0}{1}", espacio.PadRight(7,     ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            fa_acum += fas_no; //Sumar los votos del no
            fr_acum += frs_no; //Asignar el porcentaje de los votos del no

            Console.Write("[0][1]", espacio.PadRight(7, ' '), "No".PadLeft(7, ' '));
            Console.Write("[0][1]", espacio.PadRight(7, ' '), fas_no.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fa_acum.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), frs_no.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            fa_acum += fas_blanco; //Sumar los votos en blanco
            fr_acum += frs_blanco; //Asignar el porcentaje de votos en blanco

            Console.Write("[0][1]", espacio.PadRight(7, ' '), "Blanco".PadLeft(7, ' '));
            Console.Write("[0][1]", espacio.PadRight(7, ' '), fas_blanco.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fa_acum.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), frs_blanco.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            fa_acum += fas_nulo; // Sumar los votos en nulo
            fr_acum += frs_nulo; //Asignar el porcentaje de votos en nulo

            Console.Write("[0][1]", espacio.PadRight(7, ' '), "Nulo".PadLeft(7, ' '));
            Console.Write("[0][1]", espacio.PadRight(7, ' '), fas_nulo.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fa_acum.ToString("N").PadLeft(14, ' '));
            Console.Write("{0}{1}", espacio.PadRight(7, ' '), frs_nulo.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");

            Console.Write("{0}{1}", espacio.PadRight(7, ' '), fr_acum.ToString("N2").PadLeft(9, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            Console.Write("[0][1]", espacio.PadRight(7, ' '), "Total".PadLeft(7, ' '));
            Console.Write("[0][1]", espacio.PadRight(7, ' '), total_fa.ToString("N").PadLeft(7, ' '));
            Console.Write("[0][1]", espacio.PadRight(7, ' '), total_fr.ToString("N").PadLeft(7, ' '));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            //Generando la grafica de votaciones de los electores

            int i;
            Console.WriteLine("{0:2}", "\n\tGrafica de Votos de los Electores");
            Console.WriteLine("{0:2}", "\t************************************");
            Console.Write("{0:2}", "\tvalor ");
            Console.Write("{0:2}", "BARRAS");
            Console.Write("{0:2}", "\n");
            
            //Barra de votos del si
            Console.Write("{0:2}", "\tsi     ");
            for (i = 1; i <= fas_si + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_si.ToString("N2"));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");

            //Barras del voto de no
            Console.Write("{0:2}", "\tNo   ");
            for (i = 1; i <= fas_no + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_no.ToString("N2"));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");

            //Barra de votos en Bianco
            Console.Write("{0:2}", "\tBlanco    ");
            for (i = 1; i<= fas_blanco +25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_blanco.ToString("N2"));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");

            //Barra de votos nulo
            Console.Write("{0:2}", "\tNulo    ");
            for(i = 1; i <= fas_nulo + 25; i++)
            {
                Console.Write("{0:2}", "||");
            }
            Console.Write("{0:2}", frs_nulo.ToString("N2"));
            Console.Write("{0:2}", "%");
            Console.Write("{0:2}", "\n");
            Console.ReadKey();//Pausa
        }
    }
}