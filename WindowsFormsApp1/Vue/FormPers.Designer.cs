
namespace appli.Vue
{
    partial class FormPers
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
            this.grbdata = new System.Windows.Forms.GroupBox();
            this.BOUTONMODIF = new System.Windows.Forms.Button();
            this.BtnAbs = new System.Windows.Forms.Button();
            this.Btndel = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.databloc = new System.Windows.Forms.DataGridView();
            this.grbpersonnel = new System.Windows.Forms.GroupBox();
            this.Btnannuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.comboservice = new System.Windows.Forms.ComboBox();
            this.grbdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databloc)).BeginInit();
            this.grbpersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbdata
            // 
            this.grbdata.Controls.Add(this.BOUTONMODIF);
            this.grbdata.Controls.Add(this.BtnAbs);
            this.grbdata.Controls.Add(this.Btndel);
            this.grbdata.Controls.Add(this.btnAjouter);
            this.grbdata.Controls.Add(this.databloc);
            this.grbdata.Location = new System.Drawing.Point(12, 8);
            this.grbdata.Name = "grbdata";
            this.grbdata.Size = new System.Drawing.Size(776, 208);
            this.grbdata.TabIndex = 0;
            this.grbdata.TabStop = false;
            // 
            // BOUTONMODIF
            // 
            this.BOUTONMODIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BOUTONMODIF.Location = new System.Drawing.Point(202, 171);
            this.BOUTONMODIF.Name = "BOUTONMODIF";
            this.BOUTONMODIF.Size = new System.Drawing.Size(92, 31);
            this.BOUTONMODIF.TabIndex = 5;
            this.BOUTONMODIF.Text = "Modifier";
            this.BOUTONMODIF.UseVisualStyleBackColor = true;
            this.BOUTONMODIF.Click += new System.EventHandler(this.BOUTONMODIF_Click);
            // 
            // BtnAbs
            // 
            this.BtnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnAbs.Location = new System.Drawing.Point(300, 171);
            this.BtnAbs.Name = "BtnAbs";
            this.BtnAbs.Size = new System.Drawing.Size(171, 31);
            this.BtnAbs.TabIndex = 4;
            this.BtnAbs.Text = "Gérer les absences";
            this.BtnAbs.UseVisualStyleBackColor = true;
            this.BtnAbs.Click += new System.EventHandler(this.BtnAbs_Click);
            // 
            // Btndel
            // 
            this.Btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btndel.Location = new System.Drawing.Point(104, 171);
            this.Btndel.Name = "Btndel";
            this.Btndel.Size = new System.Drawing.Size(92, 31);
            this.Btndel.TabIndex = 2;
            this.Btndel.Text = "Supprimer";
            this.Btndel.UseVisualStyleBackColor = true;
            this.Btndel.Click += new System.EventHandler(this.Btndel_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAjouter.Location = new System.Drawing.Point(6, 171);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 31);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // databloc
            // 
            this.databloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databloc.Location = new System.Drawing.Point(6, 14);
            this.databloc.Name = "databloc";
            this.databloc.Size = new System.Drawing.Size(764, 151);
            this.databloc.TabIndex = 0;
            // 
            // grbpersonnel
            // 
            this.grbpersonnel.Controls.Add(this.Btnannuler);
            this.grbpersonnel.Controls.Add(this.label5);
            this.grbpersonnel.Controls.Add(this.btnEnregistrer);
            this.grbpersonnel.Controls.Add(this.label3);
            this.grbpersonnel.Controls.Add(this.txttel);
            this.grbpersonnel.Controls.Add(this.label4);
            this.grbpersonnel.Controls.Add(this.txtmail);
            this.grbpersonnel.Controls.Add(this.label2);
            this.grbpersonnel.Controls.Add(this.txtprenom);
            this.grbpersonnel.Controls.Add(this.label1);
            this.grbpersonnel.Controls.Add(this.txtnom);
            this.grbpersonnel.Controls.Add(this.comboservice);
            this.grbpersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grbpersonnel.Location = new System.Drawing.Point(18, 230);
            this.grbpersonnel.Name = "grbpersonnel";
            this.grbpersonnel.Size = new System.Drawing.Size(770, 182);
            this.grbpersonnel.TabIndex = 5;
            this.grbpersonnel.TabStop = false;
            this.grbpersonnel.Text = "Ajouter un personnel";
            // 
            // Btnannuler
            // 
            this.Btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btnannuler.Location = new System.Drawing.Point(669, 134);
            this.Btnannuler.Name = "Btnannuler";
            this.Btnannuler.Size = new System.Drawing.Size(92, 31);
            this.Btnannuler.TabIndex = 6;
            this.Btnannuler.Text = "Annuler";
            this.Btnannuler.UseVisualStyleBackColor = true;
            this.Btnannuler.Click += new System.EventHandler(this.Btnannuler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Service";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnregistrer.Location = new System.Drawing.Point(559, 134);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 31);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(375, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Téléphone";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttel.Location = new System.Drawing.Point(465, 90);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(299, 26);
            this.txttel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmail.Location = new System.Drawing.Point(68, 90);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(299, 26);
            this.txtmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(382, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom";
            // 
            // txtprenom
            // 
            this.txtprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtprenom.Location = new System.Drawing.Point(462, 34);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(299, 26);
            this.txtprenom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnom.Location = new System.Drawing.Point(65, 34);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(299, 26);
            this.txtnom.TabIndex = 5;
            // 
            // comboservice
            // 
            this.comboservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboservice.FormattingEnabled = true;
            this.comboservice.Location = new System.Drawing.Point(73, 142);
            this.comboservice.Name = "comboservice";
            this.comboservice.Size = new System.Drawing.Size(294, 28);
            this.comboservice.TabIndex = 0;
            // 
            // FormPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbpersonnel);
            this.Controls.Add(this.grbdata);
            this.Name = "FormPers";
            this.Text = "Personnel";
            this.grbdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databloc)).EndInit();
            this.grbpersonnel.ResumeLayout(false);
            this.grbpersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbdata;
        private System.Windows.Forms.DataGridView databloc;
        private System.Windows.Forms.Button BtnAbs;
        private System.Windows.Forms.Button Btndel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grbpersonnel;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.ComboBox comboservice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnannuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button BOUTONMODIF;
    }
}