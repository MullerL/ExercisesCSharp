using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class InverterValoresVetor
    {
        static void Main(string[] args)
        {
            //inverter valores do vetor usando apenas uma variavel
            int[] vetor = { 11, 2 };
            int aux = 0;

            for (int i = 0; i < vetor.Length / 2; i++)
            {
                aux = vetor[vetor.Length - i - 1];
                vetor[vetor.Length - i - 1] = vetor[i];
                vetor[i] = aux;
            }

            foreach (int item in vetor)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
