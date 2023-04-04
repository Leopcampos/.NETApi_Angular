﻿using ProjetoAPI01.Repository.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI01.Presentation.Models.Funcionario
{
    public class FuncionarioEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do funcionário.")]
        public Guid Id { get; set; }

        [StringLength(150, MinimumLength = 6, ErrorMessage = "Por favor, informe no mínimo {2} e no máximo {1} caracteres")]
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a matrícula do funcionário.")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissão do funcionário.")]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o salário do funcionário.")]
        public decimal Salario { get; set; }
    }
}