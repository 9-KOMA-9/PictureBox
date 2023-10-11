namespace PictureBoxKontrola
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
            this.RazredSlika = new System.Windows.Forms.PictureBox();
            this.Prikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RazredSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // RazredSlika
            // 
            this.RazredSlika.Image = global::PictureBoxKontrola.Properties.Resources.IMG_2333;
            this.RazredSlika.Location = new System.Drawing.Point(188, 30);
            this.RazredSlika.Name = "RazredSlika";
            this.RazredSlika.Size = new System.Drawing.Size(389, 228);
            this.RazredSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RazredSlika.TabIndex = 0;
            this.RazredSlika.TabStop = false;
            this.RazredSlika.Visible = false;
            this.RazredSlika.Click += new System.EventHandler(this.RazredSlika_Click);
            // 
            // Prikazi
            // 
            this.Prikazi.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Prikazi.Location = new System.Drawing.Point(227, 308);
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.Size = new System.Drawing.Size(310, 83);
            this.Prikazi.TabIndex = 1;
            this.Prikazi.Text = "prikaži sliku";
            this.Prikazi.UseVisualStyleBackColor = true;
            this.Prikazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prikazi);
            this.Controls.Add(this.RazredSlika);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RazredSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RazredSlika;
        private System.Windows.Forms.Button Prikazi;
    }
}

