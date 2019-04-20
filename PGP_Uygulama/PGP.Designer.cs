namespace PGP_Uygulama
{
    partial class PGP
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
            System.Windows.Forms.Label lblCipheredText;
            System.Windows.Forms.Label lblUnencrypted;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PGP));
            this.btnEncyrpt = new System.Windows.Forms.Button();
            this.btnDecyrpt = new System.Windows.Forms.Button();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.RichTextBox();
            this.txtEncrypted = new System.Windows.Forms.RichTextBox();
            this.txtDecrypted = new System.Windows.Forms.RichTextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblSure_1 = new System.Windows.Forms.Label();
            this.lblSifrelemeSuresi = new System.Windows.Forms.Label();
            this.lblSure_2 = new System.Windows.Forms.Label();
            this.lblSifreCozmeSuresi = new System.Windows.Forms.Label();
            lblCipheredText = new System.Windows.Forms.Label();
            lblUnencrypted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCipheredText
            // 
            lblCipheredText.AutoSize = true;
            lblCipheredText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblCipheredText.Location = new System.Drawing.Point(622, 129);
            lblCipheredText.Name = "lblCipheredText";
            lblCipheredText.Size = new System.Drawing.Size(74, 17);
            lblCipheredText.TabIndex = 4;
            lblCipheredText.Text = "Şifreli Yazı";
            // 
            // lblUnencrypted
            // 
            lblUnencrypted.AutoSize = true;
            lblUnencrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblUnencrypted.Location = new System.Drawing.Point(9, 436);
            lblUnencrypted.Name = "lblUnencrypted";
            lblUnencrypted.Size = new System.Drawing.Size(161, 17);
            lblUnencrypted.TabIndex = 6;
            lblUnencrypted.Text = "Şifreli Yazının Çözülmesi";
            // 
            // btnEncyrpt
            // 
            this.btnEncyrpt.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncyrpt.Location = new System.Drawing.Point(505, 214);
            this.btnEncyrpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncyrpt.Name = "btnEncyrpt";
            this.btnEncyrpt.Size = new System.Drawing.Size(100, 32);
            this.btnEncyrpt.TabIndex = 3;
            this.btnEncyrpt.Text = "Şifrele";
            this.btnEncyrpt.UseVisualStyleBackColor = true;
            this.btnEncyrpt.Click += new System.EventHandler(this.btnEncyrpt_Click);
            // 
            // btnDecyrpt
            // 
            this.btnDecyrpt.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecyrpt.Location = new System.Drawing.Point(505, 401);
            this.btnDecyrpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecyrpt.Name = "btnDecyrpt";
            this.btnDecyrpt.Size = new System.Drawing.Size(100, 29);
            this.btnDecyrpt.TabIndex = 5;
            this.btnDecyrpt.Text = "Şifre Çöz";
            this.btnDecyrpt.UseVisualStyleBackColor = true;
            this.btnDecyrpt.Click += new System.EventHandler(this.btnDecyrpt_Click);
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlainText.Location = new System.Drawing.Point(9, 134);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(64, 17);
            this.lblPlainText.TabIndex = 2;
            this.lblPlainText.Text = "Düz Yazı";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(12, 153);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(481, 223);
            this.txtPlainText.TabIndex = 2;
            this.txtPlainText.Text = "";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(618, 153);
            this.txtEncrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(558, 223);
            this.txtEncrypted.TabIndex = 4;
            this.txtEncrypted.Text = "";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(12, 465);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(579, 250);
            this.txtDecrypted.TabIndex = 6;
            this.txtDecrypted.Text = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(88, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 15);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.ValidatingType = typeof(int);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(25, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Şifre : ";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.ForeColor = System.Drawing.Color.Red;
            this.lblUyari.Location = new System.Drawing.Point(245, 100);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(119, 17);
            this.lblUyari.TabIndex = 11;
            this.lblUyari.Text = "* Boş bırakılamaz!";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNot.Location = new System.Drawing.Point(28, 24);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(999, 28);
            this.lblNot.TabIndex = 12;
            this.lblNot.Text = "*NOT: Anahtarlarınızı \'keyPrivate.txt\' ve \'keyPublic.txt\' adıyla \'D:\' dizinine ka" +
    "ydediniz!";
            // 
            // lblSure_1
            // 
            this.lblSure_1.AutoSize = true;
            this.lblSure_1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure_1.Location = new System.Drawing.Point(620, 459);
            this.lblSure_1.Name = "lblSure_1";
            this.lblSure_1.Size = new System.Drawing.Size(205, 28);
            this.lblSure_1.TabIndex = 13;
            this.lblSure_1.Text = "Şifreleme Süresi :";            
            // 
            // lblSifrelemeSuresi
            // 
            this.lblSifrelemeSuresi.AutoSize = true;
            this.lblSifrelemeSuresi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifrelemeSuresi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifrelemeSuresi.Location = new System.Drawing.Point(858, 459);
            this.lblSifrelemeSuresi.Name = "lblSifrelemeSuresi";
            this.lblSifrelemeSuresi.Size = new System.Drawing.Size(25, 28);
            this.lblSifrelemeSuresi.TabIndex = 14;
            this.lblSifrelemeSuresi.Text = "0";
            // 
            // lblSure_2
            // 
            this.lblSure_2.AutoSize = true;
            this.lblSure_2.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSure_2.Location = new System.Drawing.Point(620, 513);
            this.lblSure_2.Name = "lblSure_2";
            this.lblSure_2.Size = new System.Drawing.Size(232, 28);
            this.lblSure_2.TabIndex = 15;
            this.lblSure_2.Text = "Şifre Çözme Süresi :";
            // 
            // lblSifreCozmeSuresi
            // 
            this.lblSifreCozmeSuresi.AutoSize = true;
            this.lblSifreCozmeSuresi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreCozmeSuresi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSifreCozmeSuresi.Location = new System.Drawing.Point(858, 513);
            this.lblSifreCozmeSuresi.Name = "lblSifreCozmeSuresi";
            this.lblSifreCozmeSuresi.Size = new System.Drawing.Size(25, 28);
            this.lblSifreCozmeSuresi.TabIndex = 16;
            this.lblSifreCozmeSuresi.Text = "0";
            // 
            // PGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 760);
            this.Controls.Add(this.lblSifreCozmeSuresi);
            this.Controls.Add(this.lblSure_2);
            this.Controls.Add(this.lblSifrelemeSuresi);
            this.Controls.Add(this.lblSure_1);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(lblUnencrypted);
            this.Controls.Add(lblCipheredText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.btnDecyrpt);
            this.Controls.Add(this.btnEncyrpt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PGP";
            this.Text = "PGP Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncyrpt;
        private System.Windows.Forms.Button btnDecyrpt;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.RichTextBox txtPlainText;
        private System.Windows.Forms.RichTextBox txtEncrypted;
        private System.Windows.Forms.RichTextBox txtDecrypted;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label lblSure_1;
        private System.Windows.Forms.Label lblSifrelemeSuresi;
        private System.Windows.Forms.Label lblSure_2;
        private System.Windows.Forms.Label lblSifreCozmeSuresi;
    }
}

