using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class Vendidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
