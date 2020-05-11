using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioPublico
    {
        public string Entidad { get; set; }
        public string NumeroRecibo { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal ValorPagado { get; set; }

        

        public override string ToString()
        {
            return $"{Entidad};{NumeroRecibo};{FechaPago.ToString("dd/MM/yyyy")};{ValorPagado}";
        }

    }
}
