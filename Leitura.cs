using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeEnergia
{
    class Leitura
    {
        public string Casa{ get; set; }
        public double Consumo { get; set; }
        public double Desconto {
            get { return Consumo * 0.2; }
        }

        public Leitura(string casa, Double consumo)
        {
            this.Casa = casa;
            this.Consumo = consumo;
        }


        public override bool Equals(object l)
        {
            Leitura leitura = l as Leitura; //passa a referencia de l com cash para Leitura.

            if (leitura == null)
            {
                return false;
            }
            
            return (Casa.Equals(leitura.Casa));
        }

        public override int GetHashCode()
        {
            return new {Casa, Consumo}.GetHashCode(); //junta os objetos Casa e Consumo e gera um hash unico.
        }
    }
}
