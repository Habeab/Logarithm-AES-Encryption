namespace Logarithm_AES_Encryption
{
    partial class FrmAES
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
            this.BtnDecryption = new System.Windows.Forms.Button();
            this.BtnEncryption = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxDecryptin = new System.Windows.Forms.TextBox();
            this.TbxEncryptin = new System.Windows.Forms.TextBox();
            this.TbxData = new System.Windows.Forms.TextBox();
            this.TbxKey = new System.Windows.Forms.TextBox();
            this.TbxIv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDecryption
            // 
            this.BtnDecryption.Location = new System.Drawing.Point(398, 301);
            this.BtnDecryption.Name = "BtnDecryption";
            this.BtnDecryption.Size = new System.Drawing.Size(169, 23);
            this.BtnDecryption.TabIndex = 11;
            this.BtnDecryption.Text = "Decryption";
            this.BtnDecryption.UseVisualStyleBackColor = true;
            this.BtnDecryption.Click += new System.EventHandler(this.BtnDecryption_Click);
            // 
            // BtnEncryption
            // 
            this.BtnEncryption.Location = new System.Drawing.Point(159, 301);
            this.BtnEncryption.Name = "BtnEncryption";
            this.BtnEncryption.Size = new System.Drawing.Size(169, 23);
            this.BtnEncryption.TabIndex = 12;
            this.BtnEncryption.Text = "Encryption";
            this.BtnEncryption.UseVisualStyleBackColor = true;
            this.BtnEncryption.Click += new System.EventHandler(this.BtnEncryption_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label4.Location = new System.Drawing.Point(152, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logarithm AES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(14, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decryption Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(14, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encryption Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data";
            // 
            // TbxDecryptin
            // 
            this.TbxDecryptin.Location = new System.Drawing.Point(148, 275);
            this.TbxDecryptin.Name = "TbxDecryptin";
            this.TbxDecryptin.Size = new System.Drawing.Size(438, 20);
            this.TbxDecryptin.TabIndex = 4;
            // 
            // TbxEncryptin
            // 
            this.TbxEncryptin.BackColor = System.Drawing.Color.White;
            this.TbxEncryptin.Location = new System.Drawing.Point(148, 194);
            this.TbxEncryptin.Multiline = true;
            this.TbxEncryptin.Name = "TbxEncryptin";
            this.TbxEncryptin.ReadOnly = true;
            this.TbxEncryptin.Size = new System.Drawing.Size(438, 72);
            this.TbxEncryptin.TabIndex = 5;
            // 
            // TbxData
            // 
            this.TbxData.Location = new System.Drawing.Point(148, 72);
            this.TbxData.Name = "TbxData";
            this.TbxData.Size = new System.Drawing.Size(438, 20);
            this.TbxData.TabIndex = 6;
            // 
            // TbxKey
            // 
            this.TbxKey.BackColor = System.Drawing.Color.AliceBlue;
            this.TbxKey.Location = new System.Drawing.Point(148, 124);
            this.TbxKey.Multiline = true;
            this.TbxKey.Name = "TbxKey";
            this.TbxKey.ReadOnly = true;
            this.TbxKey.Size = new System.Drawing.Size(211, 64);
            this.TbxKey.TabIndex = 5;
            // 
            // TbxIv
            // 
            this.TbxIv.BackColor = System.Drawing.Color.AliceBlue;
            this.TbxIv.Location = new System.Drawing.Point(375, 124);
            this.TbxIv.Multiline = true;
            this.TbxIv.Name = "TbxIv";
            this.TbxIv.ReadOnly = true;
            this.TbxIv.Size = new System.Drawing.Size(211, 64);
            this.TbxIv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(144, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(371, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "initialization Vector";
            // 
            // FrmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 334);
            this.Controls.Add(this.BtnDecryption);
            this.Controls.Add(this.BtnEncryption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxDecryptin);
            this.Controls.Add(this.TbxIv);
            this.Controls.Add(this.TbxKey);
            this.Controls.Add(this.TbxEncryptin);
            this.Controls.Add(this.TbxData);
            this.Name = "FrmAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDecryption;
        private System.Windows.Forms.Button BtnEncryption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxDecryptin;
        private System.Windows.Forms.TextBox TbxEncryptin;
        private System.Windows.Forms.TextBox TbxData;
        private System.Windows.Forms.TextBox TbxKey;
        private System.Windows.Forms.TextBox TbxIv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

