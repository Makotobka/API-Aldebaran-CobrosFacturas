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
    
    public partial class MSpeer_lsns
    {
        public int id { get; set; }
        public Nullable<System.DateTime> last_updated { get; set; }
        public string originator { get; set; }
        public string originator_db { get; set; }
        public string originator_publication { get; set; }
        public Nullable<int> originator_publication_id { get; set; }
        public Nullable<int> originator_db_version { get; set; }
        public byte[] originator_lsn { get; set; }
        public Nullable<int> originator_version { get; set; }
        public Nullable<int> originator_id { get; set; }
    }
}
