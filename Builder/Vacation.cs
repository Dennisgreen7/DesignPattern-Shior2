using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Vacation
    {
        public string Fligth;
        public string Hotel;
        public string Tranportation;


        public void SetFlight(string fligth)
        {
            this.Fligth = fligth;
        }
        public void SetHotel(string hotel)
        {
            this.Hotel = hotel;
        }
        public void SetTranportation(string tranportation)
        {
            this.Tranportation = tranportation;
        }
    }
}
