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

		public frmMain()
		{
			InitializeComponent();
		}

		private void tmrBall_Tick(object sender, EventArgs e)
		{
			// Move ball
			pctBall.Left+=dx;
			pctBall.Top+=dy;
			if (pctBall.Bottom >= pnlArena.ClientSize.Height || pctBall.Top < 0)
				dy = -dy;
			if (pctBall.Right >= pnlArena.ClientSize.Width || pctBall.Left < 0)
				dx = -dx;

			// Move player
			if (Keyboard.IsKeyDown(Key.Up))
				pctPlayer.Top-=10;
			if (Keyboard.IsKeyDown(Key.Down))
				pctPlayer.Top += 10;
			if (Keyboard.IsKeyDown(Key.Left))
				pctPlayer.Left -= 10;
			if (Keyboard.IsKeyDown(Key.Right))
				pctPlayer.Left += 10;
		}
	}
}
