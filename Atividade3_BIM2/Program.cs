using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3_BIM2
{
    internal class Program
    {
            /* |====================================================| */
            /* |* AUTOR: RENAN LIMA | RA: 6321300 ******************| */
            /* |* DATA DE CRIAÇÃO: 04.JUL.2022 *********************| */
            /* |* PROVA FECHAMENTO DE NOTA DO 2 BIMESTRE ***********| */
            /* |* MATÉRIA: LÓGICA DE PROGRAMAÇÃO *******************| */
            /* |* SEMESTRE: 1 | INSTITUIÇÃO: UNIFAAT ATIBAIA *******| */
            /* |* CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS *****| */
            /* |====================================================| */
        
        static void Main(string[] args)
        {

            double height, d1, d2, area; int l;

            Console.WriteLine("||== Calculadora de Áreas =||");
            Console.WriteLine("\nSelecione qual figura você quer calcular \n1- Triângulo" +
                "\n2- Círculo \n3- Trapézio \n-> ");

            l = Convert.ToInt32(Console.ReadLine());

            switch (l)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Triangulo\n");

                    Console.Write("Insira o valor da base: ");

                    d1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o valor da altura: ");

                    height = Convert.ToInt32(Console.ReadLine());

                    area = (d1 * height) / 2;

                    Console.WriteLine("O valor da área desse Triângulo é: " + area);

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Círculo\n");

                    Console.Write("Insira o valor do Raio: ");

                    d1 = Convert.ToInt32(Console.ReadLine());

                    area = 3.14159265359 * (d1 * d1);

                    Console.WriteLine("O valor da área desse Círculo é: " + area);

                    break;


                case 3:
                    Console.Clear();
                    Console.WriteLine("Trapézio\n");

                    Console.Write("Insira o valor da Base 1: ");

                    d1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o valor da Base 2: ");

                    d2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Insira o valor da altura: ");

                    height = Convert.ToInt32(Console.ReadLine());

                    area = (d1 + d2) * height;

                    Console.WriteLine("O valor da área desse Círculo é: " + area);

                    break;

            }


            Console.ReadKey();
        }
    }
}
