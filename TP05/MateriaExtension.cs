using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    static class MateriaExtension
    {
        public static double CalcularPromedio(this Materia materia)
        {
            return materia.Notas.Sum(x => x.Valor);
        }
    }
}
