namespace milletvekili
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
            this.nufusTextBox = new System.Windows.Forms.TextBox();
            this.ilComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sayi = new System.Windows.Forms.GroupBox();
            this.cSayiTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bSayiTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.aSayiTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.partiBilgileleri = new System.Windows.Forms.GroupBox();
            this.sayiButton = new System.Windows.Forms.Button();
            this.vekilTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.istatistik = new System.Windows.Forms.GroupBox();
            this.cOranTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bOranTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aOranTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.oyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.sayi.SuspendLayout();
            this.partiBilgileleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.istatistik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nufusTextBox);
            this.groupBox1.Controls.Add(this.ilComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(206, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçim Bölgesi Bilgileri";
            // 
            // nufusTextBox
            // 
            this.nufusTextBox.Location = new System.Drawing.Point(176, 78);
            this.nufusTextBox.Name = "nufusTextBox";
            this.nufusTextBox.Size = new System.Drawing.Size(121, 22);
            this.nufusTextBox.TabIndex = 3;
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Items.AddRange(new object[] {
            "Kırklareli",
            "Edirne",
            "Kocaeli",
            "İstanbul",
            "Antalya"});
            this.ilComboBox.Location = new System.Drawing.Point(176, 44);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(121, 24);
            this.ilComboBox.TabIndex = 2;
            this.ilComboBox.SelectedIndexChanged += new System.EventHandler(this.ilComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İl seçmen nüfusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İl seçiniz:";
            // 
            // sayi
            // 
            this.sayi.Controls.Add(this.cSayiTextBox);
            this.sayi.Controls.Add(this.label10);
            this.sayi.Controls.Add(this.bSayiTextBox);
            this.sayi.Controls.Add(this.label11);
            this.sayi.Controls.Add(this.aSayiTextBox);
            this.sayi.Controls.Add(this.label12);
            this.sayi.Enabled = false;
            this.sayi.Location = new System.Drawing.Point(18, 391);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(706, 71);
            this.sayi.TabIndex = 1;
            this.sayi.TabStop = false;
            this.sayi.Text = "Milletvekili Sayısı";
            // 
            // cSayiTextBox
            // 
            this.cSayiTextBox.Location = new System.Drawing.Point(655, 30);
            this.cSayiTextBox.Name = "cSayiTextBox";
            this.cSayiTextBox.Size = new System.Drawing.Size(36, 22);
            this.cSayiTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "C partisi milletvekili sayısı:";
            // 
            // bSayiTextBox
            // 
            this.bSayiTextBox.Location = new System.Drawing.Point(414, 30);
            this.bSayiTextBox.Name = "bSayiTextBox";
            this.bSayiTextBox.Size = new System.Drawing.Size(36, 22);
            this.bSayiTextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "B partisi milletvekili sayısı:";
            // 
            // aSayiTextBox
            // 
            this.aSayiTextBox.Location = new System.Drawing.Point(181, 30);
            this.aSayiTextBox.Name = "aSayiTextBox";
            this.aSayiTextBox.Size = new System.Drawing.Size(36, 22);
            this.aSayiTextBox.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "A partisi milletvekili sayısı:";
            // 
            // partiBilgileleri
            // 
            this.partiBilgileleri.Controls.Add(this.sayiButton);
            this.partiBilgileleri.Controls.Add(this.vekilTextBox);
            this.partiBilgileleri.Controls.Add(this.label6);
            this.partiBilgileleri.Controls.Add(this.cTextBox);
            this.partiBilgileleri.Controls.Add(this.label5);
            this.partiBilgileleri.Controls.Add(this.bTextBox);
            this.partiBilgileleri.Controls.Add(this.label4);
            this.partiBilgileleri.Controls.Add(this.aTextBox);
            this.partiBilgileleri.Controls.Add(this.label3);
            this.partiBilgileleri.Enabled = false;
            this.partiBilgileleri.Location = new System.Drawing.Point(18, 156);
            this.partiBilgileleri.Name = "partiBilgileleri";
            this.partiBilgileleri.Size = new System.Drawing.Size(350, 229);
            this.partiBilgileleri.TabIndex = 2;
            this.partiBilgileleri.TabStop = false;
            this.partiBilgileleri.Text = "Parti Bilgileri";
            // 
            // sayiButton
            // 
            this.sayiButton.Location = new System.Drawing.Point(163, 181);
            this.sayiButton.Name = "sayiButton";
            this.sayiButton.Size = new System.Drawing.Size(181, 42);
            this.sayiButton.TabIndex = 10;
            this.sayiButton.Text = "Milletvekili Sayısı Hesapla";
            this.sayiButton.UseVisualStyleBackColor = true;
            this.sayiButton.Click += new System.EventHandler(this.sayiButton_Click);
            // 
            // vekilTextBox
            // 
            this.vekilTextBox.Location = new System.Drawing.Point(182, 140);
            this.vekilTextBox.Name = "vekilTextBox";
            this.vekilTextBox.Size = new System.Drawing.Size(121, 22);
            this.vekilTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "İl milletvekili sayısı:";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(182, 112);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(121, 22);
            this.cTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "C partisi oy sayısı";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(182, 84);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(121, 22);
            this.bTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "B partisi oy sayısı:";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(182, 56);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(121, 22);
            this.aTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "A partisi oy sayısı:";
            // 
            // istatistik
            // 
            this.istatistik.Controls.Add(this.cOranTextBox);
            this.istatistik.Controls.Add(this.label7);
            this.istatistik.Controls.Add(this.bOranTextBox);
            this.istatistik.Controls.Add(this.label8);
            this.istatistik.Controls.Add(this.aOranTextBox);
            this.istatistik.Controls.Add(this.label9);
            this.istatistik.Controls.Add(this.oyButton);
            this.istatistik.Enabled = false;
            this.istatistik.Location = new System.Drawing.Point(374, 156);
            this.istatistik.Name = "istatistik";
            this.istatistik.Size = new System.Drawing.Size(350, 229);
            this.istatistik.TabIndex = 3;
            this.istatistik.TabStop = false;
            this.istatistik.Text = "Seçim İstatistikleri";
            // 
            // cOranTextBox
            // 
            this.cOranTextBox.Location = new System.Drawing.Point(172, 110);
            this.cOranTextBox.Name = "cOranTextBox";
            this.cOranTextBox.Size = new System.Drawing.Size(121, 22);
            this.cOranTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "C partisi oy oranı";
            // 
            // bOranTextBox
            // 
            this.bOranTextBox.Location = new System.Drawing.Point(172, 82);
            this.bOranTextBox.Name = "bOranTextBox";
            this.bOranTextBox.Size = new System.Drawing.Size(121, 22);
            this.bOranTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "B partisi oy oranı:";
            // 
            // aOranTextBox
            // 
            this.aOranTextBox.Location = new System.Drawing.Point(172, 54);
            this.aOranTextBox.Name = "aOranTextBox";
            this.aOranTextBox.Size = new System.Drawing.Size(121, 22);
            this.aOranTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "A partisi oy oranı:";
            // 
            // oyButton
            // 
            this.oyButton.Location = new System.Drawing.Point(193, 181);
            this.oyButton.Name = "oyButton";
            this.oyButton.Size = new System.Drawing.Size(151, 42);
            this.oyButton.TabIndex = 11;
            this.oyButton.Text = "Oy Oranı Hesapla";
            this.oyButton.UseVisualStyleBackColor = true;
            this.oyButton.Click += new System.EventHandler(this.oyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 497);
            this.Controls.Add(this.istatistik);
            this.Controls.Add(this.partiBilgileleri);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Milletvekili Hesapla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sayi.ResumeLayout(false);
            this.sayi.PerformLayout();
            this.partiBilgileleri.ResumeLayout(false);
            this.partiBilgileleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.istatistik.ResumeLayout(false);
            this.istatistik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nufusTextBox;
        private System.Windows.Forms.ComboBox ilComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sayi;
        private System.Windows.Forms.GroupBox partiBilgileleri;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox vekilTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sayiButton;
        private System.Windows.Forms.TextBox cSayiTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bSayiTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aSayiTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox istatistik;
        private System.Windows.Forms.TextBox cOranTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bOranTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aOranTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button oyButton;
    }
}

