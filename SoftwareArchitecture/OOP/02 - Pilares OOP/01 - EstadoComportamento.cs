using System;

namespace OOP
{
    public class Pessoa
    {
        // Estado / Informacoes / Propriedades
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        // Comportamento / Processa uma informacao e devolve outra, ou altera o estado da entidade
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade))
            {
                idade--;
            }

            return idade;
        }
    }
}
