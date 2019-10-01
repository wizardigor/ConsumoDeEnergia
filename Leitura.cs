using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoDeEnergia
{
    class Leitura
    {
        //cria as propriedades Casa, Consumo e Desconto
        //já com os metodos get e set sem precisar nomear.
        public string Casa{
            get;
            set;
        }
        public double Consumo {
            get;
            set;
        }
        public double Desconto {
            get {
                return Consumo * 0.2;
            }
        }
        
        //construtor da classe Leitura exigi que seja 
        //criado o objeto já informando valores iniciais(casa e consumo).
        public Leitura(string casa, Double consumo)
        {
            this.Casa = casa;
            this.Consumo = consumo;
        }

        //reescrevendo o metodo Eguals passanodo a 
        //referencia de l com cash para Leitura.
        public override bool Equals(object l)
        {
            Leitura leitura = l as Leitura; 

            if (leitura == null)
            {
                return false;
            }

            //verifica se a instancia de Casa já existe 
            //no objeto leitura no campo Casa.
            return (Casa.Equals(leitura.Casa));
        }

        public override int GetHashCode()
        {
            return new {Casa, Consumo}.GetHashCode(); //junta os objetos Casa e Consumo e gera um hash unico.
        }
    }
}
