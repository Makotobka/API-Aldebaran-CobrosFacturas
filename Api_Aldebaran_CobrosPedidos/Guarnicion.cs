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
    
    public partial class Guarnicion
    {
        public int ID { get; set; }
        public Nullable<int> IDPD { get; set; }
        public bool Tipo { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PVP { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string Estado { get; set; }
        public string InsUsuario { get; set; }
        public string InsPC { get; set; }
        public System.DateTime InsFecha { get; set; }
        public string UpdUsuario { get; set; }
        public string UpdPC { get; set; }
        public Nullable<System.DateTime> UpdFecha { get; set; }
    }
}