namespace PPE3_NotaGame
{
    partial class FormCRUDCompatible
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
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CbxJeux = new System.Windows.Forms.ComboBox();
			this.CbxSupports = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(215, 221);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 13;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(74, 221);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(220, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Support :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Jeu vidéo :";
			// 
			// CbxJeux
			// 
			this.CbxJeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxJeux.FormattingEnabled = true;
			this.CbxJeux.Location = new System.Drawing.Point(74, 70);
			this.CbxJeux.Name = "CbxJeux";
			this.CbxJeux.Size = new System.Drawing.Size(121, 21);
			this.CbxJeux.TabIndex = 18;
			// 
			// CbxSupports
			// 
			this.CbxSupports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxSupports.FormattingEnabled = true;
			this.CbxSupports.Location = new System.Drawing.Point(223, 70);
			this.CbxSupports.Name = "CbxSupports";
			this.CbxSupports.Size = new System.Drawing.Size(121, 21);
			this.CbxSupports.TabIndex = 19;
			// 
			// FormCRUDCompatible
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 351);
			this.Controls.Add(this.CbxSupports);
			this.Controls.Add(this.CbxJeux);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnOK);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormCRUDCompatible";
			this.Text = "FormCRUDCompatible";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox CbxJeux;
		public System.Windows.Forms.ComboBox CbxSupports;
	}
}