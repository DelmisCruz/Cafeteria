using Cafeteria.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria.Win
{
    public partial class Form2 : Form
    {
        ReporteVentasPorProductoBL _reporteVentasPorProductoBL;

        public Form2()
        {
            InitializeComponent();
            _reporteVentasPorProductoBL = new ReporteVentasPorProductoBL();

            RefrescarDatos();
        }

        private void listaVentasPorProductoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            var listaVentasPorProducto = _reporteVentasPorProductoBL.ObtenerVentasPorProducto();
            listaVentasPorProductoBindingSource.DataSource = listaVentasPorProducto;
            listaVentasPorProductoBindingSource.ResetBindings(false);
        }
    }
}
