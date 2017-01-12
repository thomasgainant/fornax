using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerGestion
{
    public class Check
    {
        public DateTime date;
        public FreelancerGestion.Status type;
        public string origin;

        public Check(DateTime date, FreelancerGestion.Status type, string origin)
        {
            this.date = date;
            this.type = type;
            this.origin = origin;
        }
    }
}
