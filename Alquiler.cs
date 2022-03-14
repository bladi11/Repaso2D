using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2D
{
    class Alquiler //se creo otra clase para poder relacionar los demas datos de las otras 2 clases
    {
        public string nit { get; set; }
        public string placa { get; set; }
        public DateTime fechaAlquiler { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public int kilometrosRecorridos { get; set; }
    }
}
