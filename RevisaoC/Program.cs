// See https://aka.ms/new-console-template for more information
using RevisaoC;
{

    Aluno[] listaAlunos = new Aluno[10];
    int indiceAluno = 0;
    string op = Metodos.Menu.obterOpcaoUser();

    while (op.ToUpper() != "X")
    {
        switch (op)
        {
            case "1":
                //TODO: inserir novo aluno

                if (indiceAluno >= 3)
                {
                    Console.WriteLine("Limite de alunos atingido, exclua para inserir");
                    break;
                }

                string nome, matricula;
                Console.WriteLine("Inserir novo aluno");
                Console.WriteLine("Digite o nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a matricula:");
                matricula = Console.ReadLine();

                Console.WriteLine("Digite a nota");
                //var nota = decimal.Parse(Console.ReadLine());
                if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                {
                    //verificando se o valor inserido é numerico e então try convertendo para decimal
                    Aluno aluno = new Aluno(nome, matricula, nota);
                    listaAlunos[indiceAluno] = aluno;
                    indiceAluno++;
                }
                else
                {
                    //tratando exceção caso o valor digitado não for numerico
                    throw new ArgumentException("Valor da nota deve ser decimal");
                }
                break;
            case "2":
                //TODO: listar aluno
                foreach (var a in listaAlunos)
                {
                    if (a != null)
                    {
                        Console.WriteLine($"ALUNO: {a.nome} - MATRICULA: {a.matricula} - NOTA: {a.nota} - ");
                    }
                }
                break;
            case "3":
                //TODO: calcular media geral
                decimal notaTotal = 0;
                var nrAlun = 0;
                if(indiceAluno > 1){
                for(int i=0; i < listaAlunos.Length; i++){
                    if(!string.IsNullOrEmpty(listaAlunos[i].nome)){
                        nrAlun++;
                        notaTotal += listaAlunos[i].nota;
                    }
                }
                var medGeral = notaTotal/nrAlun;
                Console.WriteLine($"MEDIA GERAL{medGeral}");
                }else Console.WriteLine("Cadastre alunos antes");
                break;
            default:
                Console.WriteLine("Digite um valor válido");
                throw new ArgumentOutOfRangeException();
        }
        Console.WriteLine();
        op = Metodos.Menu.obterOpcaoUser();

    }
}

namespace Metodos
{
    class Menu
    {
        public static string obterOpcaoUser()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");

            string op = Console.ReadLine();
            return op;
        }
    }

}



