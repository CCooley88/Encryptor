namespace OOP_Midterm
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
            this.stdInput = new System.Windows.Forms.TextBox();
            this.encryptedOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.stdOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptedInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard Text";
            // 
            // stdInput
            // 
            this.stdInput.Location = new System.Drawing.Point(51, 58);
            this.stdInput.Name = "stdInput";
            this.stdInput.Size = new System.Drawing.Size(100, 20);
            this.stdInput.TabIndex = 1;
            // 
            // encryptedOutput
            // 
            this.encryptedOutput.Location = new System.Drawing.Point(51, 110);
            this.encryptedOutput.Name = "encryptedOutput";
            this.encryptedOutput.ReadOnly = true;
            this.encryptedOutput.Size = new System.Drawing.Size(100, 20);
            this.encryptedOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted Output";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(67, 148);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 4;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(230, 148);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 9;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // stdOutput
            // 
            this.stdOutput.Location = new System.Drawing.Point(216, 110);
            this.stdOutput.Name = "stdOutput";
            this.stdOutput.ReadOnly = true;
            this.stdOutput.Size = new System.Drawing.Size(100, 20);
            this.stdOutput.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted Output";
            // 
            // encryptedInput
            // 
            this.encryptedInput.Location = new System.Drawing.Point(216, 58);
            this.encryptedInput.Name = "encryptedInput";
            this.encryptedInput.Size = new System.Drawing.Size(100, 20);
            this.encryptedInput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Encrypted Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Insert four digits to encrypt or decrypt";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 230);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.stdOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptedInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.encryptedOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stdInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encryptor 5000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdInput;
        private System.Windows.Forms.TextBox encryptedOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox stdOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptedInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

