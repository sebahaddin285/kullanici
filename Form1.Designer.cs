namespace kullanici
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.hatirla = new System.Windows.Forms.CheckBox();
            this.sifree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "şifre:";
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(183, 93);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(100, 20);
            this.giris.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(183, 123);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 4;
            // 
            // hatirla
            // 
            this.hatirla.AutoSize = true;
            this.hatirla.Location = new System.Drawing.Point(116, 168);
            this.hatirla.Name = "hatirla";
            this.hatirla.Size = new System.Drawing.Size(85, 17);
            this.hatirla.TabIndex = 5;
            this.hatirla.Text = "Beni unutma";
            this.hatirla.UseVisualStyleBackColor = true;
            // 
            // sifree
            // 
            this.sifree.AutoSize = true;
            this.sifree.Location = new System.Drawing.Point(231, 168);
            this.sifree.Name = "sifree";
            this.sifree.Size = new System.Drawing.Size(77, 17);
            this.sifree.TabIndex = 5;
            this.sifree.Text = "şifre göster";
            this.sifree.UseVisualStyleBackColor = true;
            this.sifree.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 285);
            this.Controls.Add(this.sifree);
            this.Controls.Add(this.hatirla);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giris;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.CheckBox hatirla;
        private System.Windows.Forms.CheckBox sifree;
    }
}

