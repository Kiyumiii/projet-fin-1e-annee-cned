
namespace appli.Vue
{
    partial class FormAbs
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
            this.btnannuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.combomotif = new System.Windows.Forms.ComboBox();
            this.grbabs = new System.Windows.Forms.GroupBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datefin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datedeb = new System.Windows.Forms.DateTimePicker();
            this.BOUTONMODIF = new System.Windows.Forms.Button();
            this.Btndel = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.databloc = new System.Windows.Forms.DataGridView();
            this.grbdata = new System.Windows.Forms.GroupBox();
            this.pers = new System.Windows.Forms.Button();
            this.grbabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databloc)).BeginInit();
            this.grbdata.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnannuler.Location = new System.Drawing.Point(663, 147);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(92, 31);
            this.btnannuler.TabIndex = 6;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(48, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Motif";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnregistrer.Location = new System.Drawing.Point(553, 147);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 31);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // combomotif
            // 
            this.combomotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combomotif.FormattingEnabled = true;
            this.combomotif.Location = new System.Drawing.Point(108, 150);
            this.combomotif.Name = "combomotif";
            this.combomotif.Size = new System.Drawing.Size(266, 28);
            this.combomotif.TabIndex = 0;
            // 
            // grbabs
            // 
            this.grbabs.Controls.Add(this.txtprenom);
            this.grbabs.Controls.Add(this.label4);
            this.grbabs.Controls.Add(this.label3);
            this.grbabs.Controls.Add(this.txtnom);
            this.grbabs.Controls.Add(this.label2);
            this.grbabs.Controls.Add(this.datefin);
            this.grbabs.Controls.Add(this.label1);
            this.grbabs.Controls.Add(this.datedeb);
            this.grbabs.Controls.Add(this.btnannuler);
            this.grbabs.Controls.Add(this.label5);
            this.grbabs.Controls.Add(this.btnEnregistrer);
            this.grbabs.Controls.Add(this.combomotif);
            this.grbabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grbabs.Location = new System.Drawing.Point(18, 245);
            this.grbabs.Name = "grbabs";
            this.grbabs.Size = new System.Drawing.Size(770, 201);
            this.grbabs.TabIndex = 7;
            this.grbabs.TabStop = false;
            this.grbabs.Text = "Ajouter une absence";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(488, 41);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(266, 30);
            this.txtprenom.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(418, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(50, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(108, 41);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(266, 30);
            this.txtnom.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(418, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date fin";
            // 
            // datefin
            // 
            this.datefin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datefin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datefin.Location = new System.Drawing.Point(489, 97);
            this.datefin.Name = "datefin";
            this.datefin.Size = new System.Drawing.Size(266, 26);
            this.datefin.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Date début";
            // 
            // datedeb
            // 
            this.datedeb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datedeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datedeb.Location = new System.Drawing.Point(108, 97);
            this.datedeb.Name = "datedeb";
            this.datedeb.Size = new System.Drawing.Size(266, 26);
            this.datedeb.TabIndex = 8;
            // 
            // BOUTONMODIF
            // 
            this.BOUTONMODIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BOUTONMODIF.Location = new System.Drawing.Point(202, 171);
            this.BOUTONMODIF.Name = "BOUTONMODIF";
            this.BOUTONMODIF.Size = new System.Drawing.Size(92, 31);
            this.BOUTONMODIF.TabIndex = 3;
            this.BOUTONMODIF.Text = "Modifier";
            this.BOUTONMODIF.UseVisualStyleBackColor = true;
            this.BOUTONMODIF.Click += new System.EventHandler(this.BOUTONMODIF_Click);
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
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // databloc
            // 
            this.databloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databloc.Location = new System.Drawing.Point(6, 14);
            this.databloc.Name = "databloc";
            this.databloc.Size = new System.Drawing.Size(764, 151);
            this.databloc.TabIndex = 0;
            // 
            // grbdata
            // 
            this.grbdata.Controls.Add(this.pers);
            this.grbdata.Controls.Add(this.BOUTONMODIF);
            this.grbdata.Controls.Add(this.Btndel);
            this.grbdata.Controls.Add(this.btnAjouter);
            this.grbdata.Controls.Add(this.databloc);
            this.grbdata.Location = new System.Drawing.Point(12, 23);
            this.grbdata.Name = "grbdata";
            this.grbdata.Size = new System.Drawing.Size(776, 208);
            this.grbdata.TabIndex = 6;
            this.grbdata.TabStop = false;
            // 
            // pers
            // 
            this.pers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pers.Location = new System.Drawing.Point(300, 171);
            this.pers.Name = "pers";
            this.pers.Size = new System.Drawing.Size(173, 31);
            this.pers.TabIndex = 4;
            this.pers.Text = "Gerer les personnels";
            this.pers.UseVisualStyleBackColor = true;
            this.pers.Click += new System.EventHandler(this.pers_Click);
            // 
            // FormAbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.grbabs);
            this.Controls.Add(this.grbdata);
            this.Name = "FormAbs";
            this.Text = " Absences";
            this.grbabs.ResumeLayout(false);
            this.grbabs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databloc)).EndInit();
            this.grbdata.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox combomotif;
        private System.Windows.Forms.GroupBox grbabs;
        private System.Windows.Forms.Button BOUTONMODIF;
        private System.Windows.Forms.Button Btndel;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView databloc;
        private System.Windows.Forms.GroupBox grbdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datedeb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datefin;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button pers;
    }
}