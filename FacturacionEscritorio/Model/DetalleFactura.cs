//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionEscritorio.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public long Id { get; set; }
        public Nullable<long> FacturaId { get; set; }
        public Nullable<long> ProductoId { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
    }
}
