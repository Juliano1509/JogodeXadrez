
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] peca;

        public Tabuleiro (int linha, int coluna)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            peca = new Peca[linhas, colunas];
        }
    }
}
