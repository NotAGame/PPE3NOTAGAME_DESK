namespace PPE3_NotaGame
{
	partial class FormCRUDCommunautes
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
			this.TbLibelle = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Libellé :";
			// 
			// TbLibelle
			// 
			this.TbLibelle.Location = new System.Drawing.Point(8, 8);
			this.TbLibelle.Name = "TbLibelle";
			this.TbLibelle.Size = new System.Drawing.Size(100, 20);
			this.TbLibelle.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new System.Drawing.Point(16, 16);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnAnnuler
			// 
			this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAnnuler.Location = new System.Drawing.Point(24, 24);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.btnAnnuler.TabIndex = 3;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			// 
			// FormCRUDCommutautes
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAnnuler;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.TbLibelle);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCRUDCommutautes";
			this.Text = "FormCRUDCommutautes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAnnuler;
		public System.Windows.Forms.TextBox TbLibelle;
	}
}