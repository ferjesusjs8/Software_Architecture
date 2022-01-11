using System;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                DataAdmissao = DateTime.Now.AddYears(-2),
                DataNascimento = DateTime.Now.AddYears(-30),
                Nome = "Joao da Silva",
                Registro = "ABCD1234"
            };

            funcionario.CalcularIdade();
        }
    }
}
