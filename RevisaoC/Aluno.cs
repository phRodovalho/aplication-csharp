namespace RevisaoC
{
    public class Aluno
    {
        public Aluno(string nome, string matricula, decimal nota)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.nota = nota;

        }
        public string nome { get; set; }

        public string matricula { get; set; }

        public decimal nota { get; set; }
    }
}