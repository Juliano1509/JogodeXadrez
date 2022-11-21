
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }                                         // Atributos
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro (int linhas, int colunas)                          // Colunas
        {
            this.linhas = linhas; 
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)                             // funcoes
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
