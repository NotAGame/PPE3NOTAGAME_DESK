namespace PPE3_NotaGame
{
    partial class FormConsult
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
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupport = new System.Windows.Forms.ComboBox();
            this.btPDF = new System.Windows.Forms.Button();
            this.tbConsult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Aucun tri"});
            this.cbGenre.Location = new System.Drawing.Point(12, 25);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 0;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Support";
            // 
            // cbSupport
            // 
            this.cbSupport.FormattingEnabled = true;
            this.cbSupport.Items.AddRange(new object[] {
            "Aucun tri"});
            this.cbSupport.Location = new System.Drawing.Point(139, 25);
            this.cbSupport.Name = "cbSupport";
            this.cbSupport.Size = new System.Drawing.Size(121, 21);
            this.cbSupport.TabIndex = 2;
            this.cbSupport.SelectedIndexChanged += new System.EventHandler(this.cbSupport_SelectedIndexChanged);
            // 
            // btPDF
            // 
            this.btPDF.Location = new System.Drawing.Point(13, 326);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(247, 23);
            this.btPDF.TabIndex = 5;
            this.btPDF.Text = "Exporter en pdf";
            this.btPDF.UseVisualStyleBackColor = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // tbConsult
            // 
            this.tbConsult.Location = new System.Drawing.Point(12, 52);
            this.tbConsult.Multiline = true;
            this.tbConsult.Name = "tbConsult";
            this.tbConsult.Size = new System.Drawing.Size(248, 268);
            this.tbConsult.TabIndex = 6;
            // 
            // FormConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 361);
            this.Controls.Add(this.tbConsult);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSupport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGenre);
            this.Name = "FormConsult";
            this.Text = "FormConsult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupport;
        private System.Windows.Forms.Button btPDF;
        private System.Windows.Forms.TextBox tbConsult;
    }
}