namespace PPE3_NotaGame
{
    partial class FormCRUDJeuxvideox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.TbNom = new System.Windows.Forms.TextBox();
            this.TbDesc = new System.Windows.Forms.TextBox();
            this.TbEditeur = new System.Windows.Forms.TextBox();
            this.TbEdit = new System.Windows.Forms.Label();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom jeux vidéo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Classification :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Année sortie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(288, 422);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(99, 422);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // TbNom
            // 
            this.TbNom.Location = new System.Drawing.Point(192, 40);
            this.TbNom.Name = "TbNom";
            this.TbNom.Size = new System.Drawing.Size(121, 22);
            this.TbNom.TabIndex = 16;
            // 
            // TbDesc
            // 
            this.TbDesc.Location = new System.Drawing.Point(193, 302);
            this.TbDesc.Multiline = true;
            this.TbDesc.Name = "TbDesc";
            this.TbDesc.Size = new System.Drawing.Size(136, 96);
            this.TbDesc.TabIndex = 17;
            // 
            // TbEditeur
            // 
            this.TbEditeur.Location = new System.Drawing.Point(192, 247);
            this.TbEditeur.Name = "TbEditeur";
            this.TbEditeur.Size = new System.Drawing.Size(121, 22);
            this.TbEditeur.TabIndex = 19;
            // 
            // TbEdit
            // 
            this.TbEdit.AutoSize = true;
            this.TbEdit.Location = new System.Drawing.Point(91, 250);
            this.TbEdit.Name = "TbEdit";
            this.TbEdit.Size = new System.Drawing.Size(60, 17);
            this.TbEdit.TabIndex = 20;
            this.TbEdit.Text = "éditeur :";
            // 
            // numAnnee
            // 
            this.numAnnee.Location = new System.Drawing.Point(192, 131);
            this.numAnnee.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(120, 22);
            this.numAnnee.TabIndex = 21;
            this.numAnnee.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "3",
            "7",
            "10",
            "12",
            "16",
            "18"});
            this.comboBoxClass.Location = new System.Drawing.Point(191, 197);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClass.TabIndex = 22;
            // 
            // FormCRUDJeuxvideox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 522);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.numAnnee);
            this.Controls.Add(this.TbEdit);
            this.Controls.Add(this.TbEditeur);
            this.Controls.Add(this.TbDesc);
            this.Controls.Add(this.TbNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCRUDJeuxvideox";
            this.Text = "FormCRUDJeuxvideox";
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox TbNom;
        public System.Windows.Forms.TextBox TbDesc;
        private System.Windows.Forms.Label TbEdit;
        public System.Windows.Forms.TextBox TbEditeur;
        public System.Windows.Forms.NumericUpDown numAnnee;
        public System.Windows.Forms.ComboBox comboBoxClass;
    }
}