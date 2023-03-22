using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a letra desejada: ");
            char letraEscolhida = Convert.ToChar(Console.ReadLine());

            char letra = 'A';

            int espacosDaMargem = letraEscolhida - letra;
            int quantidadeLinhas = letraEscolhida - letra;
            int espacosEntreAsLetras = - 1;


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
                espacosEntreAsLetras+= 2;

                Console.WriteLine();
            }

            Console.Write(letraEscolhida);

            for (int i = 0; i < espacosEntreAsLetras; i++)
            {
                Console.Write(" ");
            }

            Console.Write(letraEscolhida);

            letra--;
            espacosDaMargem++;
            espacosEntreAsLetras-= 2;

            Console.WriteLine();

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
                espacosEntreAsLetras-= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
