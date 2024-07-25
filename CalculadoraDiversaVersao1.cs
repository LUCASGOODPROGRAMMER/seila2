using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAppGetESet.RegrasDeNegocio
{
    internal class CalculadoraDiversaVersao1
    {
        private decimal valor1;
        private decimal valor2;
        private decimal valor3;
        private decimal percentual;
        private decimal total;

        // metodologia GET e SET padrão JAVA
        public void SetValor1(decimal valor1)
        {
            this.valor1 = valor1;
        }
        public decimal GetValor1()
        {
            return this.valor1;
        }

        //metodologia GET e SET padrão C#

        public decimal Valor1
        {
            get { return this.valor1; } 
            set { this.valor1 = value; }
        }
    }
}
