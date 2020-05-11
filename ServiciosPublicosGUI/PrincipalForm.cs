using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace ServiciosPublicosGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarServicioGUI registrarServicioGUI = new RegistrarServicioGUI();
            registrarServicioGUI.Show();


        }

        private void filtroFechaentidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarServiciosFechaEntidadGUI consultarServiciosFechaEntidadGUI = new ConsultarServiciosFechaEntidadGUI();
            consultarServiciosFechaEntidadGUI.Show();
        }
    }
}
