using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace PetShopApp.Models
{
    public class Proprietario
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        [Display(Name = "C.P.F.")]
        public string Cpf {get; set;}
        [Display(Name = "Endereço")]
        public string Endereco {get; set;}
        public string Telefone {get; set;}
        [Display(Name = "E-mail")]
        public string Email {get; set;}
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtNascimento {get; set;}


        public virtual ICollection<Animal> Animais {get; set;}
    }
}