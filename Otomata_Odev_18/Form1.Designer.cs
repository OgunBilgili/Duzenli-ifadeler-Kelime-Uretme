namespace Otomata_Odev_18
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Alfabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Duzenli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sayi = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.TextBox();
            this.Ara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Arama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TumKelimeler = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kelime Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alfabe";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Alfabe
            // 
            this.Alfabe.Location = new System.Drawing.Point(180, 57);
            this.Alfabe.Name = "Alfabe";
            this.Alfabe.Size = new System.Drawing.Size(239, 22);
            this.Alfabe.TabIndex = 2;
            this.Alfabe.Text = "a b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Düzenli İfade";
            // 
            // Duzenli
            // 
            this.Duzenli.Location = new System.Drawing.Point(180, 110);
            this.Duzenli.Multiline = true;
            this.Duzenli.Name = "Duzenli";
            this.Duzenli.Size = new System.Drawing.Size(239, 22);
            this.Duzenli.TabIndex = 4;
            this.Duzenli.Text = "(a+b)*(a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kelime Sayısı";
            // 
            // Sayi
            // 
            this.Sayi.Location = new System.Drawing.Point(180, 165);
            this.Sayi.Name = "Sayi";
            this.Sayi.Size = new System.Drawing.Size(239, 22);
            this.Sayi.TabIndex = 6;
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(512, 57);
            this.Liste.Multiline = true;
            this.Liste.Name = "Liste";
            this.Liste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Liste.Size = new System.Drawing.Size(335, 281);
            this.Liste.TabIndex = 7;
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(301, 315);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(118, 23);
            this.Ara.TabIndex = 8;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aranacak Kelime";
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(180, 219);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(239, 22);
            this.Arama.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kelime Listesi";
            // 
            // TumKelimeler
            // 
            this.TumKelimeler.AutoSize = true;
            this.TumKelimeler.Location = new System.Drawing.Point(512, 354);
            this.TumKelimeler.Name = "TumKelimeler";
            this.TumKelimeler.Size = new System.Drawing.Size(168, 21);
            this.TumKelimeler.TabIndex = 12;
            this.TumKelimeler.Text = "Tüm Kelimeleri Listele";
            this.TumKelimeler.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(780, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max Yıldız";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max Yıldız: Yıldızın Alabileceğin En Fazla Sayı Değeri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TumKelimeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Arama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.Sayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Duzenli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Alfabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Alfabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Duzenli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sayi;
        private System.Windows.Forms.TextBox Liste;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Arama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TumKelimeler;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

