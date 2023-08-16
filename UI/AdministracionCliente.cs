using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;

namespace UI
{
    public partial class AdministracionCliente : Form
    {
        public AdministracionCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void administracionCliente_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void CargarGrid()
        {
            try
            {
                gridClientes.DataSource = BLL_Clientes.Lista();
            }
            catch (Exception Error)
            {

                MessageBox.Show(Error.Message);
            }

        }
    }
}
