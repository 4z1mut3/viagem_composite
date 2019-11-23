using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem_composite
{
    class TrechoSimples:TrechoAereo
    {
        public String origem;
        public String destino;
        public double preco;

        public TrechoSimples(String origem, String destino, double preco) {
            this.origem = origem;
            this.destino = destino;
            this.preco = preco;
        }
        
        public String getOrigem() {
            return origem;
        }

        public String getDestino()
        {
            return destino;
        }
        public double getPreco()
        {
            return preco;
        }
    }
}
