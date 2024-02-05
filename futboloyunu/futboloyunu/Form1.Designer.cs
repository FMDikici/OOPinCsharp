namespace futboloyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kaleci1 = new System.Windows.Forms.Button();
            this.Orta1 = new System.Windows.Forms.Button();
            this.Orta2 = new System.Windows.Forms.Button();
            this.Defans2 = new System.Windows.Forms.Button();
            this.Defans1 = new System.Windows.Forms.Button();
            this.Kaleci2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kaleci1
            // 
            this.Kaleci1.BackColor = System.Drawing.Color.Green;
            this.Kaleci1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kaleci1.BackgroundImage")));
            this.Kaleci1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kaleci1.Location = new System.Drawing.Point(84, 256);
            this.Kaleci1.Name = "Kaleci1";
            this.Kaleci1.Size = new System.Drawing.Size(56, 50);
            this.Kaleci1.TabIndex = 0;
            this.Kaleci1.Text = "9";
            this.Kaleci1.UseVisualStyleBackColor = false;
            this.Kaleci1.Click += new System.EventHandler(this.Kaleci1_Click);
            // 
            // Orta1
            // 
            this.Orta1.BackColor = System.Drawing.Color.Green;
            this.Orta1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Orta1.BackgroundImage")));
            this.Orta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Orta1.Location = new System.Drawing.Point(539, 219);
            this.Orta1.Name = "Orta1";
            this.Orta1.Size = new System.Drawing.Size(56, 50);
            this.Orta1.TabIndex = 1;
            this.Orta1.Text = "11";
            this.Orta1.UseVisualStyleBackColor = false;
            this.Orta1.Click += new System.EventHandler(this.Orta1_Click);
            // 
            // Orta2
            // 
            this.Orta2.BackColor = System.Drawing.Color.Green;
            this.Orta2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Orta2.BackgroundImage")));
            this.Orta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Orta2.Location = new System.Drawing.Point(369, 361);
            this.Orta2.Name = "Orta2";
            this.Orta2.Size = new System.Drawing.Size(56, 50);
            this.Orta2.TabIndex = 2;
            this.Orta2.Text = "8";
            this.Orta2.UseVisualStyleBackColor = false;
            this.Orta2.Click += new System.EventHandler(this.Orta2_Click);
            // 
            // Defans2
            // 
            this.Defans2.BackColor = System.Drawing.Color.Green;
            this.Defans2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Defans2.BackgroundImage")));
            this.Defans2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Defans2.Location = new System.Drawing.Point(255, 205);
            this.Defans2.Name = "Defans2";
            this.Defans2.Size = new System.Drawing.Size(56, 50);
            this.Defans2.TabIndex = 3;
            this.Defans2.Text = "5";
            this.Defans2.UseVisualStyleBackColor = false;
            this.Defans2.Click += new System.EventHandler(this.Defans2_Click);
            // 
            // Defans1
            // 
            this.Defans1.BackColor = System.Drawing.Color.Green;
            this.Defans1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Defans1.BackgroundImage")));
            this.Defans1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Defans1.Location = new System.Drawing.Point(680, 352);
            this.Defans1.Name = "Defans1";
            this.Defans1.Size = new System.Drawing.Size(56, 50);
            this.Defans1.TabIndex = 4;
            this.Defans1.Text = "3";
            this.Defans1.UseVisualStyleBackColor = false;
            this.Defans1.Click += new System.EventHandler(this.Defans1_Click);
            // 
            // Kaleci2
            // 
            this.Kaleci2.BackColor = System.Drawing.Color.Green;
            this.Kaleci2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kaleci2.BackgroundImage")));
            this.Kaleci2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Kaleci2.Location = new System.Drawing.Point(800, 256);
            this.Kaleci2.Name = "Kaleci2";
            this.Kaleci2.Size = new System.Drawing.Size(56, 50);
            this.Kaleci2.TabIndex = 5;
            this.Kaleci2.Text = "7";
            this.Kaleci2.UseVisualStyleBackColor = false;
            this.Kaleci2.Click += new System.EventHandler(this.Kaleci2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::futboloyunu.Properties.Resources.istockphoto_1183321688_170667a_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaleci2);
            this.Controls.Add(this.Defans1);
            this.Controls.Add(this.Defans2);
            this.Controls.Add(this.Orta2);
            this.Controls.Add(this.Orta1);
            this.Controls.Add(this.Kaleci1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaleci1;
        private System.Windows.Forms.Button Orta1;
        private System.Windows.Forms.Button Orta2;
        private System.Windows.Forms.Button Defans2;
        private System.Windows.Forms.Button Defans1;
        private System.Windows.Forms.Button Kaleci2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

