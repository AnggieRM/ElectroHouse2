using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroHouse
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void formProveedor_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string ruc = txtRUC.Text;
            string Ciudad = txtCiudad.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            List<string> provedores = new List<string>
            {
                codigo,
                nombre,
                Telefono,

            };

            ListViewItem item1 = new ListViewItem(provedores.ToArray());
            listView1.Items.Add(item1);


            // Limpia los campos de entrada
            txtCodigo.Clear();
            txtNombre.Clear();
            txtRUC.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
    }
}
