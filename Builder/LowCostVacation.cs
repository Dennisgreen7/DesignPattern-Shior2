using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LowCostVacation : VacationBuilder
    {
        public override void BuildFligth()
        {
            vacation.SetFlight("Connection flight with a charter company");
        }

        public override void BuildHotel()
        {
            vacation.SetHotel("Three Stars Hotel");
        }

        public override void BuildTranportation()
        {
            vacation.SetTranportation("Bus picks up from the airport to the hotel");
        }
    }
}
