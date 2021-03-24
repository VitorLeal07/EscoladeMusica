namespace EscolaMusica
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Instrumentos Instrumentos{ get; set; }
        public string conhecimento { get; set; }
        public Aluno(Instrumentos instrumento, string nome, string conhecimento)
        {
            this.Instrumentos = instrumento;
            this.Nome = nome;
            this.conhecimento = conhecimento;       
            }
    }
}