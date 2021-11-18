using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shykment_international
{
    public partial class Arrivals
    {
        public string HoursAndMinutesArrival
        {
            get
            {
                return $"{Arrival.Value.Hour}:{Arrival.Value.ToString("mm")}";
            }
            set { }
        }
    }
}
