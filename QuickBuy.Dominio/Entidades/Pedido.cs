using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int ID { get; set; }
        public DateTime DatePedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; } 
        public FormaPagamento FormaPagamento { get; set; }


        /// <summary>
        /// Peidos podem ter 1 ou mais itens
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
