using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "s";
            while (c == "s")
            {

                // NOME DO ANUNCIO
                List<string> anuncio = new List<string>();
                Console.Write("\nDigite o nome do Anuncio: ");
                anuncio.Add(Console.ReadLine());

                // NOME DO CLIENTE
                List<string> cliente = new List<string>();
                Console.Write("Digite o nome do Cliente: ");
                cliente.Add(Console.ReadLine());

                //DATA de INICIO e FIM
                Console.WriteLine("\nDigite Ano, Mes, Dia (Separados por virgula)");

                Console.Write("\nInicio: ");
                DateTime data1 = DateTime.Parse(Console.ReadLine());

                Console.Write("\nFim: ");
                DateTime data2 = DateTime.Parse(Console.ReadLine());

                //SUBTRAÇÃO ENTRE DATAS
                TimeSpan dias = data2.Subtract(data1); //Subtrai entre as datas
                double tdias = dias.TotalDays; //Colocando TimeSpan dias em double

                //INVESTIMENTO
                Console.Write("\nDigite o valor do Investimento Diário: ");
                double valor = double.Parse(Console.ReadLine());

                //CALCULO TOTAL DO INVESTIMENTO CONTINUAR DAQUI
                double total = valor * tdias;



                //PROGRAMA 1 - VISUALIZAÇÃO - CLIQUES - CMPOARTILHAMENTOS
                double custview = 0.03;
                double quantview = valor / custview;

                // Calculo de quantidade de cliques a cada 100 visualizações 12 clicam
                double click = (quantview / 100) * 12;

                // Calculo de Compartilhamento, 20 cliques convertem em 3 compartilhamentos
                double cont = 0;
                double compart = 0;
                for (cont = click; cont >= 20; compart++)
                {
                    cont = cont - 20;
                }

                // Cada Compartilhamento gera 40 novas visualizações
                double newview = compart * 40;

                //Total de Visualizaçõ de visualizações 
                double totalview = quantview + newview;


                //RELATÓRIO
                Console.WriteLine("\n=============== RELATÓRIO ===============");

                Console.WriteLine("Anuncio: " + anuncio[0]);
                Console.WriteLine("Cliente: " + cliente[0]);
                Console.WriteLine("Inicio: " + data1.ToString("dd/MM/yyyy"));
                Console.WriteLine("Fim: " + data2.ToString("dd/MM/yyyy"));
                Console.WriteLine("Dias: " + tdias);
                Console.WriteLine("Investimento Diário: R$ " + valor);

                //Console.WriteLine("Visualizações: " + quantview.ToString("F0"));

                Console.WriteLine("\n=========== ALCANCE DA CAMPANHA ===========");
                Console.WriteLine("Valor total do investimento: R$ " + total.ToString("F"));
                Console.WriteLine("Total de Visualizações: " + totalview.ToString("F0"));
                Console.WriteLine("Cliques: " + click.ToString("F0"));
                Console.WriteLine("Compartilhamentos: " + compart);


                //SAIR OU CONTINUAR?        
                Console.Write("\nCONTINUAR - Digite s\nSAIR - Aperte qualquer tecla\n");
                c = Console.ReadLine();
            }//FIM While











        }
    }
}
