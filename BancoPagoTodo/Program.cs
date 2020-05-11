using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace BancoPagoTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;
            ServicioPublico servicio = new ServicioPublico()
            {
                Entidad = "Emdupar",
                NumeroRecibo = "1",
                FechaPago = fecha,
                ValorPagado = 10000

                
            };

            ServicioPublicoService servicioPublicoService = new ServicioPublicoService();
            servicioPublicoService.Guardar(servicio);
        }
    }
}
