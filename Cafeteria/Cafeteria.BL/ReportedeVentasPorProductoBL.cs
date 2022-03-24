using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.BL
{
    public class ReportedeVentasPorProductoBL
    {
        Contexto _contexto;
        public List<ReportedeVentasPorProducto> ListadeVentasPorProducto { get; set; }

        public ReportedeVentasPorProductoBL()
        {
            _contexto = new Contexto();
            ListadeVentasPorProducto = new List<ReportedeVentasPorProducto>();
        }

        public List<ReportedeVentasPorProducto> ObtenerVentasPorProducto()
        {
            ListadeVentasPorProducto = _contexto.OrdenDetalle
                .Include("Producto")
                .Where(p => p.Orden.Activo)
                .GroupBy(p => p.Producto.Descripcion)
                .Select(p => new ReportedeVentasPorProducto()
                {
                    Producto = p.Key,
                    Cantidad = p.Sum(s => s.Cantidad),
                    Total = p.Sum(s => s.Total)
                }).ToList();

            return ListadeVentasPorProducto;
        }
    }
}
