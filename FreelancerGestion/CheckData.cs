using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerGestion
{
    class CheckData
    {
        public string dateAsStr;
        public string typeAsStr;
        public string originAsStr;

        public CheckData(DateTime date, string origin, FreelancerGestion.Status status)
        {
            this.dateAsStr = date.ToShortDateString() + " " + date.ToShortTimeString();
            this.originAsStr = origin;
            this.typeAsStr = status.ToString();
        }

        public string date
        {
            get
            {
                return dateAsStr;
            }
        }

        public string type
        {
            get
            {
                return typeAsStr;
            }
        }

        public string origin
        {
            get
            {
                return originAsStr;
            }
        }
    }
}
