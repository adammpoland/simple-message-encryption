namespace secrets
{
	partial class KeyLoader
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
			this.lvDirs = new System.Windows.Forms.ListView();
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.open = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvDirs
			// 
			this.lvDirs.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lvDirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.size,
            this.lastModified});
			this.lvDirs.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.lvDirs.Location = new System.Drawing.Point(12, 12);
			this.lvDirs.Name = "lvDirs";
			this.lvDirs.Size = new System.Drawing.Size(250, 156);
			this.lvDirs.TabIndex = 1;
			this.lvDirs.UseCompatibleStateImageBehavior = false;
			this.lvDirs.View = System.Windows.Forms.View.Details;
			// 
			// name
			// 
			this.name.Text = "Name";
			this.name.Width = 90;
			// 
			// size
			// 
			this.size.Text = "Size";
			// 
			// lastModified
			// 
			this.lastModified.Text = "Last Modified";
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(12, 174);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(75, 44);
			this.open.TabIndex = 5;
			this.open.Text = "Open";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_Click);
			// 
			// KeyLoader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 223);
			this.Controls.Add(this.open);
			this.Controls.Add(this.lvDirs);
			this.Name = "KeyLoader";
			this.Text = "KeyLoader";
			this.Load += new System.EventHandler(this.KeyLoader_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvDirs;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader size;
		private System.Windows.Forms.ColumnHeader lastModified;
		private System.Windows.Forms.Button open;
	}
}