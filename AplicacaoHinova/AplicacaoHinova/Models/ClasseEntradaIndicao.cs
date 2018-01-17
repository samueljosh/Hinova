using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacaoHinova.Models
{
    public class ClasseEntradaIndicao
    {
             public int Id { get; set; }
            public Indicacao Indicacao { get; set; }
            public string Remetente { get; set; }
            public string[] Copias { get; set; }
        
    }
}