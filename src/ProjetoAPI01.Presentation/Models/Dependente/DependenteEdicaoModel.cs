﻿using System.ComponentModel.DataAnnotations;

namespace ProjetoAPI01.Presentation.Models.Dependente
{
    public class DependenteEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o id do dependente.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do dependente.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o id do funcionário.")]
        public Guid FuncionarioId { get; set; }
    }
}