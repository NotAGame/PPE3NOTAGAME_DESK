namespace PPE3_NotaGame
{
	partial class FormCRUDNoter
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
			this.CbxJeux = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CbxUsers = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NudNote = new System.Windows.Forms.NumericUpDown();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NudNote)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jeu :";
			// 
			// CbxJeux
			// 
			this.CbxJeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxJeux.FormattingEnabled = true;
			this.CbxJeux.Location = new System.Drawing.Point(8, 8);
			this.CbxJeux.Name = "CbxJeux";
			this.CbxJeux.Size = new System.Drawing.Size(121, 21);
			this.CbxJeux.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Utilisateur :";
			// 
			// CbxUsers
			// 
			this.CbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxUsers.FormattingEnabled = true;
			this.CbxUsers.Location = new System.Drawing.Point(24, 24);
			this.CbxUsers.Name = "CbxUsers";
			this.CbxUsers.Size = new System.Drawing.Size(121, 21);
			this.CbxUsers.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Note :";
			// 
			// NudNote
			// 
			this.NudNote.Location = new System.Drawing.Point(8, 8);
			this.NudNote.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.NudNote.Name = "NudNote";
			this.NudNote.Size = new System.Drawing.Size(120, 20);
			this.NudNote.TabIndex = 5;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(16, 16);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(24, 24);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 7;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// FormCRUDNoter
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAnnuler;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.NudNote);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.CbxUsers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CbxJeux);
			this.Controls.Add(this.label1);
			this.Name = "FormCRUDNoter";
			this.Text = "FormCRUDNoter";
			((System.ComponentModel.ISupportInitialize)(this.NudNote)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox CbxJeux;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox CbxUsers;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.NumericUpDown NudNote;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAnnuler;
	}
}