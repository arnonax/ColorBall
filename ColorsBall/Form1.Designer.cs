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
			this.pctBall = new System.Windows.Forms.PictureBox();
			this.pctPlayer = new System.Windows.Forms.PictureBox();
			this.tmrBall = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.pgbLives = new System.Windows.Forms.ProgressBar();
			this.lblLives = new System.Windows.Forms.Label();
			this.pgbBallLives = new System.Windows.Forms.ProgressBar();
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
			// tmrBall
			// 
			this.tmrBall.Enabled = true;
			this.tmrBall.Interval = 10;
			this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(500, 549);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lives";
			// 
			// pgbLives
			// 
			this.pgbLives.Location = new System.Drawing.Point(444, 585);
			this.pgbLives.Name = "pgbLives";
			this.pgbLives.Size = new System.Drawing.Size(193, 23);
			this.pgbLives.TabIndex = 2;
			this.pgbLives.Value = 100;
			// 
			// lblLives
			// 
			this.lblLives.AutoSize = true;
			this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLives.Location = new System.Drawing.Point(738, 575);
			this.lblLives.Name = "lblLives";
			this.lblLives.Size = new System.Drawing.Size(119, 33);
			this.lblLives.TabIndex = 3;
			this.lblLives.Text = "100/100";
			// 
			// pgbBallLives
			// 
			this.pgbBallLives.Location = new System.Drawing.Point(338, 31);
			this.pgbBallLives.Name = "pgbBallLives";
			this.pgbBallLives.Size = new System.Drawing.Size(363, 44);
			this.pgbBallLives.TabIndex = 4;
			this.pgbBallLives.Value = 100;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 641);
			this.Controls.Add(this.pgbBallLives);
			this.Controls.Add(this.lblLives);
			this.Controls.Add(this.pgbLives);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pnlArena);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "Form1";
			this.pnlArena.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctBall)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlArena;
		private System.Windows.Forms.PictureBox pctBall;
		private System.Windows.Forms.Timer tmrBall;
		private System.Windows.Forms.PictureBox pctPlayer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar pgbLives;
		private System.Windows.Forms.Label lblLives;
		private System.Windows.Forms.ProgressBar pgbBallLives;
	}
}

