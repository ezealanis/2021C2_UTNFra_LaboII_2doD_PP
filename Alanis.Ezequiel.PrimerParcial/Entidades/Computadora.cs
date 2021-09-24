using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Computadora : Dispositivo
    {
        private List<Software> software;
        private List<Perifericos> perifericos;
        private List<Juegos> juegos;

        #region Propiedades

        public List<Software> Software
        {
            get
            {
                return this.software;
            }
        }

        public List<Perifericos> Perifericos
        {
            get
            {
                return this.perifericos;
            }
        }

        public List<Juegos> Juegos
        {
            get
            {
                return this.juegos;
            }
        }

        #endregion

        public Computadora(string identificacion) : base(identificacion)
        {
            this.software = new List<Software>();
            this.perifericos = new List<Perifericos>();
            this.juegos = new List<Juegos>();
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Informacion de la PC: {base.ToString()} \n");
            datos.AppendLine(InfoSoftware());
            datos.AppendLine(InfoPerifericos());
            datos.AppendLine(InfoJuegos());

            return datos.ToString();
        }

        private string InfoSoftware()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(" Software: ");

            foreach(Software item in this.Software)
            {
                info.AppendLine($"  {item}");
            }

            return info.ToString();
        }

        private string InfoPerifericos()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(" Perifericos: ");

            foreach (Perifericos item in this.Perifericos)
            {
                info.AppendLine($"  {item}");
            }

            return info.ToString();
        }

        private string InfoJuegos()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(" Juegos: ");

            foreach (Juegos item in this.Juegos)
            {
                info.AppendLine($"  {item}");
            }

            return info.ToString();
        }        

        #region Sobrecarga

        public static bool operator ==(Computadora pc, Software software)
        {
            bool retorno = false;

            foreach (Software item in pc.Software)
            {
                if (item == software)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Computadora pc, Software software)
        {
            return !(pc == software);
        }

        public static Computadora operator +(Computadora pc, Software software)
        {
            if(pc != software)
            {
                pc.Software.Add(software);
            }

            return pc;
        }


        public static bool operator ==(Computadora pc, Perifericos periferico)
        {
            bool retorno = false;

            foreach (Perifericos item in pc.Perifericos)
            {
                if (item == periferico)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Computadora pc, Perifericos periferico)
        {
            return !(pc == periferico);
        }

        public static Computadora operator +(Computadora pc, Perifericos periferico)
        {
            if (pc != periferico)
            {
                pc.Perifericos.Add(periferico);
            }

            return pc;
        }


        public static bool operator ==(Computadora pc, Juegos juego)
        {
            bool retorno = false;

            foreach (Juegos item in pc.Juegos)
            {
                if (item == juego)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Computadora pc, Juegos juego)
        {
            return !(pc == juego);
        }

        public static Computadora operator +(Computadora pc, Juegos juego)
        {
            if (pc != juego)
            {
                pc.Juegos.Add(juego);
            }

            return pc;
        }
        
        #endregion
    }
}
