using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJuros.api.Models
{
    public class TaxaViewModelInput
    {
        public double ValorInicial { get; set; }

        public double Juros { get; set; }

        public double ValorAtualizado { get; set; }
    }
}
