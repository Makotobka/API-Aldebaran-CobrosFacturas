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
    
    public partial class vRetencionVenta
    {
        public int IDR { get; set; }
        public int IDSU { get; set; }
        public int IDF { get; set; }
        public string NumeroFactura { get; set; }
        public decimal SubTotalFactura { get; set; }
        public decimal TotalFactura { get; set; }
        public string CEDRUC { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string NumeroRetencion { get; set; }
        public bool Estado { get; set; }
        public bool Asumida { get; set; }
        public string Concepto { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal ValorRetencion { get; set; }
        public string EjercicioFiscal { get; set; }
        public decimal BaseImponible { get; set; }
        public int IDIMP { get; set; }
        public string Impuesto { get; set; }
        public string CodigoSRI { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal SubTotal { get; set; }
    }
}