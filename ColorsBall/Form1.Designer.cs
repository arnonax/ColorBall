namespace ColorsBall
{
	partial class frmMain
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
			this.tmrBall = new System.Windows.Forms.Timer(this.components);
			this.pctBall = new System.Windows.Forms.PictureBox();
			this.pctPlayer = new System.Windows.Forms.PictureBox();
			this.pnlArena.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctBall)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlArena
			// 
			this.pnlArena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlArena.Controls.Add(this.pctBall);
			this.pnlArena.Controls.Add(this.pctPlayer);
			this.pnlArena.Location = new System.Drawing.Point(74, 81);
			this.pnlArena.Name = "pnlArena";
			this.pnlArena.Size = new System.Drawing.Size(932, 465);
			this.pnlArena.TabIndex = 0;
			// 
			// tmrBall
			// 
			this.tmrBall.Enabled = true;
			this.tmrBall.Interval = 20;
			this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
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
			// pctPlayer
			// 
			this.pctPlayer.Image = global::ColorsBall.Properties.Resources.Sans;
			this.pctPlayer.Location = new System.Drawing.Point(94, 258);
			this.pctPlayer.Name = "pctPlayer";
			this.pctPlayer.Size = new System.Drawing.Size(103, 142);
			this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctPlayer.TabIndex = 2;
			this.pctPlayer.TabStop = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 641);
			this.Controls.Add(this.pnlArena);
			this.DoubleBuffered = true;
			this.Name = "frmMain";
			this.Text = "Form1";
			this.pnlArena.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctBall)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlArena;
		private System.Windows.Forms.PictureBox pctBall;
		private System.Windows.Forms.Timer tmrBall;
		private System.Windows.Forms.PictureBox pctPlayer;
	}
}

