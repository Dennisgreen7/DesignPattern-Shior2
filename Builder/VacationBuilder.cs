using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class VacationBuilder
    {
        protected Vacation vacation;

        public VacationBuilder()
        {
            this.vacation = new Vacation();
        }
        public abstract void BuildFligth();
        public abstract void BuildHotel();
        public abstract void BuildTranportation();

        public void ConstructVacation()
        {
            BuildFligth();
            BuildHotel();
            BuildTranportation();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }


    }
}
