using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem_composite
{
    class TrechoComposto:TrechoAereo
    {
        private TrechoAereo primeiro;
        private TrechoAereo segundo;
        private double taxaconexao;

        public TrechoComposto(TrechoAereo primeiro, TrechoAereo segundo,  double taxaconexao)
        {
            this.primeiro = primeiro;
            this.segundo = segundo;
            this.taxaconexao = taxaconexao;

            
            if (!(primeiro.getDestino() == segundo.getOrigem()))
            {
                Console.WriteLine("O destino do primeiro não é igual a origem do segundo");
            }
            
            Console.WriteLine("|Taxa de conexão (" + this.segundo.getOrigem() + "): " + this.taxaconexao+"");
            
        }
        
        public String getOrigem()
        {
            return primeiro.getOrigem();
        }

        
        public String getDestino()
        {
            return segundo.getDestino();
        }

        
        public double getPreco()
        {
            return primeiro.getPreco() + segundo.getPreco() + taxaconexao;
        }

    }
}
