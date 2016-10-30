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
			this.label1.Location = new System.Drawing.Point(56, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom jeux vidéo :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 162);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Classification :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 108);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Année sortie :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(67, 245);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description :";
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(216, 343);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 15;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(74, 343);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 14;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// TbNom
			// 
			this.TbNom.Location = new System.Drawing.Point(144, 32);
			this.TbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TbNom.Name = "TbNom";
			this.TbNom.Size = new System.Drawing.Size(92, 20);
			this.TbNom.TabIndex = 16;
			// 
			// TbDesc
			// 
			this.TbDesc.Location = new System.Drawing.Point(145, 245);
			this.TbDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TbDesc.Multiline = true;
			this.TbDesc.Name = "TbDesc";
			this.TbDesc.Size = new System.Drawing.Size(103, 79);
			this.TbDesc.TabIndex = 17;
			// 
			// TbEditeur
			// 
			this.TbEditeur.Location = new System.Drawing.Point(144, 201);
			this.TbEditeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TbEditeur.Name = "TbEditeur";
			this.TbEditeur.Size = new System.Drawing.Size(92, 20);
			this.TbEditeur.TabIndex = 19;
			// 
			// TbEdit
			// 
			this.TbEdit.AutoSize = true;
			this.TbEdit.Location = new System.Drawing.Point(68, 203);
			this.TbEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.TbEdit.Name = "TbEdit";
			this.TbEdit.Size = new System.Drawing.Size(46, 13);
			this.TbEdit.TabIndex = 20;
			this.TbEdit.Text = "Éditeur :";
			// 
			// numAnnee
			// 
			this.numAnnee.Location = new System.Drawing.Point(144, 106);
			this.numAnnee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.numAnnee.Size = new System.Drawing.Size(90, 20);
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
			this.comboBoxClass.Location = new System.Drawing.Point(143, 160);
			this.comboBoxClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new System.Drawing.Size(92, 21);
			this.comboBoxClass.TabIndex = 22;
			// 
			// FormCRUDJeuxvideox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 424);
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
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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