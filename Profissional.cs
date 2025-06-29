﻿using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionarios
{
    public class Profissional
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public decimal Salario { get; set; }
    }
}
