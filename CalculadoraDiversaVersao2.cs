using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAppGetESet.RegrasDeNegocio
{
    internal class CalculadoraDiversaVersao2
    {
        public decimal Valor1 { get; set; }//get e set automático
        public decimal Valor2 { get; set; }//get e set automático
        public decimal Valor3 { get; set; }//get e set automático
        // public decimal Percentual { get; set; }
        private decimal percentual;
        private decimal total;
       
        public decimal Percentual { 
            get { return percentual; } 
            set {this.percentual= value / 100;}
        }
        public decimal Total
        {
            get { return total; }
        }
        public void GetSomar()
        {
            this.total = this.Valor1 + this.Valor2 + this.Valor3;
        }







    }
}
