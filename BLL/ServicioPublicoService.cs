using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ServicioPublicoService
    {
        private ServicioPublicoRepository servicioPublicoRepository;

        public ServicioPublicoService()
        {
            servicioPublicoRepository = new ServicioPublicoRepository();
        }

        public string Guardar(ServicioPublico servicioPublico)
        {

            try
            {
                if(servicioPublicoRepository.Buscar(servicioPublico.NumeroRecibo) == null)
                {
                    servicioPublicoRepository.Guardar(servicioPublico);

                    return "Se ha registrado con exito";
                }
                return "Ya ha sido registrado";
            }
            catch (Exception e)
            {

                return $"Error en los datos {e.Message}";
            }
        }
    }
}
