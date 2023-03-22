using System;

namespace DiamanteDeLetras
{
    internal class Program
    {
        public static char letraEscolhida, letra;
        static int espacosDaMargem, quantidadeLinhas, espacosEntreAsLetras;
        static void Main(string[] args)
        {
            Mensagem();

            ParteSuperior();
            ParteCentral();
            ParteInferior();

            Console.ReadLine();
        }

        static void Mensagem()
        {
            Console.WriteLine("Informe a letra desejada: ");
            letraEscolhida = Convert.ToChar(Console.ReadLine());

            letra = 'A';
            espacosDaMargem = letraEscolhida - letra;
            quantidadeLinhas = letraEscolhida - letra;
            espacosEntreAsLetras = -1;
        }
        static void ParteSuperior()
        {
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                    Console.Write(letra);

                letra++;
                espacosDaMargem--;
                espacosEntreAsLetras += 2;

                Console.WriteLine();
            }

            Console.Write(letraEscolhida);
        }
        static void ParteCentral()
        {
            for (int i = 0; i < espacosEntreAsLetras; i++)
            {
                Console.Write(" ");
            }

            Console.Write(letraEscolhida);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras -= 2;

            Console.WriteLine();
        }
        static void ParteInferior()
        {
            for (int linha = 0; linha < quantidadeLinhas; linha++)
            {
                for (int i = 0; i < espacosDaMargem; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(letra);

                for (int i = 0; i < espacosEntreAsLetras; i++)
                {
                    Console.Write(" ");
                }

                if (letra != 'A')
                {
                    Console.Write(letra);
                }

                letra--;
                espacosDaMargem++;
                espacosEntreAsLetras -= 2;

                Console.WriteLine();
            }
        }
    }
}
