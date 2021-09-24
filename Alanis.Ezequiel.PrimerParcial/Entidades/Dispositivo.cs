using System;

namespace Entidades
{
    public abstract class Dispositivo
    {
        protected string identificacion;

        public Dispositivo(string identificacion)
        {
            this.identificacion = identificacion;
        }

        public override string ToString()
        {
            return this.identificacion;
        }
    }
}
