using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade.Models
{
    public abstract class Clientes
    {
        public Clientes(string? nome, string? endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
        
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        protected float Valor { get; set; }
        protected float ValorImposto { get; set; }
        protected float Total => Valor + ValorImposto;

        public virtual void PagarImposto(float valor){}

        public abstract void ExibirNota();
    }
}