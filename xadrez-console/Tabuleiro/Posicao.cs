namespace tabuleiro
{
    internal class Posicao
    {
        public int linha { get; set; }                                                      //Atributos
        public int coluna { get; set; }                                                     //Atributos

        public Posicao (int linha, int coluna)                                              //Construtor
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()                                               //Tostring convertendo objeto para string
        {
            return linha
                + ", "
                + coluna; 
        }

    }
}
