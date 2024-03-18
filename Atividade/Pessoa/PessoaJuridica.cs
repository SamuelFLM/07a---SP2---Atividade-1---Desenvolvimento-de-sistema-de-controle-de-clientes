using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade.Models
{
    public class PessoaJuridica : Clientes
    {
        public PessoaJuridica(string? nome, string? endereco, string? cnpj, string? ie) : base(nome, endereco)
        {
            CNPJ = cnpj;
            Ie = ie;
        }
        public string? CNPJ { get; set; }
        public string? Ie { get; set; }

        public override void ExibirNota()
        {
            Console.Clear();
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........:  " + Nome);
            Console.WriteLine("Endereço ......:  " + Endereco);
            Console.WriteLine("CNPJ ..........:  " + CNPJ);
            Console.WriteLine("IE ............:  " + Ie);
            Console.WriteLine("Valor de Compra:  " + Valor.ToString("C"));
            Console.WriteLine("Imposto .......:  " + ValorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar  :  " + Total.ToString("C"));
            Console.WriteLine("\n\n Pressione uma tecla para sair....");
            Console.ReadKey();
        }

        public override void PagarImposto(float valor)
        {
            Valor = valor;
            ValorImposto = Valor * 20 / 100;
        }
    }
}