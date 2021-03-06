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
    
    public partial class Proveedor
    {
        public Proveedor()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public long Id { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<long> RubroId { get; set; }
        public Nullable<long> IvaId { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string SitioWeb { get; set; }
        public string Observaciones { get; set; }
    
        public virtual IVA IVA { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
        public virtual Proveedor Proveedor1 { get; set; }
        public virtual Proveedor Proveedor2 { get; set; }
    }
}
