using atividade_poo.Controllers;

namespace atividade_poo
{
    class Program
    {
        static void Main(string[] args)
        {
           AlunoController aluno = new AlunoController(); //Instanciando objeto;

           aluno.CadastrarAluno();

           aluno.ExibirAluno();           
        }
    }
}
    