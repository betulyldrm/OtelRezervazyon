namespace OtelRezervazyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textMusteri = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboOda = new System.Windows.Forms.ComboBox();
            this.nudGeceSayisi = new System.Windows.Forms.NumericUpDown();
            this.textGeceFiyat = new System.Windows.Forms.TextBox();
            this.checkKahvalti = new System.Windows.Forms.CheckBox();
            this.buttonRezervasyon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGeceSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // textMusteri
            // 
            this.textMusteri.Location = new System.Drawing.Point(148, 45);
            this.textMusteri.Name = "textMusteri";
            this.textMusteri.Size = new System.Drawing.Size(208, 23);
            this.textMusteri.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboOda
            // 
            this.comboOda.FormattingEnabled = true;
            this.comboOda.Location = new System.Drawing.Point(148, 120);
            this.comboOda.Name = "comboOda";
            this.comboOda.Size = new System.Drawing.Size(208, 24);
            this.comboOda.TabIndex = 2;
            // 
            // nudGeceSayisi
            // 
            this.nudGeceSayisi.Location = new System.Drawing.Point(148, 189);
            this.nudGeceSayisi.Name = "nudGeceSayisi";
            this.nudGeceSayisi.Size = new System.Drawing.Size(208, 23);
            this.nudGeceSayisi.TabIndex = 3;
            // 
            // textGeceFiyat
            // 
            this.textGeceFiyat.Location = new System.Drawing.Point(148, 260);
            this.textGeceFiyat.Name = "textGeceFiyat";
            this.textGeceFiyat.Size = new System.Drawing.Size(208, 23);
            this.textGeceFiyat.TabIndex = 4;
            // 
            // checkKahvalti
            // 
            this.checkKahvalti.AutoSize = true;
            this.checkKahvalti.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkKahvalti.Location = new System.Drawing.Point(197, 315);
            this.checkKahvalti.Name = "checkKahvalti";
            this.checkKahvalti.Size = new System.Drawing.Size(159, 23);
            this.checkKahvalti.TabIndex = 5;
            this.checkKahvalti.Text = "Evet ,Kahvaltı Dahil";
            this.checkKahvalti.UseVisualStyleBackColor = true;
            this.checkKahvalti.CheckedChanged += new System.EventHandler(this.checkKahvalti_CheckedChanged);
            // 
            // buttonRezervasyon
            // 
            this.buttonRezervasyon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonRezervasyon.FlatAppearance.BorderSize = 5;
            this.buttonRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRezervasyon.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRezervasyon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRezervasyon.Location = new System.Drawing.Point(16, 365);
            this.buttonRezervasyon.Name = "buttonRezervasyon";
            this.buttonRezervasyon.Size = new System.Drawing.Size(340, 43);
            this.buttonRezervasyon.TabIndex = 6;
            this.buttonRezervasyon.Text = "REZERVASYON YAP";
            this.buttonRezervasyon.UseVisualStyleBackColor = false;
            this.buttonRezervasyon.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kahvaltı Dahil Mi?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gece Sayısı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gecelik Fiyat:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Navy;
            this.lblSonuc.Location = new System.Drawing.Point(12, 429);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(63, 23);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "Sonuç:";
            this.lblSonuc.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(411, 574);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRezervasyon);
            this.Controls.Add(this.checkKahvalti);
            this.Controls.Add(this.textGeceFiyat);
            this.Controls.Add(this.nudGeceSayisi);
            this.Controls.Add(this.comboOda);
            this.Controls.Add(this.textMusteri);
            this.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Rezervasyon Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGeceSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textMusteri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboOda;
        private System.Windows.Forms.NumericUpDown nudGeceSayisi;
        private System.Windows.Forms.TextBox textGeceFiyat;
        private System.Windows.Forms.CheckBox checkKahvalti;
        private System.Windows.Forms.Button buttonRezervasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSonuc;
    }
}

