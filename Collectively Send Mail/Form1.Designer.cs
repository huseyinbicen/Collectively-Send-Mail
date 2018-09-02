namespace Collectively_Send_Mail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Excel = new System.Windows.Forms.Label();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Resim = new System.Windows.Forms.Button();
            this.lbl_Resim = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Message = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel Dosya Yolu: ";
            // 
            // lbl_Excel
            // 
            this.lbl_Excel.AutoSize = true;
            this.lbl_Excel.Location = new System.Drawing.Point(116, 20);
            this.lbl_Excel.Name = "lbl_Excel";
            this.lbl_Excel.Size = new System.Drawing.Size(64, 13);
            this.lbl_Excel.TabIndex = 1;
            this.lbl_Excel.Text = "...................";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(23, 70);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(94, 29);
            this.btn_Excel.TabIndex = 2;
            this.btn_Excel.Text = "Seç";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Resim
            // 
            this.btn_Resim.Location = new System.Drawing.Point(22, 74);
            this.btn_Resim.Name = "btn_Resim";
            this.btn_Resim.Size = new System.Drawing.Size(94, 29);
            this.btn_Resim.TabIndex = 5;
            this.btn_Resim.Text = "Seç";
            this.btn_Resim.UseVisualStyleBackColor = true;
            this.btn_Resim.Click += new System.EventHandler(this.btn_Resim_Click);
            // 
            // lbl_Resim
            // 
            this.lbl_Resim.AutoSize = true;
            this.lbl_Resim.Location = new System.Drawing.Point(116, 24);
            this.lbl_Resim.Name = "lbl_Resim";
            this.lbl_Resim.Size = new System.Drawing.Size(64, 13);
            this.lbl_Resim.TabIndex = 4;
            this.lbl_Resim.Text = "...................";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resim Dosya Yolu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Buradan Excel dosyasını seçiyoruz. (Excel dosyası isim-Soyisim / Mail Şeklindedir" +
    ")";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Buradan Mail içeriği olan Resim Dosyasını seçiyoruz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mail Konusu: ";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(88, 153);
            this.txt_Subject.Multiline = true;
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(168, 75);
            this.txt_Subject.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Excel);
            this.panel1.Controls.Add(this.lbl_Excel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 118);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_Message);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_Resim);
            this.panel2.Controls.Add(this.lbl_Resim);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 337);
            this.panel2.TabIndex = 11;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(22, 122);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(450, 196);
            this.txt_Message.TabIndex = 12;
            this.txt_Message.Text = "Sayın ..... ,\n\nBuraya mail text\'ini yapiştırınız !!\n...\n...\n...\n...\n...\n...\n...\n." +
    "..";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(49, 381);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(192, 55);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "GÖNDER";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mail Adresi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre: ";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(88, 292);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(168, 20);
            this.txt_Mail.TabIndex = 14;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(88, 328);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(168, 20);
            this.txt_Password.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_AdSoyad);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_Subject);
            this.panel3.Controls.Add(this.txt_Password);
            this.panel3.Controls.Add(this.btn_Send);
            this.panel3.Controls.Add(this.txt_Mail);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(523, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 460);
            this.panel3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(16, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(88, 257);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(168, 20);
            this.txt_AdSoyad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ad Soyad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Toplu Mail Gönderme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Excel;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Resim;
        private System.Windows.Forms.Label lbl_Resim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txt_Message;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

