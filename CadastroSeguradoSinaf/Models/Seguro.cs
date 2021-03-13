using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastroSeguradoSinaf.Models
{
    public enum Seguro
    {
        [Display(Name = "Proteção familiar")]
        ProtecaoFamiliar,

        [Display(Name = "Assistência Sênior")]
        AssistenciaSenior
    }
}