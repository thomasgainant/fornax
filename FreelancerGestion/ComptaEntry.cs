using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerGestion
{
    public class ComptaEntry
    {
        public string libelle;
        public DateTime date;
        public float amount;
        public float chargesPourcent;

        public ComptaEntry(string libelle, DateTime date, float amount)
        {
            this.libelle = libelle;
            this.date = date;
            this.amount = amount;
            this.chargesPourcent = FreelancerGestion.defaultCharge;
        }

        public ComptaEntry(string libelle, DateTime date, float amount, float chargePourcent)
        {
            this.libelle = libelle;
            this.date = date;
            this.amount = amount;
            this.chargesPourcent = chargePourcent;
        }

        public float getReste()
        {
            float reste = this.amount - (this.amount * (this.chargesPourcent * 0.01f));
            return reste;
        }

        public string Libelle
        {
            get
            {
                return this.libelle;
            }
        }

        public string Date
        {
            get
            {
                return this.date.ToShortDateString();
            }
        }

        public string Amount
        {
            get
            {
                return ""+this.amount;
            }
        }

        public string Charge
        {
            get
            {
                return "" + this.chargesPourcent + "%";
            }
        }

        public string Reste
        {
            get
            {
                float reste = this.getReste();
                return reste+"";
            }
        }
    }
}
