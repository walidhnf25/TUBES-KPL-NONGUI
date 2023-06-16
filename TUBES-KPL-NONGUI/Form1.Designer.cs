namespace TUBES_KPL_NONGUI
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
            this.close = new System.Windows.Forms.Button();
            this.analisis = new System.Windows.Forms.Button();
            this.notifikasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(211, 248);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // analisis
            // 
            this.analisis.Location = new System.Drawing.Point(335, 248);
            this.analisis.Name = "analisis";
            this.analisis.Size = new System.Drawing.Size(75, 23);
            this.analisis.TabIndex = 1;
            this.analisis.Text = "Analisis";
            this.analisis.UseVisualStyleBackColor = true;
            this.analisis.Click += new System.EventHandler(this.analisis_Click);
            // 
            // notifikasi
            // 
            this.notifikasi.Location = new System.Drawing.Point(468, 248);
            this.notifikasi.Name = "notifikasi";
            this.notifikasi.Size = new System.Drawing.Size(75, 23);
            this.notifikasi.TabIndex = 2;
            this.notifikasi.Text = "Notifikasi";
            this.notifikasi.UseVisualStyleBackColor = true;
            this.notifikasi.Click += new System.EventHandler(this.notifikasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selamat Datang!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notifikasi);
            this.Controls.Add(this.analisis);
            this.Controls.Add(this.close);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button analisis;
        private System.Windows.Forms.Button notifikasi;
        private System.Windows.Forms.Label label1;
    }
}