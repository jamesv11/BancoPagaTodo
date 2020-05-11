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
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {                
                respuesta.ServiciosPublico = servicioPublicoRepository.Consultar();
                if (respuesta.ServiciosPublico != null)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de personas";
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                }
                
            }
            catch (Exception e)
            {
                respuesta.ServiciosPublico = null;
                respuesta.Mensaje = $"Error en la consulta {e.Message}";
            }
            return respuesta;

        }
        public int ObtenerCantidadServicioElectricaribe()
        {
            return servicioPublicoRepository.ObtenerCantidadServicioElectricaribe();
        }
        public int ObtenerCantidadServicioGasCaribe()
        {
            return servicioPublicoRepository.ObtenerCantidadServicioGasCaribe();
        }
        public int ObtenerCantidadServicioEmdupar()
        {
            return servicioPublicoRepository.ObtenerCantidadServicioEmdupar();
        }
        public RespuestaConsulta ObtenerServiciosFiltroEntidadFecha(string entidad, DateTime fecha)
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
               
                respuestaConsulta.ServiciosPublico = servicioPublicoRepository.ObtenerServiciosFiltroEntidadFecha(entidad, fecha);
                respuestaConsulta.Mensaje = "La consulta ha sido realizada con exito";
            }
            catch (Exception e)
            {

                respuestaConsulta.ServiciosPublico = null;
                respuestaConsulta.Mensaje = $"Error en los datos {e.Message}";
            }
            return respuestaConsulta;
           
        }
        public decimal ValorTotalServiciosPublicos(IList<ServicioPublico> servicioPublicos)
        {
            return servicioPublicoRepository.ValorTotalServiciosPublicos(servicioPublicos);
        }
        public ServicioPublico CrearServicioPublico(string entidad,string numeroRecibo,DateTime fecha,decimal valor)
        {
            ServicioPublico servicioPublico = new ServicioPublico()
            {
                Entidad = entidad,
                NumeroRecibo = numeroRecibo,
                FechaPago = fecha,
                ValorPagado = valor

            };
            return servicioPublico;
        }
    }
    public class RespuestaConsulta
    {
        public IList<ServicioPublico> ServiciosPublico { get; set; }
        public string Mensaje { get; set; }
    }
}
