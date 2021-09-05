using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Ingreso
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public int Identificacion { get; set; }
        public int Edad { get; set; }
        public Casa Casa { get; set; }
    }
}
