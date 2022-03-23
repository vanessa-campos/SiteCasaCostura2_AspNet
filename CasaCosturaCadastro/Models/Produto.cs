using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class Produto
    {        
        public static int AVIAMENTO = 0;
        public static int TECIDO = 1;

        public int Id { get; set; }
        public int Categoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tamanho { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
