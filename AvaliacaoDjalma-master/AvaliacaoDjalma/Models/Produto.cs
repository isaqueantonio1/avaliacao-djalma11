﻿using System.ComponentModel.DataAnnotations;

namespace AvaliacaoDjalma.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Descrição obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

    }
}
