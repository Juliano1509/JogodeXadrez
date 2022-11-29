
namespace tabuleiro
{
     class Peca
    {
        public Posicao posicao { get; set; }                            //Atributos
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; } 
        public Tabuleiro tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)                            //Construtor
        {
            this.posicao = null;
            this.tab = tab;
            this.Cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            this.qteMovimentos++;
        }
    }
}
