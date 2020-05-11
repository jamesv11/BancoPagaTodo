using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class ServicioPublicoRepository
    {

        private string ruta = @"ServiciosPublicos.txt";
        IList<ServicioPublico> servicioPublicos = new List<ServicioPublico>();

        public void Guardar(ServicioPublico servicioPublico)
        {

            FileStream fileStream = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(fileStream);
            escritor.WriteLine(servicioPublico.ToString());

            escritor.Close();
            fileStream.Close();

        }

        public IList<ServicioPublico> Consultar()
        {
            servicioPublicos.Clear();

            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);

            string linea = string.Empty;
            while ((linea = lector.ReadLine()) != null)
            {
                ServicioPublico servicioPublico = Mapear(linea);

                servicioPublicos.Add(servicioPublico);
            }
            fileStream.Close();
            lector.Close();
            return servicioPublicos;
        }

        private static ServicioPublico Mapear(string linea)
        {
            ServicioPublico servicioPublico = new ServicioPublico();
            string[] Datos = linea.Split(';');
            servicioPublico.Entidad = Datos[0];
            servicioPublico.NumeroRecibo = Datos[1];
            servicioPublico.FechaPago = DateTime.Parse(Datos[2]);
            servicioPublico.ValorPagado = Decimal.Parse(Datos[3]);
            return servicioPublico;
        }

        public ServicioPublico Buscar(string numeroRecibo)
        {
            servicioPublicos.Clear();
            servicioPublicos = Consultar();

            return servicioPublicos.Where(S => S.NumeroRecibo.Equals(numeroRecibo)).FirstOrDefault();

        }
        public int ObtenerCantidadServicioElectricaribe()
        {
            return servicioPublicos.Where(l => l.Entidad == "Electricaribe").Count();
        }
        public int ObtenerCantidadServicioGasCaribe()
        {
            return servicioPublicos.Where(l => l.Entidad == "GasCaribe").Count();
        }
        public int ObtenerCantidadServicioEmdupar()
        {
            return servicioPublicos.Where(l => l.Entidad == "Emdupar").Count();
        }
        public IList<ServicioPublico> ObtenerServiciosFiltroEntidadFecha(string entidad,string fecha)
        {
            return servicioPublicos.Where(l => l.Entidad == entidad && l.FechaPago.ToString() == fecha).ToList();
        }
        //public IList<ServicioPublico> ObtenerServiciosPublicosGasCaribe()
        //{
        //    return servicioPublicos.Where(l => l.Entidad == "GasCaribe").ToList();
        //}
        //public IList<ServicioPublico> ObtenerServiciosPublicosEmdupar()
        //{
        //    return servicioPublicos.Where(l => l.Entidad == "Emdupar").ToList();
        //}
        public decimal ValorTotalServiciosPublicos(IList<ServicioPublico> servicioPublicos)
        {
            return servicioPublicos.Sum(l => l.ValorPagado);
        }

    }
    }

      



