using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2Emanuela
{
    internal class Program
    {
        public static void Exercicio1()
        {

            int[] vet2;

             float  menorvalor = float.MaxValue;
             float  maiorvalor = float.MinValue;


                Console.WriteLine("entre com o tamanho");
                int t = int.Parse(Console.ReadLine());

                vet2 = new int[t];
                Random rand = new Random();

                float soma = 0;

                for (int i = 0; i < t; i++)
                {
                    vet2[i] = rand.Next(10, 50);
                    soma = soma + vet2[i];

                    if ( vet2[i] < menorvalor)
                    {   
                       menorvalor = vet2[i];
                    }

                    if (vet2[i] > maiorvalor)
                    {
                        maiorvalor = vet2[i];
                    }

                }
                    Console.WriteLine("A média é = " + soma / (float)t);

                for (int i = 0; i < t; i++)
                {
                    Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
                }


                    Console.WriteLine("menor número do vetor {0} ", menorvalor);  
                    Console.WriteLine("maior número do vetor {0} ", maiorvalor);

        }
       
        public static void Exercicio2()
        {

            int[] vet2;
            int t, soma = 0;
            float media = 0;

            do
            {
                Console.WriteLine("entre com o tamanho maior que zero");
                t = int.Parse(Console.ReadLine());
                vet2 = new int[t];

            } while (t <= 0);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite o número: ");
                vet2[i] = int.Parse(Console.ReadLine());
                soma = soma + vet2[i];
               
            }
            media = soma / (float)t;

            

            for (int i = 0; i < t; i++)
            {
                if (vet2[i] >= media)
                {
                     Console.WriteLine("números contidos no vetor que são maiores ou iguais à média: " + vet2[i]);
                }
            }
           
        }

        public static void Exercicio3()
        {

            int[] vet2;
            int t, soma = 0;
            float media = 0;

            do
            {
                Console.WriteLine("entre com o tamanho maior que zero");
                t = int.Parse(Console.ReadLine());
                vet2 = new int[t];

            } while (t <= 0);

            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(1,100);
                soma = soma + vet2[i];

            }
            media = soma / (float)t;



            for (int i = 0; i < t; i++)
            {
                if (vet2[i] >= media)
                {
                    Console.WriteLine("números contidos no vetor que são maiores ou iguais à média: " + vet2[i]);
                }
            }
        }
       
        public static void Exercicio4()
        {
            string[] vet2;
            int t;
            do
            {
                Console.WriteLine("Digite a quantidade de nomes: ");
                t = int.Parse(Console.ReadLine());
                vet2 = new string[t];

            } while (t <= 0);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("Digite o nome: ");
                vet2[i] = Console.ReadLine();   

            }

            for( int i = t - 1; i >= 0; i--)
            {
                Console.WriteLine(" posicão[{0}] = {1}", i, vet2[i]);
            }

        }
       
        public static void Exercicio5()
        {
            int[] vet2;
            int t,par,impar;
       
            do
            {
                Console.WriteLine("entre com o tamanho maior que zero");
                t = int.Parse(Console.ReadLine());
                vet2 = new int[t];

            } while (t <= 0);

                vet2 = new int[t];
                Random rand = new Random();

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(1, 100);

                if (vet2[i] % 2 == 0)
                {
                    par = par + vet2[i];
                }
                else
                {
                    impar = impar + vet2[i];
                }

            }

            Console.WriteLine("os números pares é = " + par);
            Console.WriteLine("os números impares é = " + impar);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posicão[{0}] = {1}", i, vet2[i]);
            }


        }
       
      

        static void Main(string[] args)
        {
            int opcao, f = 1;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine("     Para Sair - digite 0           ");
                Console.WriteLine("Para executar exercício 1 - digite 1");
                Console.WriteLine("Para executar exercício 2 - digite 2");
                Console.WriteLine("Para executar exercício 3 - digite 3");
                Console.WriteLine("Para executar exercício 4 - digite 4");
                Console.WriteLine("Para executar exercício 5 - digite 5");
                Console.WriteLine("Para executar exercício 6 - digite 6");
                Console.WriteLine("Para executar exercício 7 - digite 7");
                Console.WriteLine("====================================");

                opcao = int.Parse(Console.ReadLine()); //lê a opção escolhida 

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigada, tchau!");
                        break;

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.WriteLine("digite 0 para sair ");
                f = int.Parse(Console.ReadLine());

            } while (opcao != 0);

        }
    }
}
