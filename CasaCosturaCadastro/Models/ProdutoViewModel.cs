using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class ProdutoViewModel
    {       

        public ICollection<Produto> Produtos { get; set; }
        public Produto Produto { get; set; }
    }

}
