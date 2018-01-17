using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplicacaoHinova.Models
{

    public class Oficina
    {
  
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome da Oficina")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Resumo")]
        public string DescricaoCurta { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Foto { get; set; }
        [Display(Name = "Avaliação")]
        public string AvaliacaoUsuario { get; set; }
        [Display(Name = "Código ")]
        public string CodigoAssociacao { get; set; }
        [RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Digite um email válido")]
        [StringLength(50, ErrorMessage = "Máximo de caracteres permitido para o email é 50!")]
        public string Email { get; set; }
        [RegularExpression("", ErrorMessage = "Digite um telefone válido")]
        [Display(Name = "Telefone")]
        public string Telefone1 { get; set; }
        [Display(Name = " 2º Telefone")]
        public string Telefone2 { get; set; }
        [Range(typeof(bool), "Marcado", "Desmarcado")]
        public string Ativo { get; set; }
    }
}