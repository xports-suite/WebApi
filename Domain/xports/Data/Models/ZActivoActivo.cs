using System;
using System.Collections.Generic;

namespace Domain.xports.Data.Models
{
    public partial class ZActivoActivo
    {
        public ZActivoActivo()
        {
            ZActivoEco = new HashSet<ZActivoEco>();
            ZActivoFacturas = new HashSet<ZActivoFacturas>();
            ZProjectPresupuestoActivo = new HashSet<ZProjectPresupuestoActivo>();
        }

        public decimal Id { get; set; }
        public Guid Uid { get; set; }
        public Guid? UidCompany { get; set; }
        public Guid? UidFamilia { get; set; }
        public string Nombre { get; set; }
        public string Fabricante { get; set; }
        public string NumeroDeSerie { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Rfid { get; set; }
        public Guid? PaisDeOrigen { get; set; }
        public DateTime? FechaDeCompra { get; set; }
        public decimal? CosteCompra { get; set; }
        public decimal? PlazoAmortizacion { get; set; }
        public string UnidadAmortizacion { get; set; }
        public string Factura { get; set; }
        public string OrdenDeCompra { get; set; }
        public string Asiento { get; set; }
        public string NumeroPedido { get; set; }
        public string FechaFactura { get; set; }
        public DateTime? FechaOrdenDeCompra { get; set; }
        public DateTime? FechaPedido { get; set; }
        public Guid? UidCaracteristicas { get; set; }
        public Guid? UidDescripcion { get; set; }
        public byte[] Ts { get; set; }
        public decimal? ImportePto { get; set; }
        public decimal? Imputacion { get; set; }
        public decimal? Estado { get; set; }
        public string Proveedor { get; set; }
        public string Cif { get; set; }
        public bool? Alquiler { get; set; }

        public virtual ZActivoFamilia UidFamiliaNavigation { get; set; }
        public virtual ICollection<ZActivoEco> ZActivoEco { get; set; }
        public virtual ICollection<ZActivoFacturas> ZActivoFacturas { get; set; }
        public virtual ICollection<ZProjectPresupuestoActivo> ZProjectPresupuestoActivo { get; set; }
    }
}
