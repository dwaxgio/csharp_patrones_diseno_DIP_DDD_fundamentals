using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Se hace referencia a ui.desktop.applicationController
using UI.Desktop.ApplicationController;

namespace UI.Desktop.Forms
{
    public partial class FormCliente : Form
    {
        // 12.
        // Se instancia controlador del cliente mediante constructor
        private ClientController Client;
        public FormCliente()
        {
            InitializeComponent();
            Client = new ClientController();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Client.GetClientsAll("");
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Client.GetClientsAll(txtFiltrar.Text);
        }
    }
}
