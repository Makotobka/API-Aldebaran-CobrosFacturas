//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Aldebaran_CobrosPedidos
{
    using System;
    using System.Collections.Generic;
    
    public partial class MSpeer_conflictdetectionconfigrequest
    {
        public int id { get; set; }
        public string publication { get; set; }
        public System.DateTime sent_date { get; set; }
        public int timeout { get; set; }
        public System.DateTime modified_date { get; set; }
        public string progress_phase { get; set; }
        public bool phase_timed_out { get; set; }
    }
}