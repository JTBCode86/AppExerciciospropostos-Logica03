using System;

namespace AppExerciciospropostos_Logica03
{
    class Program
    {
        /// <summary>
        /// Exercicios propostos 03.
        /// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        /// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static int DiferencaValores(int A, int B, int C, int D) 
        {
            int Diferenca = ((A * B) - (C * D));
            return Diferenca;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de A, B, C e D:");
            string[] vet = Console.ReadLine().Split(' ');

            int ValorA = int.Parse(vet[0]);
            int ValorB = int.Parse(vet[1]);
            int ValorC = int.Parse(vet[2]);
            int ValorD = int.Parse(vet[3]);

            int diverenca = DiferencaValores(ValorA, ValorB, ValorC, ValorD);
            Console.WriteLine("Diferença é igual a: {0}", diverenca);
            Console.ReadLine();

        }
    }
}
