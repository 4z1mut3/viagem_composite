using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem_composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------------------+");
            TrechoSimples trecho_simples_1 = new TrechoSimples("São Paulo", "Brasília", 500);
            TrechoSimples trecho_simples_2 = new TrechoSimples("Brasília", "Recife", 300);
            TrechoSimples trecho_simples_3 = new TrechoSimples("Recife", "Natal", 350);
            TrechoSimples trecho_simples_4 = new TrechoSimples("Natal", "belem-PA", 666);
            TrechoComposto trecho_composto_1 = new TrechoComposto(trecho_simples_1, trecho_simples_2,30);

            TrechoComposto trecho_composto_2 = new TrechoComposto(trecho_composto_1, trecho_simples_3, 50);
            TrechoComposto viagem = new TrechoComposto(trecho_composto_2, trecho_simples_4, 165);

            
            Console.WriteLine("|Preço da Viagem: " + viagem.getPreco()+"             |");
            Console.WriteLine("+----------------------------------+");
            Console.ReadKey();
        }
    }
}
