using System;
using System.ComponentModel.DataAnnotations;

namespace PetShopApp.Models
{
    public class Animal
    {
        public int Id {get; set;}

        public string Nome {get; set;}

        [Display(Name="Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtNascimento {get; set;}

        [Display(Name="Raça")]
        public string Raca {get; set;}
        public string Porte {get; set;}
        public string Sexo {get; set;}
        [Display(Name="Espécie")]
        public string Especie {get; set;}
        public int ProprietarioID {get; set;}

        [Display(Name = "Idade")]
        public string Idade => CalculaIdade();

        public virtual Proprietario Proprietario {get; set;}


        public string CalculaIdade()
        {

            string idadeTexto = "";
            int idade;
            int anos = DateTime.Now.Year - DtNascimento.Year;
            int meses = DateTime.Now.Month - DtNascimento.Month;
            int dias = DtNascimento.Subtract(DateTime.Today).Days *(-1);
            if (anos < 0)
            {
                return "";              
            }
            if(anos == 0)
            {
                idade = DateTime.Now.Month - DtNascimento.Month;
                if (dias >= 30)
                {
                    idadeTexto = $"{idade} meses";
                }else if (dias < 30)
                {
                    idade = dias;
                    idadeTexto = $"Recém nascido";

                }            
                return idadeTexto;
            }
            idade = anos;
            idadeTexto = $"{idade} anos de idade";
            return idadeTexto;


        }
    }

    
}