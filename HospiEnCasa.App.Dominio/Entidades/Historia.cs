using System;
using System.Collections.Generic;

namespace HospiEnCasa.App.Dominio
{
    public class Historia 
    {
        public int IdHistoria { get; set; }
        public string Diagnostico  { get; set; }
        public string Entorno { get; set; }
        public List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}