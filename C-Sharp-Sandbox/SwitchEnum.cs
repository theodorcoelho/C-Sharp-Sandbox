using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace C_Sharp_Sandbox
{
    internal class SwitchEnum
    {
        // enum -> uma das formas mais simples de criar um tipo de dado
        // é um tipo de dado que contém um número limitado de valores
        enum Cor { Azul, Verde, Amarelo, Vermelho } // cada item possui um índice ordenado 0:n
        enum Crud { Listar = 1, Criar, Atualizar, Deletar}// Definindo o primeiro item como 1 para que a listagem comece em 1 e não em 0 como é o padrão

        static void Main(string[] args)
        {

            // Switch
            string corEscolhida = "Azul";

            switch (corEscolhida) // switch só realiza operações de igualdade
            {
                case "Vermelho":
                    Console.WriteLine("Você escolheu vermelho");
                    break;
                case "Azul":
                    Console.WriteLine("Você escolheu azul");
                    break;
                case "Roxo":
                    Console.WriteLine("Você escolheu roxo");
                    break;
                case "Verde":
                    Console.WriteLine("Você escolheu verde");
                    break;
                default: // opção padrão que será executada se não entrar em nenhum case
                    Console.WriteLine("Ainda não trabalhamos com esta cor.");
                    break;
            }

            // Switch com Enum
            
            Cor corFavorita = Cor.Verde;
            Console.WriteLine(corFavorita);

            Console.WriteLine("1-Listar\n2-Criar\n3-Atualizar\n4-Deletar");
            int index = int.Parse(Console.ReadLine());
            Crud OpcaoSelecionada = (Crud)index;
            Console.WriteLine("OPÇÃO: " + OpcaoSelecionada);

            switch(OpcaoSelecionada)
            {
                case Crud.Listar:
                    Console.WriteLine("Você selecionou listar");
                    break;
                case Crud.Criar:
                    Console.WriteLine("Você selecionou criar");
                    break;
                case Crud.Atualizar:
                    Console.WriteLine("Você selecionou atualizar");
                    break;
                case Crud.Deletar:
                    Console.WriteLine("Você selecionou deletar");
                    break;
            }
        }
    } 
}
