using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cabina : Dispositivo
    {
        private Tipo tipo;
        private Marcas marca;

        public Cabina(string identificacion, Tipo tipo, Marcas marca) : base(identificacion)
        {
            this.tipo = tipo;
            this.marca = marca;
        }
    }
}
