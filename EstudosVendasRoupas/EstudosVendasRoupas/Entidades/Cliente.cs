using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstudosVendasRoupas.Entidades
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o número de CPF/MF do cliente")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Informe o campo Endereço")]
        [StringLength(50)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado")]
        [StringLength(30)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP")]
        [StringLength(9)]
        public string CEP { get; set; }

        [StringLength(11)]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Informe e-mail válido")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Senha { get; set; }
    }
}