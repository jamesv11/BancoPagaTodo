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
    public partial class RegistrarServicioGUI : Form
    {
        public RegistrarServicioGUI()
        {
            InitializeComponent();
        }

        private void RegistrarServicioGUI_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            ServicioPublicoService servicioPublicoService = new ServicioPublicoService();
            
            
        }
    }
}
