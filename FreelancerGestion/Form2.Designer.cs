namespace FreelancerGestion
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treasuryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaireTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.visibiliteLabel = new System.Windows.Forms.Label();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleEdit = new System.Windows.Forms.TextBox();
            this.dateEdit = new System.Windows.Forms.TextBox();
            this.montantEdit = new System.Windows.Forms.TextBox();
            this.chargeEdit = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libelle,
            this.Date,
            this.Amount,
            this.Charge,
            this.Reste});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // treasuryLabel
            // 
            this.treasuryLabel.AutoSize = true;
            this.treasuryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.treasuryLabel.Location = new System.Drawing.Point(78, 369);
            this.treasuryLabel.Name = "treasuryLabel";
            this.treasuryLabel.Size = new System.Drawing.Size(79, 29);
            this.treasuryLabel.TabIndex = 1;
            this.treasuryLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trésorerie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salaire :";
            // 
            // salaireTextBox
            // 
            this.salaireTextBox.Location = new System.Drawing.Point(79, 398);
            this.salaireTextBox.Name = "salaireTextBox";
            this.salaireTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaireTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Visibilité :";
            // 
            // visibiliteLabel
            // 
            this.visibiliteLabel.AutoSize = true;
            this.visibiliteLabel.Location = new System.Drawing.Point(79, 427);
            this.visibiliteLabel.Name = "visibiliteLabel";
            this.visibiliteLabel.Size = new System.Drawing.Size(35, 13);
            this.visibiliteLabel.TabIndex = 6;
            this.visibiliteLabel.Text = "label4";
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libellé";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Montant";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Charge
            // 
            this.Charge.DataPropertyName = "Charge";
            this.Charge.HeaderText = "Charges";
            this.Charge.Name = "Charge";
            this.Charge.ReadOnly = true;
            // 
            // Reste
            // 
            this.Reste.DataPropertyName = "Reste";
            this.Reste.HeaderText = "Reste";
            this.Reste.Name = "Reste";
            this.Reste.ReadOnly = true;
            // 
            // libelleEdit
            // 
            this.libelleEdit.Location = new System.Drawing.Point(468, 378);
            this.libelleEdit.Name = "libelleEdit";
            this.libelleEdit.Size = new System.Drawing.Size(157, 20);
            this.libelleEdit.TabIndex = 7;
            // 
            // dateEdit
            // 
            this.dateEdit.Location = new System.Drawing.Point(468, 405);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Size = new System.Drawing.Size(156, 20);
            this.dateEdit.TabIndex = 8;
            // 
            // montantEdit
            // 
            this.montantEdit.Location = new System.Drawing.Point(468, 432);
            this.montantEdit.Name = "montantEdit";
            this.montantEdit.Size = new System.Drawing.Size(157, 20);
            this.montantEdit.TabIndex = 9;
            // 
            // chargeEdit
            // 
            this.chargeEdit.Location = new System.Drawing.Point(468, 459);
            this.chargeEdit.Name = "chargeEdit";
            this.chargeEdit.Size = new System.Drawing.Size(156, 20);
            this.chargeEdit.TabIndex = 10;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(549, 486);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Enregistrer";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(468, 486);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Supprimer";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Libellé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Montant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Charges (%)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.chargeEdit);
            this.Controls.Add(this.montantEdit);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.libelleEdit);
            this.Controls.Add(this.visibiliteLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaireTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treasuryLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Comptabilité";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label treasuryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salaireTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label visibiliteLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reste;
        private System.Windows.Forms.TextBox libelleEdit;
        private System.Windows.Forms.TextBox dateEdit;
        private System.Windows.Forms.TextBox montantEdit;
        private System.Windows.Forms.TextBox chargeEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}