

using System;

namespace Calculadora.ConsoleApp

{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(" [1] Soma");
                Console.WriteLine(" [2] Subtrair");
                Console.WriteLine(" [3] Multiplicar");
                Console.WriteLine(" [4] Dividir");
                Console.WriteLine(" [s] Sair");

                opcao = Console.ReadLine();

                if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4")
                {
                    if (opcao == "s")
                    {
                        break;
                    }

                    Console.Write("Digite o primeiro número: ");
                    double primeiro_numero = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double segundo_numero = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    if (opcao == "1")
                    {
                        resultado = primeiro_numero + segundo_numero;
                    }
                    else if (opcao == "2")
                    {
                        resultado = primeiro_numero - segundo_numero;
                    }
                    else if (opcao == "3")
                    {
                        resultado = primeiro_numero * segundo_numero;
                    }
                    else if (opcao == "4")
                    {

                        do
                        {
                            if (primeiro_numero == 0)
                            {
                                Console.Write("O primeiro número deve ser maior do que 0, digite novamente: ");
                                primeiro_numero = Convert.ToDouble(Console.ReadLine());
                            }

                            if (segundo_numero == 0)
                            {
                                Console.Write("O segundo número deve ser maior do que 0, digite novamente: ");
                                segundo_numero = Convert.ToDouble(Console.ReadLine());
                            }

                        } while (primeiro_numero == 0 || segundo_numero == 0);

                        resultado = primeiro_numero / segundo_numero;
                    }
                    Console.WriteLine("Resultado: {0}", resultado.ToString("N2"));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ação não pode ser concluída, comando inválido");
                }
            }
            while (opcao != "s");
        }
    }
}