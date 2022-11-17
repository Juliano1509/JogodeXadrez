﻿
namespace tabuleiro
{
     class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimento { get; protected set; } 
        public Tabuleiro tab { get; protected set; }

        public Peca (Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.Cor = cor;
            this.qteMovimento = 0;
        }
    }
}
