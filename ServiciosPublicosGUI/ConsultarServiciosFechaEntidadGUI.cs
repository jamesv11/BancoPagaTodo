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
    public partial class ConsultarServiciosFechaEntidadGUI : Form
    {
        public ConsultarServiciosFechaEntidadGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TablaDgv.DataSource = null;
               

                ServicioPublicoService servicioPublicoService = new ServicioPublicoService();
                servicioPublicoService.Consultar();
                string entidad = EntidadCmb.Text;
                DateTime fecha = FechaDtp.Value.Date;
                TablaDgv.DataSource = servicioPublicoService.ObtenerServiciosFiltroEntidadFecha(entidad, fecha);
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error");
            }
           
            

            

        }
    }
}
