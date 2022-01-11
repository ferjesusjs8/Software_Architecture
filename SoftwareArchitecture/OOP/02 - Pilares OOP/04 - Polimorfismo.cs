using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) : base(nome, voltagem)
        {

        }

        public CafeteiraExpressa() : base("Padrao", 220)
        {

        }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            AvisoSonoro();
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Testar()
        {
            // Teste da cafeteira;
        }

        public override void Ligar()
        {

        }

        public override void Desligar()
        {

        }
    }
}
