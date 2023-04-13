using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multas
{
    class Conductor
    {
        public Conductor()
        {
        }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Nacimiento { get; set; }
        public Vehiculo vehiculo { get; set; }
        public int Multa;

        public string Licencia;

        public void Tipo (string tipo)
        {
            switch (tipo)
            {
                case "1":
                    Multa = 1800;
                    break;
                case "2":
                    Multa = 59520;
                    break;
                case "3":
                    Multa = 3750;
                    break;
                case "4":
                    Multa = 2560;
                    break;
                case "5":
                    Multa = 3890;
                    break;
            }
        }
        
    }
}
