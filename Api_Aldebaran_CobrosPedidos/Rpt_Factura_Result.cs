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
    
    public partial class Rpt_Factura_Result
    {
        public int ID { get; set; }
        public string IDTR { get; set; }
        public System.DateTime FECHA { get; set; }
        public string TIPODOC { get; set; }
        public string SRIAUTORIZACION { get; set; }
        public string NUMERO { get; set; }
        public string FPAGO { get; set; }
        public Nullable<decimal> COMISIONPORC { get; set; }
        public Nullable<decimal> COMISIONVALOR { get; set; }
        public decimal SUBTORALIVA { get; set; }
        public decimal AS_SUBTOTALIVA0 { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal DESCUENTOPORC { get; set; }
        public decimal DESCUENTOVALOR { get; set; }
        public Nullable<decimal> SUBTOTALIVADESC { get; set; }
        public Nullable<decimal> SUBTOTALIVA0DESC { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
        public decimal SALDO { get; set; }
        public decimal EFECTIVO { get; set; }
        public decimal CAMVIO { get; set; }
        public string ESTADO { get; set; }
        public int CLTID { get; set; }
        public string CLTIDENTIFICACION { get; set; }
        public string CLTNOMBRE { get; set; }
        public string CLTDIRECCION { get; set; }
        public string CLTTELEFONO { get; set; }
        public string CLTCATEGORIA { get; set; }
        public int DETID { get; set; }
        public string DETCODIGO { get; set; }
        public string DETITEM { get; set; }
        public bool DETAPLICAIVA { get; set; }
        public decimal DETIVA { get; set; }
        public decimal DETDESCUENTO { get; set; }
        public decimal DETPRECIO { get; set; }
        public decimal DETCANTIDAD { get; set; }
        public decimal DETTOTAL { get; set; }
        public Nullable<decimal> DETCOMISIONPORC { get; set; }
        public Nullable<decimal> DETCOMISIONVALOR { get; set; }
        public decimal DETCOSTO { get; set; }
        public decimal DETPCP { get; set; }
        public int USUID { get; set; }
        public string USUNOMBRE { get; set; }
        public string USULOGIN { get; set; }
        public Nullable<int> PTOVTAID { get; set; }
        public string PTOVTANOMBRE { get; set; }
        public int SUCID { get; set; }
        public string SUCNOMBRE { get; set; }
        public string SUCADMINISTRADOR { get; set; }
        public string SUCDIRECCION { get; set; }
        public string SUCTELEFONO { get; set; }
        public int SUCCIUDADID { get; set; }
        public string SUCCIUDAD { get; set; }
        public Nullable<int> VENDID { get; set; }
        public string VENDNOMBRE { get; set; }
    }
}
