using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroSeguradoSinaf.Models
{
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Preencha o CPF.")]
        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF já foi cadastrado")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o sexo.")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "Selecione um estado civil.")]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Preencha o Estado de residência.")]
        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)", ErrorMessage = "Informe um Estado válido.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Preencha a cidade da residência.")]
        [MaxLength(50, ErrorMessage = "O nome da cidade deve ter até 50 caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o endereço residencial.")]
        [MaxLength(100, ErrorMessage = "O endereço residencial deve ter até {1} caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o número do endereço residencial.")]
        [MaxLength(10, ErrorMessage = "O número do endereço deve ter até {1} caracteres")]
        public string NumeroEndereco { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento do endereço deve ter até {1} caracteres")]
        [Display(Name = "Complemento")]
        public string ComplementoEndereco { get; set; }

        [Required(ErrorMessage = "O Celular é obrigatório.")]
        [Display(Name = "Telefone")]
        [RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4}[-]{1}[0-9]{3,4}$", ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        [Display(Name = "Celular")]        
        [RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4,5}[-]{1}[0-9]{3,4}$", ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
        public string Celular { get; set; }

        [Required]
        [Display(Name = "E-mail")]        
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        
        //[Required(ErrorMessage = "Selecione um seguro.")]
        [Display(Name = "Seguros")]
        public Seguro Seguro { get; set; }   

        //[Required(ErrorMessage = "Selecione um valor.")]
        [Display(Name = "Coberturas")]
        public Cobertura Cobertura { get; set; }
        
    }
}