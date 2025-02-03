using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_Sharp_Sandbox
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            // Declarando arrays
            string[] produtos = new string[5]  { // Não é possível modificar o tamanho do array após sua declaração
           
                "Produto 1",
                "Produto 2",
                "Produto 3",
                "Produto 4",
                "Produto 5"
            };

            int[] valores = new int[5] { 3, 5, 7, 9, 11 }; // Inicializa o array com a quantidade de itens que foi declarado

            Console.WriteLine(produtos[1]); // Escreve o produto que está alocado no índice 1 (2 posição)
            Console.WriteLine(valores[4]); // Escreve o valor que está alocado no índice 2 (5 posição)
        }
    }
}
