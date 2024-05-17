﻿using System;
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

            Produto produto1 = new();

            produto1.nome = "Bolacha";
            produto1.valor = 2.50;
            produto1.DescontoValor = 1;
            produto1.DescontoPorcentagem = 15;
            produto1.quantidade = 5;

            produto1.aplicarCupomDescontoPorcentagem();
            produto1.aplicarCupomDescontoValor();
            produto1.verificarQuantidadeEmEstoque();
            Console.WriteLine(produto1.imprimir());      
        }
    }   
}
