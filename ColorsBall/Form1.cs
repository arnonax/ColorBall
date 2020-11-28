using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ColorsBall
{
	public partial class frmMain : Form
	{
		int dx=10, dy=10;
		bool stop = false;

		public frmMain()
		{
			InitializeComponent();
		}

		private void tmrBall_Tick(object sender, EventArgs e)
		{
			// Move ball
			pctBall.Left += dx;
			pctBall.Top += dy;
			if (pctBall.Bottom >= pnlArena.ClientSize.Height || pctBall.Top < 0)
				dy = -dy;
			if (pctBall.Right >= pnlArena.ClientSize.Width || pctBall.Left < 0)
				dx = -dx;

			// Move player
			if (!stop)
			{
				if (Keyboard.IsKeyDown(Key.Up))
					pctPlayer.Top -= 10;
				if (Keyboard.IsKeyDown(Key.Down))
					pctPlayer.Top += 10;
				if (Keyboard.IsKeyDown(Key.Left))
					pctPlayer.Left -= 10;
				if (Keyboard.IsKeyDown(Key.Right))
					pctPlayer.Left += 10;
				if (pctPlayer.Top <= 0)
					pctPlayer.Top = 0;
				if (pctPlayer.Left <= 0)
					pctPlayer.Left = 0;
				if (pctPlayer.Bottom >= pnlArena.ClientSize.Height)
					pctPlayer.Top = pnlArena.ClientSize.Height - pctPlayer.Height;
				if (pctPlayer.Right >= pnlArena.ClientSize.Width)
					pctPlayer.Left = pnlArena.ClientSize.Width - pctPlayer.Width;
			}
			// Check if ball hits the player
			if (pctPlayer.Bounds.IntersectsWith(pctBall.Bounds))
			{
				pctPlayer.Image = Properties.Resources.sans_hit;
				stop = true;
			}
		}
	}
}
