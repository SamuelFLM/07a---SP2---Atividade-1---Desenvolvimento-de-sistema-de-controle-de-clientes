
namespace Atividade.Models
{
    public class PessoaFisica : Clientes
    {
        public PessoaFisica(string? nome, string? endereco, string? cpf, string? rg) : base(nome, endereco)
        {
            CPF = cpf;
            RG = rg;
        }

        public string? CPF { get; set; }
        public string? RG { get; set; }

        public override void PagarImposto(float valor)
        {
            Valor = valor;
            ValorImposto = Valor * 10 / 100;
        }
        public override void ExibirNota()
        {
            Console.Clear();
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + Nome);
            Console.WriteLine("Endereço ......: " + Endereco);
            Console.WriteLine("CPF ...........: " + CPF);
            Console.WriteLine("RG ............: " + RG);
            Console.WriteLine("Valor de Compra: " + Valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + ValorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar  : " + Total.ToString("C"));
            Console.WriteLine("\n\n Pressione uma tecla para sair....");
            Console.ReadKey();
        }
    }
}