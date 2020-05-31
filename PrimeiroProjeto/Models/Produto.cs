using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatorio")]
        [Range(1 , 10, ErrorMessage = "Valor fora da faixa ")]

        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
