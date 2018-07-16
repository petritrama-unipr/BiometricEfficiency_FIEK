namespace biometrics_efficiency
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRSA_card = new System.Windows.Forms.RadioButton();
            this.rbRSACSP_card = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRSACSP_pc = new System.Windows.Forms.RadioButton();
            this.rbECC_pc = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb5mb = new System.Windows.Forms.RadioButton();
            this.rb2mb = new System.Windows.Forms.RadioButton();
            this.rb1mb = new System.Windows.Forms.RadioButton();
            this.rb50kb = new System.Windows.Forms.RadioButton();
            this.rb10kb = new System.Windows.Forms.RadioButton();
            this.rb1kb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.rb10mb = new System.Windows.Forms.RadioButton();
            this.rb100kb = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.rbRSA_card);
            this.groupBox2.Controls.Add(this.rbRSACSP_card);
            this.groupBox2.Location = new System.Drawing.Point(176, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 75);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Card";
            // 
            // rbRSA_card
            // 
            this.rbRSA_card.AutoSize = true;
            this.rbRSA_card.Location = new System.Drawing.Point(15, 45);
            this.rbRSA_card.Name = "rbRSA_card";
            this.rbRSA_card.Size = new System.Drawing.Size(47, 17);
            this.rbRSA_card.TabIndex = 10;
            this.rbRSA_card.Text = "RSA";
            this.rbRSA_card.UseVisualStyleBackColor = true;
            this.rbRSA_card.CheckedChanged += new System.EventHandler(this.rbRSA_card_CheckedChanged);
            // 
            // rbRSACSP_card
            // 
            this.rbRSACSP_card.AutoSize = true;
            this.rbRSACSP_card.Location = new System.Drawing.Point(15, 22);
            this.rbRSACSP_card.Name = "rbRSACSP_card";
            this.rbRSACSP_card.Size = new System.Drawing.Size(71, 17);
            this.rbRSACSP_card.TabIndex = 12;
            this.rbRSACSP_card.Text = "RSA CSP";
            this.rbRSACSP_card.UseVisualStyleBackColor = true;
            this.rbRSACSP_card.CheckedChanged += new System.EventHandler(this.rbRSACSP_card_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRSACSP_pc);
            this.groupBox1.Controls.Add(this.rbECC_pc);
            this.groupBox1.Location = new System.Drawing.Point(15, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC";
            // 
            // rbRSACSP_pc
            // 
            this.rbRSACSP_pc.AutoSize = true;
            this.rbRSACSP_pc.Checked = true;
            this.rbRSACSP_pc.Location = new System.Drawing.Point(18, 22);
            this.rbRSACSP_pc.Name = "rbRSACSP_pc";
            this.rbRSACSP_pc.Size = new System.Drawing.Size(71, 17);
            this.rbRSACSP_pc.TabIndex = 13;
            this.rbRSACSP_pc.TabStop = true;
            this.rbRSACSP_pc.Text = "RSA CSP";
            this.rbRSACSP_pc.UseVisualStyleBackColor = true;
            this.rbRSACSP_pc.CheckedChanged += new System.EventHandler(this.rbRSACSP_pc_CheckedChanged);
            // 
            // rbECC_pc
            // 
            this.rbECC_pc.AutoSize = true;
            this.rbECC_pc.Location = new System.Drawing.Point(18, 45);
            this.rbECC_pc.Name = "rbECC_pc";
            this.rbECC_pc.Size = new System.Drawing.Size(46, 17);
            this.rbECC_pc.TabIndex = 11;
            this.rbECC_pc.Text = "ECC";
            this.rbECC_pc.UseVisualStyleBackColor = true;
            this.rbECC_pc.CheckedChanged += new System.EventHandler(this.rbECC_pc_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb10mb);
            this.groupBox5.Controls.Add(this.rb100kb);
            this.groupBox5.Controls.Add(this.rb5mb);
            this.groupBox5.Controls.Add(this.rb2mb);
            this.groupBox5.Controls.Add(this.rb1mb);
            this.groupBox5.Controls.Add(this.rb50kb);
            this.groupBox5.Controls.Add(this.rb10kb);
            this.groupBox5.Controls.Add(this.rb1kb);
            this.groupBox5.Location = new System.Drawing.Point(44, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 175);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Test Vector";
            // 
            // rb5mb
            // 
            this.rb5mb.AutoSize = true;
            this.rb5mb.Location = new System.Drawing.Point(147, 104);
            this.rb5mb.Name = "rb5mb";
            this.rb5mb.Size = new System.Drawing.Size(50, 17);
            this.rb5mb.TabIndex = 5;
            this.rb5mb.Text = "5 MB";
            this.rb5mb.UseVisualStyleBackColor = true;
            // 
            // rb2mb
            // 
            this.rb2mb.AutoSize = true;
            this.rb2mb.Location = new System.Drawing.Point(147, 68);
            this.rb2mb.Name = "rb2mb";
            this.rb2mb.Size = new System.Drawing.Size(50, 17);
            this.rb2mb.TabIndex = 4;
            this.rb2mb.Text = "2 MB";
            this.rb2mb.UseVisualStyleBackColor = true;
            // 
            // rb1mb
            // 
            this.rb1mb.AutoSize = true;
            this.rb1mb.Location = new System.Drawing.Point(147, 32);
            this.rb1mb.Name = "rb1mb";
            this.rb1mb.Size = new System.Drawing.Size(50, 17);
            this.rb1mb.TabIndex = 3;
            this.rb1mb.Text = "1 MB";
            this.rb1mb.UseVisualStyleBackColor = true;
            // 
            // rb50kb
            // 
            this.rb50kb.AutoSize = true;
            this.rb50kb.Location = new System.Drawing.Point(41, 104);
            this.rb50kb.Name = "rb50kb";
            this.rb50kb.Size = new System.Drawing.Size(54, 17);
            this.rb50kb.TabIndex = 2;
            this.rb50kb.Text = "50 KB";
            this.rb50kb.UseVisualStyleBackColor = true;
            // 
            // rb10kb
            // 
            this.rb10kb.AutoSize = true;
            this.rb10kb.Location = new System.Drawing.Point(41, 68);
            this.rb10kb.Name = "rb10kb";
            this.rb10kb.Size = new System.Drawing.Size(54, 17);
            this.rb10kb.TabIndex = 1;
            this.rb10kb.Text = "10 KB";
            this.rb10kb.UseVisualStyleBackColor = true;
            // 
            // rb1kb
            // 
            this.rb1kb.AutoSize = true;
            this.rb1kb.Checked = true;
            this.rb1kb.Location = new System.Drawing.Point(41, 32);
            this.rb1kb.Name = "rb1kb";
            this.rb1kb.Size = new System.Drawing.Size(48, 17);
            this.rb1kb.TabIndex = 0;
            this.rb1kb.TabStop = true;
            this.rb1kb.Text = "1 KB";
            this.rb1kb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Biometrics Efficiency";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Image = global::biometrics_efficiency.Properties.Resources.encrypted1;
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(15, 397);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(135, 34);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "    Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Image = ((System.Drawing.Image)(resources.GetObject("btnSign.Image")));
            this.btnSign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSign.Location = new System.Drawing.Point(176, 397);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(135, 34);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "    Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // rb10mb
            // 
            this.rb10mb.AutoSize = true;
            this.rb10mb.Location = new System.Drawing.Point(147, 140);
            this.rb10mb.Name = "rb10mb";
            this.rb10mb.Size = new System.Drawing.Size(56, 17);
            this.rb10mb.TabIndex = 7;
            this.rb10mb.Text = "10 MB";
            this.rb10mb.UseVisualStyleBackColor = true;
            // 
            // rb100kb
            // 
            this.rb100kb.AutoSize = true;
            this.rb100kb.Location = new System.Drawing.Point(41, 140);
            this.rb100kb.Name = "rb100kb";
            this.rb100kb.Size = new System.Drawing.Size(60, 17);
            this.rb100kb.TabIndex = 6;
            this.rb100kb.Text = "100 KB";
            this.rb100kb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Biometrics Efficiency - FIEK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.RadioButton rbRSACSP_pc;
        private System.Windows.Forms.RadioButton rbRSACSP_card;
        private System.Windows.Forms.RadioButton rbECC_pc;
        private System.Windows.Forms.RadioButton rbRSA_card;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb5mb;
        private System.Windows.Forms.RadioButton rb2mb;
        private System.Windows.Forms.RadioButton rb1mb;
        private System.Windows.Forms.RadioButton rb50kb;
        private System.Windows.Forms.RadioButton rb10kb;
        private System.Windows.Forms.RadioButton rb1kb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb10mb;
        private System.Windows.Forms.RadioButton rb100kb;
    }
}

