using System;

namespace operacaoMatematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacao;
            float primeiroNumero, segundoNumero, resultado;

            Console.WriteLine("Informe o primeiro número: ");
            primeiroNumero = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            segundoNumero = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe a operação desejada: ");
            Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            operacao = Convert.ToInt32(Console.ReadLine());
            if (operacao == 1)
            {
                resultado = primeiroNumero + segundoNumero;
                Console.WriteLine("O resultado da adição é: {0}", resultado);
            } else
            {
                if (operacao == 2)
                {
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine("O resultado da subtração é: {0}", resultado);
                }
                else
                {
                    if (operacao == 3)
                    {
                        resultado = primeiroNumero * segundoNumero;
                        Console.WriteLine("O resultado da multiplicação é: {0}", resultado);
                    } else
                    {
                        if (operacao == 4)
                        {
                            if (segundoNumero == 0)
                            {
                                Console.WriteLine("Impossível dividir por 0");
                            } else
                            {
                                resultado = primeiroNumero / segundoNumero;
                                Console.WriteLine("O resultado da divisão é: {0}", resultado);
                            }
                        } else
                        {
                            Console.WriteLine("Opção inválida");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
