using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerGestion
{
    public partial class Form1 : Form
    {
        public FreelancerGestion appInstance;

        public Form1()
        {
            InitializeComponent();

            //this.checksList.AutoGenerateColumns = true;

            /*if (!EventLog.SourceExists("FreelancerGestion"))
                EventLog.CreateEventSource("FreelancerGestion", "FreelancerGestion");*/

            this.appInstance = new FreelancerGestion();

            //Check list
            this.refreshForm();

            //Button
            if (this.appInstance.currentStatus == FreelancerGestion.Status.CheckedOut)
            {
                this.checkButton.Text = "Check in";
            }
            else if(this.appInstance.currentStatus == FreelancerGestion.Status.CheckedIn)
            {
                this.checkButton.Text = "Check out";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.appInstance.currentStatus == FreelancerGestion.Status.CheckedOut){
                this.appInstance.currentStatus = FreelancerGestion.Status.CheckedIn;
                this.appInstance.checks.Add(new Check(
                    DateTime.Now,
                    FreelancerGestion.Status.CheckedIn,
                    "" +""+FreelancerGestion.GetExternalIp()
                ));
                this.refreshForm();
            }
            else
            {
                this.appInstance.currentStatus = FreelancerGestion.Status.CheckedOut;
                this.appInstance.checks.Add(new Check(
                    DateTime.Now,
                    FreelancerGestion.Status.CheckedOut,
                    "" +FreelancerGestion.GetExternalIp()
                ));
                this.refreshForm();
            }

            if (this.appInstance.currentStatus == FreelancerGestion.Status.CheckedOut)
            {
                this.checkButton.Text = "Check in";
            }
            else
            {
                this.checkButton.Text = "Check out";
            }

            this.appInstance.saveChecksInXml();
        }

        private void checksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refreshForm()
        {
            //Textboxes
            this.textBox1.Text = ""+this.appInstance.tjm;
            this.textBox2.Text = "" + this.appInstance.heuresParJour;
            this.textBox3.Text = "" + this.appInstance.tarifHoraire;

            TimeSpan total = this.appInstance.getTotalHours();
            System.Diagnostics.Debug.WriteLine("total: "+total.ToString());
            this.totalHours.Text = ""+Math.Floor(total.TotalHours)+"h "+total.Minutes+"m";

            //Checks list
            BindingSource newChecks = new BindingSource();

            foreach(Check check in this.appInstance.checks){
                //System.Diagnostics.Debug.WriteLine((DateTime)checkObj[0]);
                CheckData checkData = new CheckData(check.date, check.origin, check.type);
                newChecks.Add(checkData);
                //System.Diagnostics.Debug.WriteLine(checkData.dateAsStr);
            }
            this.checksList.DataSource = newChecks;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.appInstance.tjm = float.Parse(this.textBox1.Text);
            this.appInstance.tarifHoraire = this.appInstance.tjm / this.appInstance.heuresParJour;

            this.refreshForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.appInstance.heuresParJour = float.Parse(this.textBox2.Text);
            this.appInstance.tarifHoraire = this.appInstance.tjm / this.appInstance.heuresParJour;

            this.refreshForm();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.appInstance.tarifHoraire = float.Parse(this.textBox3.Text);
            this.appInstance.tjm = this.appInstance.tarifHoraire * this.appInstance.heuresParJour;

            this.refreshForm();
        }

        private void tauxHoraireRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(this.tauxHoraireRadio.Checked)
            {
                this.appInstance.factureALaJournee = false;
                this.factureTotale.Text = "" +this.appInstance.getFactureTotale()+"€";
            }
        }

        private void tjmRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tjmRadio.Checked)
            {
                this.appInstance.factureALaJournee = true;
                this.factureTotale.Text = "" + this.appInstance.getFactureTotale() + "€";
            }
        }

        private void comptabiliteButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(this.appInstance);
            form2.Show();
        }
    }
}
