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
    
    public partial class Rpt_TransaccionesUsuario_Result
    {
        public string PERIODO { get; set; }
        public Nullable<int> ANIO { get; set; }
        public Nullable<int> MESNUMERO { get; set; }
        public string MES { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public int ESTABLECIMIENTOID { get; set; }
        public string ESTABLECIMIENTO { get; set; }
        public Nullable<int> PUNTOEMISIONID { get; set; }
        public string PUNTOEMISION { get; set; }
        public int USUARIOID { get; set; }
        public string USUARIO { get; set; }
        public string USUARIONOMBRE { get; set; }
        public decimal VENTAS { get; set; }
        public decimal COBROS { get; set; }
        public decimal INGCAJACHICA { get; set; }
        public decimal COMPRAS { get; set; }
        public decimal PAGOS { get; set; }
        public decimal EGRCAJACHICA { get; set; }
        public Nullable<decimal> TOTALINGRESOS { get; set; }
        public Nullable<decimal> TOTALEGRESOS { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
    }
}