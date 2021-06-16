using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebAlimento.Models
{
    public class Alimento
    {
        [Required(ErrorMessage = "Campo obrigatório.")]
        [Remote("CodigoUnico", "alimento", ErrorMessage = "Código existente.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira de 5 a 50 caracteres.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Descricao { get; set; }

        [Range(1.00, 100.00, ErrorMessage = "Insira valor entre 1 e 100.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Peso { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Categoria { get; set; }

        [Range(1.00, 100.00, ErrorMessage = "Insira valor entre 1 e 100.")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string ValorUnit { get; set; }
    }
}