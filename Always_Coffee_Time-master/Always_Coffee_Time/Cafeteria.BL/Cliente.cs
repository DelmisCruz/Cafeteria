using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.BL
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del cliente")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 3 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese el telefono")]
        [MinLength(8, ErrorMessage = "El telefono debe ser de 8 digitos")]
        [MaxLength(8, ErrorMessage = "El telefono debe ser de 8 digitos")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese la direccion")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 6 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Ingrese un correo")]
        [MinLength(3, ErrorMessage = "Ingrese mínimo 8 caracteres")]
        public string Correo { get; set; }

        [Display(Name = "Foto")] //cambio
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}