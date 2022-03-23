using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class MesResumo
    {
        public int Id { get; set; }
        public int Mes { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
