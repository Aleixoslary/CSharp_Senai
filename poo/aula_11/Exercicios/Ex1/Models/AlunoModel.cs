namespace Ex1.Models
{
    public class AlunoModel
    {
        public string Nome { get; set; }

        public string Curso { get; set; }

        public int Idade { get; set; }

        public string RG { get; set; }

        public bool Bolsista { get; set; }

        public AlunoModel(){

        }

        public AlunoModel(string Nome , string Curso, int Idade, string RG, bool Bolsista){
            
            
        }
    }
}