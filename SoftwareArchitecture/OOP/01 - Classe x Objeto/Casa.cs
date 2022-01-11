namespace OOP
{
    // Definicao Classe
    public class Casa
    {
        public int Id { get; set; }
        public decimal Metros2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    //Definicao Objeto
    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                Andares = 3,
                Id = 1,
                Metros2 = 200000,
                NumeroVagas = 15,
                Valor = 2000000
            };

        }
    }
}
