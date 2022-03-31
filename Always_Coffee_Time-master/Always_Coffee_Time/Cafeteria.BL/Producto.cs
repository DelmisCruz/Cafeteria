using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.BL
{
    public class Producto
    {
        public Producto()
        {
            Activo = true;
        }

        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingrese una Descripcion")]
        [MinLength(4, ErrorMessage = "Ingrese un minimo de 3 caracteres")]
        [MaxLength(20, ErrorMessage = "Ingrese un maximo de 30 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Ingrese un Precio")]
        [Range(0, 600, ErrorMessage = "Ingrese un Precio entre 0 y 600")]
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
        public object Existente { get; internal set; }
    }
}
