using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJuros.api.Models.Taxa
{
    public class CalcularViewModel
    {

        [Required(ErrorMessage = "O valor inicial não pode estar vazio.")]
        public double ValorInicial { get; set; }

        [Required(ErrorMessage = "O valor atual não pode estar vazio.")]
        public double ValorAtualizado { get; set; }

        [Required(ErrorMessage = "O valor dos juros não pode estar vazio.")]
        public double Juros { get; set; }       
        }
    }
