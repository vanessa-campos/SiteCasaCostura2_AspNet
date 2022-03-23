﻿using System;
using System.Collections.Generic;

namespace CasaCosturaCadastro.Models
{
    public partial class Usuario
    {
        public static int ADMIN = 0;
        public static int PADRAO = 1;

        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Deletado { get; set; }

    }
}
