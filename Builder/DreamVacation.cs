using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
     class DreamVacation : VacationBuilder
    {
        public override void BuildFligth()
        {
            vacation.SetFlight("Direct flight in first class");
        }

        public override void BuildHotel()
        {
            vacation.SetHotel(" Five Satr Hotel");
        }

        public override void BuildTranportation()
        {
            vacation.SetTranportation("Direct transfer to the hotel by special taxi");
        }
    }
}
