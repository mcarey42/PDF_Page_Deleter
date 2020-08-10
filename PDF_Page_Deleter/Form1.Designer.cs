namespace PDF_Page_Deleter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butSelectPDFs = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbStartPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEndPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSelectPDFs
            // 
            this.butSelectPDFs.Location = new System.Drawing.Point(31, 29);
            this.butSelectPDFs.Name = "butSelectPDFs";
            this.butSelectPDFs.Size = new System.Drawing.Size(202, 63);
            this.butSelectPDFs.TabIndex = 0;
            this.butSelectPDFs.Text = "Select PDFs...";
            this.butSelectPDFs.UseVisualStyleBackColor = true;
            this.butSelectPDFs.Click += new System.EventHandler(this.butSelectPDFs_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbStartPage
            // 
            this.tbStartPage.Location = new System.Drawing.Point(410, 26);
            this.tbStartPage.Name = "tbStartPage";
            this.tbStartPage.Size = new System.Drawing.Size(62, 20);
            this.tbStartPage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Page to Remove:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEndPage
            // 
            this.tbEndPage.Location = new System.Drawing.Point(632, 26);
            this.tbEndPage.Name = "tbEndPage";
            this.tbEndPage.Size = new System.Drawing.Size(62, 20);
            this.tbEndPage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ending Page to Remove:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 116);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(463, 159);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEndPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStartPage);
            this.Controls.Add(this.butSelectPDFs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSelectPDFs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbStartPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEndPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

