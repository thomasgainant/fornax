using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancerGestion
{
    public partial class Form2 : Form
    {
        public FreelancerGestion appInstance;

        public ComptaEntry selectedEntry = null;

        public Form2(FreelancerGestion appInstance)
        {
            this.appInstance = appInstance;

            InitializeComponent();

            this.refresh();
        }

        public void refresh()
        {
            //Grid view
            BindingSource newEntries = new BindingSource();
            foreach (ComptaEntry entry in this.appInstance.entries)
            {
                newEntries.Add(entry);
            }
            this.dataGridView1.DataSource = newEntries;

            //Treasury label
            this.treasuryLabel.Text = this.appInstance.getTreasury()+"€";

            //Salaire label
            this.salaireTextBox.Text = this.appInstance.salaire+"€";

            //Visibilité label
            this.visibiliteLabel.Text = (int)Math.Floor(this.appInstance.getTreasury() / this.appInstance.salaire)+" salaires";

            //Edit labels
            if(this.selectedEntry == null)
            {
                this.libelleEdit.Text = "";
                this.dateEdit.Text = "";
                this.montantEdit.Text = "";
                this.chargeEdit.Text = "";
            }
            else
            {
                this.libelleEdit.Text = this.selectedEntry.libelle;
                this.dateEdit.Text = this.selectedEntry.date.ToShortDateString();
                this.montantEdit.Text = this.selectedEntry.amount + "";
                this.chargeEdit.Text = this.selectedEntry.chargesPourcent + "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedEntry = this.appInstance.entries[e.RowIndex];

            this.libelleEdit.Text = this.selectedEntry.libelle;
            this.dateEdit.Text = this.selectedEntry.date.ToShortDateString();
            this.montantEdit.Text = this.selectedEntry.amount + "";
            this.chargeEdit.Text = this.selectedEntry.chargesPourcent + "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(this.selectedEntry != null){
                this.selectedEntry.libelle = this.libelleEdit.Text;
                this.selectedEntry.date = DateTime.Parse(this.dateEdit.Text);
                this.selectedEntry.amount = float.Parse(this.montantEdit.Text);
                this.selectedEntry.chargesPourcent = float.Parse(this.chargeEdit.Text);

                this.selectedEntry = null;
            }
            else
            {
                ComptaEntry newEntry = null;
                if(this.chargeEdit.Text == "")
                {
                    newEntry = new ComptaEntry(
                        this.libelleEdit.Text,
                        DateTime.Parse(this.dateEdit.Text),
                        float.Parse(this.montantEdit.Text)
                    );
                }
                else
                {
                    newEntry = new ComptaEntry(
                        this.libelleEdit.Text,
                        DateTime.Parse(this.dateEdit.Text),
                        float.Parse(this.montantEdit.Text),
                        float.Parse(this.chargeEdit.Text)
                    );
                }

                this.appInstance.entries.Add(newEntry);
            }

            this.appInstance.saveEntriesInXml();
            this.refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(this.selectedEntry != null){
                DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cette entrée ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    this.appInstance.entries.Remove(this.selectedEntry);
                    this.appInstance.saveEntriesInXml();
                    this.refresh();
                }
                else if (result == DialogResult.No)
                {
                    //do nothing
                }
                else
                {
                    //do nothing
                }
            }
        }
    }
}
