using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Taxes
    {

            public string Placa { get; set; }
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public string TipoDeVehicullo { get; set; }
            public int Avaluo { get; set; }
            public string Nombre { get; set; }
            public string Cedula { get; set; }


        public double CalculoAvaluo (int valorVehiculo)
        {
            double total;
            if (valorVehiculo <= 39000000)
            {
               return total = (valorVehiculo * 2.5) / 100;
            }
            else return total = (valorVehiculo * 4.0) / 100;
        }
    }
}
