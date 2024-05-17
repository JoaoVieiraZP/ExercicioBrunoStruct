using System;
using Struct;

namespace TAD{
    class Program{
        static void Main(string[]args){
            JogadorFutebol jogador1 = new();

            jogador1.nome = "José";
            jogador1.datanasc = "15/07/1908";
            jogador1.clube = "Corinthians";

            jogador1.adicionarCartaoAmarelo();
            jogador1.adicionarCartaoVermelho();
            jogador1.verificarVinculoClube();
            Console.WriteLine(jogador1.imprimir());            
        }
    }   
}
