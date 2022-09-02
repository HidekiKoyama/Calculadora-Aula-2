using System;

namespace hideki.aula.definir
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                      Terceiro Programa Aula 2 - (CALCULADORA)


            //Variaveis
            string operacao;
            double valor1, valor2;

            Console.WriteLine("**********Sua calculadora em C#************");
            Console.WriteLine("Diga a operação que você usará.\n\tSendo + para Soma, * para multiplicação e / para divião.\n\n Digite a operação que você usará: ");
            operacao = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Escolha o seu primeiro número: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o segundo número: ");
            valor2 = double.Parse(Console.ReadLine());

            if (operacao == "/")
            {
                Console.WriteLine(valor1 / valor2);
            }
            else if (operacao == "*")
            {
                Console.WriteLine(valor1 * valor2);
            }
            else if (operacao == "-")
            {
                Console.WriteLine(valor1 - valor2);
            }
            else if (operacao == "+")
            {
                Console.WriteLine(valor1 + valor2);
            }
            else
            {
                Console.WriteLine("Algo deu errado na esolha de suas operações!");
            }
        }
    }
}
