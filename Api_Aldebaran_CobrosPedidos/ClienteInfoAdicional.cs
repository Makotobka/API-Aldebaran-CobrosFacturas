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
    
    public partial class ClienteInfoAdicional
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public short Orden { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public bool Activo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}