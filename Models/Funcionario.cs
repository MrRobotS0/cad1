namespace Cad1.Models
{
    public class Funcionario
    {
        public int FuncionarioId{get; set;}
        public string Nome{get; set;}
        public string Ctps{get; set;}
        public long Cpf{get; set;}
        public int SetorId{get; set;}
        public virtual Setor Setor{get; set;}
    }
}