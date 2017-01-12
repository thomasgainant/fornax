namespace FreelancerGestion
{
    partial class Form1
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
            this.checkButton = new System.Windows.Forms.Button();
            this.checksList = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalHours = new System.Windows.Forms.Label();
            this.tauxHoraireRadio = new System.Windows.Forms.RadioButton();
            this.tjmRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.factureTotale = new System.Windows.Forms.Label();
            this.comptabiliteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checksList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.AccessibleName = "";
            this.checkButton.Location = new System.Drawing.Point(644, 12);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(96, 66);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check in";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checksList
            // 
            this.checksList.AllowUserToAddRows = false;
            this.checksList.AllowUserToDeleteRows = false;
            this.checksList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checksList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.type,
            this.origin});
            this.checksList.Location = new System.Drawing.Point(216, 12);
            this.checksList.Name = "checksList";
            this.checksList.ReadOnly = true;
            this.checksList.Size = new System.Drawing.Size(422, 527);
            this.checksList.TabIndex = 2;
            this.checksList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checksList_CellContentClick);
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.origin.DataPropertyName = "origin";
            this.origin.HeaderText = "Origin";
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TJM :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "heures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Journée :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Taux horaire :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total d\'heures :";
            // 
            // totalHours
            // 
            this.totalHours.AutoSize = true;
            this.totalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.totalHours.Location = new System.Drawing.Point(99, 220);
            this.totalHours.Name = "totalHours";
            this.totalHours.Size = new System.Drawing.Size(0, 29);
            this.totalHours.TabIndex = 13;
            // 
            // tauxHoraireRadio
            // 
            this.tauxHoraireRadio.AutoSize = true;
            this.tauxHoraireRadio.Location = new System.Drawing.Point(3, 26);
            this.tauxHoraireRadio.Name = "tauxHoraireRadio";
            this.tauxHoraireRadio.Size = new System.Drawing.Size(84, 17);
            this.tauxHoraireRadio.TabIndex = 14;
            this.tauxHoraireRadio.Text = "Taux horaire";
            this.tauxHoraireRadio.UseVisualStyleBackColor = true;
            this.tauxHoraireRadio.CheckedChanged += new System.EventHandler(this.tauxHoraireRadio_CheckedChanged);
            // 
            // tjmRadio
            // 
            this.tjmRadio.AutoSize = true;
            this.tjmRadio.Checked = true;
            this.tjmRadio.Location = new System.Drawing.Point(3, 3);
            this.tjmRadio.Name = "tjmRadio";
            this.tjmRadio.Size = new System.Drawing.Size(136, 17);
            this.tjmRadio.TabIndex = 15;
            this.tjmRadio.TabStop = true;
            this.tjmRadio.Text = "Facturation à la journée";
            this.tjmRadio.UseVisualStyleBackColor = true;
            this.tjmRadio.CheckedChanged += new System.EventHandler(this.tjmRadio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.factureTotale);
            this.panel1.Controls.Add(this.tjmRadio);
            this.panel1.Controls.Add(this.tauxHoraireRadio);
            this.panel1.Location = new System.Drawing.Point(16, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 16;
            // 
            // factureTotale
            // 
            this.factureTotale.AutoSize = true;
            this.factureTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.factureTotale.Location = new System.Drawing.Point(4, 63);
            this.factureTotale.Name = "factureTotale";
            this.factureTotale.Size = new System.Drawing.Size(0, 29);
            this.factureTotale.TabIndex = 16;
            // 
            // comptabiliteButton
            // 
            this.comptabiliteButton.Location = new System.Drawing.Point(644, 85);
            this.comptabiliteButton.Name = "comptabiliteButton";
            this.comptabiliteButton.Size = new System.Drawing.Size(96, 36);
            this.comptabiliteButton.TabIndex = 17;
            this.comptabiliteButton.Text = "Comptabilité";
            this.comptabiliteButton.UseVisualStyleBackColor = true;
            this.comptabiliteButton.Click += new System.EventHandler(this.comptabiliteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FreelancerGestion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comptabiliteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalHours);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checksList);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Fornax";
            ((System.ComponentModel.ISupportInitialize)(this.checksList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.DataGridView checksList;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalHours;
        private System.Windows.Forms.RadioButton tauxHoraireRadio;
        private System.Windows.Forms.RadioButton tjmRadio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label factureTotale;
        private System.Windows.Forms.Button comptabiliteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

