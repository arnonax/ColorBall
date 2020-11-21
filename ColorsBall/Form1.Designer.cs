namespace ColorsBall
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
			this.components = new System.ComponentModel.Container();
			this.pnlArena = new System.Windows.Forms.Panel();
			this.pctBall = new System.Windows.Forms.PictureBox();
			this.tmrBall = new System.Windows.Forms.Timer(this.components);
			this.pnlArena.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctBall)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlArena
			// 
			this.pnlArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlArena.Controls.Add(this.pctBall);
			this.pnlArena.Location = new System.Drawing.Point(74, 81);
			this.pnlArena.Name = "pnlArena";
			this.pnlArena.Size = new System.Drawing.Size(932, 465);
			this.pnlArena.TabIndex = 0;
			// 
			// pctBall
			// 
			this.pctBall.Image = global::ColorsBall.Properties.Resources.GreenBall;
			this.pctBall.Location = new System.Drawing.Point(131, 42);
			this.pctBall.Name = "pctBall";
			this.pctBall.Size = new System.Drawing.Size(66, 67);
			this.pctBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctBall.TabIndex = 0;
			this.pctBall.TabStop = false;
			// 
			// tmrBall
			// 
			this.tmrBall.Enabled = true;
			this.tmrBall.Interval = 20;
			this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 641);
			this.Controls.Add(this.pnlArena);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pnlArena.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctBall)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlArena;
		private System.Windows.Forms.PictureBox pctBall;
		private System.Windows.Forms.Timer tmrBall;
	}
}

