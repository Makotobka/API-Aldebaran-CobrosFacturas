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
    
    public partial class Rpt_CierreCajaJ_Result
    {
        public int IDAP { get; set; }
        public int IDISL { get; set; }
        public string Nombre { get; set; }
        public int IDUsuario { get; set; }
        public string Usuario { get; set; }
        public int IDDISP { get; set; }
        public string DISPENSADOR { get; set; }
        public int IDDDI { get; set; }
        public int IDPD { get; set; }
        public string PRODUCTO { get; set; }
        public Nullable<int> ContadorInicial { get; set; }
        public Nullable<int> ContadorFinal { get; set; }
        public Nullable<int> GALONES { get; set; }
        public decimal PVP { get; set; }
        public Nullable<decimal> VENTA { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
