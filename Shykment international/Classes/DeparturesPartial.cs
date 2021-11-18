using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shykment_international
{
    public partial class Departures
    {
        public string HoursAndMinutesDeparture
        {
            get
            {
                return $"{Departure.Value.Hour}:{Departure.Value.ToString("mm")}";
            }
                set { }
            }

        public string HoursAndMinutesArrival
        {
            get
            {
                return $"{Arrival.Value.Hour}:{Arrival.Value.ToString("mm")}";
            }
            set { }
        }

        public string HoursAndMinutesRegister
        {
            get
            {
                return $"{StartRegister.Value.Hour}:{StartRegister.Value.ToString("mm")} - {EndRegister.Value.Hour}:{EndRegister.Value.ToString("mm")}";
            }
            set { }
        }
    }
}
