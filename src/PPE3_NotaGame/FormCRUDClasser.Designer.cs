namespace PPE3_NotaGame
{
	partial class FormCRUDClasser
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
			this.CbxJeux = new System.Windows.Forms.ComboBox();
			this.CbxGenres = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Jeu :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(177, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Genre :";
			// 
			// CbxJeux
			// 
			this.CbxJeux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxJeux.FormattingEnabled = true;
			this.CbxJeux.Location = new System.Drawing.Point(27, 43);
			this.CbxJeux.Name = "CbxJeux";
			this.CbxJeux.Size = new System.Drawing.Size(121, 21);
			this.CbxJeux.TabIndex = 2;
			// 
			// CbxGenres
			// 
			this.CbxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbxGenres.FormattingEnabled = true;
			this.CbxGenres.Location = new System.Drawing.Point(180, 43);
			this.CbxGenres.Name = "CbxGenres";
			this.CbxGenres.Size = new System.Drawing.Size(121, 21);
			this.CbxGenres.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(73, 91);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 28);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(180, 91);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 28);
			this.btnAnnuler.TabIndex = 5;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// FormCRUDClasser
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAnnuler;
			this.ClientSize = new System.Drawing.Size(327, 165);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.CbxGenres);
			this.Controls.Add(this.CbxJeux);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCRUDClasser";
			this.Text = "FormCRUDClasser";
			this.Load += new System.EventHandler(this.FormCRUDClasser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAnnuler;
		public System.Windows.Forms.ComboBox CbxJeux;
		public System.Windows.Forms.ComboBox CbxGenres;
	}
}