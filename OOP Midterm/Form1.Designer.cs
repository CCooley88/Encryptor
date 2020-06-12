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
            this.StandardTextLabel = new System.Windows.Forms.Label();
            this.stdInput = new System.Windows.Forms.TextBox();
            this.encryptedOutput = new System.Windows.Forms.TextBox();
            this.EncryptedOutputLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.stdOutput = new System.Windows.Forms.TextBox();
            this.DecryptedOutputLabel = new System.Windows.Forms.Label();
            this.encryptedInput = new System.Windows.Forms.TextBox();
            this.EncryptedTextLabel = new System.Windows.Forms.Label();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StandardTextLabel
            // 
            this.StandardTextLabel.AutoSize = true;
            this.StandardTextLabel.Location = new System.Drawing.Point(48, 42);
            this.StandardTextLabel.Name = "StandardTextLabel";
            this.StandardTextLabel.Size = new System.Drawing.Size(74, 13);
            this.StandardTextLabel.TabIndex = 0;
            this.StandardTextLabel.Text = "Standard Text";
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
            // EncryptedOutputLabel
            // 
            this.EncryptedOutputLabel.AutoSize = true;
            this.EncryptedOutputLabel.Location = new System.Drawing.Point(49, 94);
            this.EncryptedOutputLabel.Name = "EncryptedOutputLabel";
            this.EncryptedOutputLabel.Size = new System.Drawing.Size(90, 13);
            this.EncryptedOutputLabel.TabIndex = 2;
            this.EncryptedOutputLabel.Text = "Encrypted Output";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(67, 148);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(230, 148);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 9;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // stdOutput
            // 
            this.stdOutput.Location = new System.Drawing.Point(216, 110);
            this.stdOutput.Name = "stdOutput";
            this.stdOutput.ReadOnly = true;
            this.stdOutput.Size = new System.Drawing.Size(100, 20);
            this.stdOutput.TabIndex = 8;
            // 
            // DecryptedOutputLabel
            // 
            this.DecryptedOutputLabel.AutoSize = true;
            this.DecryptedOutputLabel.Location = new System.Drawing.Point(214, 94);
            this.DecryptedOutputLabel.Name = "DecryptedOutputLabel";
            this.DecryptedOutputLabel.Size = new System.Drawing.Size(91, 13);
            this.DecryptedOutputLabel.TabIndex = 7;
            this.DecryptedOutputLabel.Text = "Decrypted Output";
            // 
            // encryptedInput
            // 
            this.encryptedInput.Location = new System.Drawing.Point(216, 58);
            this.encryptedInput.Name = "encryptedInput";
            this.encryptedInput.Size = new System.Drawing.Size(100, 20);
            this.encryptedInput.TabIndex = 6;
            // 
            // EncryptedTextLabel
            // 
            this.EncryptedTextLabel.AutoSize = true;
            this.EncryptedTextLabel.Location = new System.Drawing.Point(213, 42);
            this.EncryptedTextLabel.Name = "EncryptedTextLabel";
            this.EncryptedTextLabel.Size = new System.Drawing.Size(79, 13);
            this.EncryptedTextLabel.TabIndex = 5;
            this.EncryptedTextLabel.Text = "Encrypted Text";
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(49, 9);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(181, 13);
            this.InstructionLabel.TabIndex = 10;
            this.InstructionLabel.Text = "Insert four digits to encrypt or decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 230);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.stdOutput);
            this.Controls.Add(this.DecryptedOutputLabel);
            this.Controls.Add(this.encryptedInput);
            this.Controls.Add(this.EncryptedTextLabel);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.encryptedOutput);
            this.Controls.Add(this.EncryptedOutputLabel);
            this.Controls.Add(this.stdInput);
            this.Controls.Add(this.StandardTextLabel);
            this.Name = "Form1";
            this.Text = "Encryptor 5000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StandardTextLabel;
        private System.Windows.Forms.TextBox stdInput;
        private System.Windows.Forms.TextBox encryptedOutput;
        private System.Windows.Forms.Label EncryptedOutputLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox stdOutput;
        private System.Windows.Forms.Label DecryptedOutputLabel;
        private System.Windows.Forms.TextBox encryptedInput;
        private System.Windows.Forms.Label EncryptedTextLabel;
        private System.Windows.Forms.Label InstructionLabel;
    }
}

