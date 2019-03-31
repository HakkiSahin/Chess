namespace _03_SatrancOyunu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTasTipleri = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTaslariHareketEttir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbTasTipleri
            // 
            this.cmbTasTipleri.FormattingEnabled = true;
            this.cmbTasTipleri.Location = new System.Drawing.Point(580, 12);
            this.cmbTasTipleri.Name = "cmbTasTipleri";
            this.cmbTasTipleri.Size = new System.Drawing.Size(162, 24);
            this.cmbTasTipleri.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(758, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 39);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Taş Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTaslariHareketEttir
            // 
            this.btnTaslariHareketEttir.Location = new System.Drawing.Point(580, 68);
            this.btnTaslariHareketEttir.Name = "btnTaslariHareketEttir";
            this.btnTaslariHareketEttir.Size = new System.Drawing.Size(266, 56);
            this.btnTaslariHareketEttir.TabIndex = 3;
            this.btnTaslariHareketEttir.Text = "Taşları Hareket Ettir";
            this.btnTaslariHareketEttir.UseVisualStyleBackColor = true;
            this.btnTaslariHareketEttir.Click += new System.EventHandler(this.btnTaslariHareketEttir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 596);
            this.Controls.Add(this.btnTaslariHareketEttir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbTasTipleri);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTasTipleri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTaslariHareketEttir;
        private System.Windows.Forms.Timer timer1;
    }
}

