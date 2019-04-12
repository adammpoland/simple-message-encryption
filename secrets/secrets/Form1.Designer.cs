namespace secrets
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
			this.input = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.encrypt = new System.Windows.Forms.Button();
			this.decrypt = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.TextBox();
			this.keyGen = new System.Windows.Forms.Button();
			this.loadKey = new System.Windows.Forms.Button();
			this.newKeyOutput = new System.Windows.Forms.TextBox();
			this.fileEncrypt = new System.Windows.Forms.Button();
			this.fileDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// input
			// 
			this.input.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.input.BackColor = System.Drawing.SystemColors.InfoText;
			this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.input.Location = new System.Drawing.Point(12, 47);
			this.input.Multiline = true;
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(123, 119);
			this.input.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox2.Location = new System.Drawing.Point(12, 289);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(123, 119);
			this.textBox2.TabIndex = 2;
			// 
			// encrypt
			// 
			this.encrypt.Location = new System.Drawing.Point(12, 172);
			this.encrypt.Name = "encrypt";
			this.encrypt.Size = new System.Drawing.Size(75, 23);
			this.encrypt.TabIndex = 4;
			this.encrypt.Text = "Encrypt";
			this.encrypt.UseVisualStyleBackColor = true;
			this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
			// 
			// decrypt
			// 
			this.decrypt.Location = new System.Drawing.Point(12, 415);
			this.decrypt.Name = "decrypt";
			this.decrypt.Size = new System.Drawing.Size(75, 23);
			this.decrypt.TabIndex = 5;
			this.decrypt.Text = "Decrypt";
			this.decrypt.UseVisualStyleBackColor = true;
			this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
			// 
			// output
			// 
			this.output.BackColor = System.Drawing.SystemColors.InfoText;
			this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.output.Location = new System.Drawing.Point(178, 47);
			this.output.Multiline = true;
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(133, 119);
			this.output.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InfoText;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(178, 289);
			this.label2.Multiline = true;
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 119);
			this.label2.TabIndex = 7;
			// 
			// keyGen
			// 
			this.keyGen.Location = new System.Drawing.Point(353, 47);
			this.keyGen.Name = "keyGen";
			this.keyGen.Size = new System.Drawing.Size(86, 30);
			this.keyGen.TabIndex = 9;
			this.keyGen.Text = "Generate Key";
			this.keyGen.UseVisualStyleBackColor = true;
			this.keyGen.Click += new System.EventHandler(this.keyGen_Click);
			// 
			// loadKey
			// 
			this.loadKey.Location = new System.Drawing.Point(432, 47);
			this.loadKey.Name = "loadKey";
			this.loadKey.Size = new System.Drawing.Size(86, 30);
			this.loadKey.TabIndex = 10;
			this.loadKey.Text = "Load Key";
			this.loadKey.UseVisualStyleBackColor = true;
			this.loadKey.Click += new System.EventHandler(this.loadKey_Click);
			// 
			// newKeyOutput
			// 
			this.newKeyOutput.BackColor = System.Drawing.SystemColors.InfoText;
			this.newKeyOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.newKeyOutput.Location = new System.Drawing.Point(353, 83);
			this.newKeyOutput.Multiline = true;
			this.newKeyOutput.Name = "newKeyOutput";
			this.newKeyOutput.Size = new System.Drawing.Size(165, 175);
			this.newKeyOutput.TabIndex = 11;
			// 
			// fileEncrypt
			// 
			this.fileEncrypt.Location = new System.Drawing.Point(366, 329);
			this.fileEncrypt.Name = "fileEncrypt";
			this.fileEncrypt.Size = new System.Drawing.Size(86, 30);
			this.fileEncrypt.TabIndex = 12;
			this.fileEncrypt.Text = "File Encrypt";
			this.fileEncrypt.UseVisualStyleBackColor = true;
			this.fileEncrypt.Click += new System.EventHandler(this.fileEncrypt_Click);
			// 
			// fileDecrypt
			// 
			this.fileDecrypt.Location = new System.Drawing.Point(366, 395);
			this.fileDecrypt.Name = "fileDecrypt";
			this.fileDecrypt.Size = new System.Drawing.Size(86, 30);
			this.fileDecrypt.TabIndex = 13;
			this.fileDecrypt.Text = "File DeEncrypt";
			this.fileDecrypt.UseVisualStyleBackColor = true;
			this.fileDecrypt.Click += new System.EventHandler(this.fileDecrypt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(554, 450);
			this.Controls.Add(this.fileDecrypt);
			this.Controls.Add(this.fileEncrypt);
			this.Controls.Add(this.newKeyOutput);
			this.Controls.Add(this.loadKey);
			this.Controls.Add(this.keyGen);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.output);
			this.Controls.Add(this.decrypt);
			this.Controls.Add(this.encrypt);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.input);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "SECRETS";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox input;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button encrypt;
		private System.Windows.Forms.Button decrypt;
		private System.Windows.Forms.TextBox output;
		private System.Windows.Forms.TextBox label2;
		private System.Windows.Forms.Button keyGen;
		private System.Windows.Forms.Button loadKey;
		private System.Windows.Forms.TextBox newKeyOutput;
		private System.Windows.Forms.Button fileEncrypt;
		private System.Windows.Forms.Button fileDecrypt;
	}
}

