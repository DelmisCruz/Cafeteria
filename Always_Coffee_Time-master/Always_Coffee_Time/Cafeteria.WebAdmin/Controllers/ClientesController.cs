using Cafeteria.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cafeteria.WebAdmin.Controllers
{
    public class ClientesController : Controller
    {
        ClientesBL _clientesBL;

        public ClientesController()
        {
            _clientesBL = new ClientesBL();
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var listadeClientes = _clientesBL.ObtenerClientes();

            return View(listadeClientes);
        }

        public ActionResult Crear()
        {
            var nuevoCliente = new Cliente();

            return View(nuevoCliente);
        }

        [HttpPost]
        public ActionResult Crear(Cliente cliente, HttpPostedFileBase imagen) //cambio
        {
            if (ModelState.IsValid)
            {
                _clientesBL.GuardarCliente(cliente);

                if (imagen != null) // cambio 
                {
                    cliente.UrlImagen = GuardarImagen(imagen);
                }

                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Editar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente, HttpPostedFileBase imagen) // cambio
        {
            if (ModelState.IsValid)
            {
                _clientesBL.GuardarCliente(cliente);

                if (imagen != null) // cambio 
                {
                    cliente.UrlImagen = GuardarImagen(imagen);
                }

                _clientesBL.GuardarCliente(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Detalle(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        public ActionResult Eliminar(int id)
        {
            var cliente = _clientesBL.ObtenerCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Eliminar(Cliente cliente)
        {
            _clientesBL.EliminarCliente(cliente.Id);

            return RedirectToAction("Index");
        }

        private string GuardarImagen(HttpPostedFileBase imagen) //Cambio 
        {
            string path = Server.MapPath("~/Imagenes1/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/Imagenes1/" + imagen.FileName;
        }
    }

}