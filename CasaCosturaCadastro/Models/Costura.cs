using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class Costura
    {
        public int Id { get; set; }
        public string Resumo { get; set; }
        public string Cliente { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataEntrega { get; set; }
        public bool Pago { get; set; }
        public bool Entregue { get; set; }
    }
}
