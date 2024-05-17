using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Struct;

public struct JogadorFutebol{
    public string nome;

    public string datanasc;

    public int cartaoAmarelo = 0;

    public int cartaoVermelho = 0;

    public string clube;
    public JogadorFutebol (string nome,  string datanasc, string clube){
        this.nome = nome;
        this.datanasc = datanasc;
        this.clube = clube;
    }

    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n Data de Nascimento: " + this.datanasc + "\n Cartões Amarelos: " + 
        this.cartaoAmarelo + "\n Cartões Vermelhos: " + this.cartaoVermelho + "\n Clube: " + this.clube;
    }

    public void adicionarCartaoAmarelo(){
        this.cartaoAmarelo = cartaoAmarelo + 1;
    }
    public void adicionarCartaoVermelho(){
        this.cartaoVermelho = cartaoVermelho + 1;
    }
    public void verificarVinculoClube(){  
        if(this.clube == "" || this.clube == null){
            this.clube = "Sem clube";
        }
    }
}