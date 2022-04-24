using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "MariselaCruz";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("12345678");
            

            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
    }
}
