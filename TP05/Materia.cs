using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class Materia
    {
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public int Cuatrimestre { get; set; }
        public List<Nota> Notas { get; set; }
    }
}
