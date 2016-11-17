namespace PPE3_NotaGame
{
    partial class FormCRUDUsers
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
			this.label3 = new System.Windows.Forms.Label();
			this.TbEmail = new System.Windows.Forms.TextBox();
			this.TbPseudo = new System.Windows.Forms.TextBox();
			this.CbxComm = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(248, 384);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 13;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(106, 384);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 12;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 113);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "pseudo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 188);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "commentaire";
			// 
			// TbEmail
			// 
			this.TbEmail.Location = new System.Drawing.Point(116, 35);
			this.TbEmail.Margin = new System.Windows.Forms.Padding(2);
			this.TbEmail.Name = "TbEmail";
			this.TbEmail.Size = new System.Drawing.Size(237, 20);
			this.TbEmail.TabIndex = 17;
			// 
			// TbPseudo
			// 
			this.TbPseudo.Location = new System.Drawing.Point(116, 110);
			this.TbPseudo.Margin = new System.Windows.Forms.Padding(2);
			this.TbPseudo.Name = "TbPseudo";
			this.TbPseudo.Size = new System.Drawing.Size(76, 20);
			this.TbPseudo.TabIndex = 18;
			// 
			// CbxComm
			// 
			this.CbxComm.FormattingEnabled = true;
			this.CbxComm.Location = new System.Drawing.Point(124, 118);
			this.CbxComm.Name = "CbxComm";
			this.CbxComm.Size = new System.Drawing.Size(121, 21);
			this.CbxComm.TabIndex = 19;
			// 
			// FormCRUDUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 464);
			this.Controls.Add(this.CbxComm);
			this.Controls.Add(this.TbPseudo);
			this.Controls.Add(this.TbEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnOK);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormCRUDUsers";
			this.Text = "FormCRUDUsers";
			this.Load += new System.EventHandler(this.FormCRUDUsers_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TbEmail;
        public System.Windows.Forms.TextBox TbPseudo;
		public System.Windows.Forms.ComboBox CbxComm;
	}
}