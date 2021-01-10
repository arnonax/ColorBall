using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace ColorsBall
{
	public partial class frmMain : Form
	{
		int dx=10, dy=10;
		bool stop = false;
		int timesUntilResurect = 0;
		int lives=100;
		int ticksUntilRed;
		int ticksUntilGreen;
		const int secondsUntilRed = 2;//7;
		const int secondsUntilGreen = secondsUntilRed + 3;//9;
		bool isGreenBall = true;

		public frmMain()
		{
			InitializeComponent();
			ticksUntilRed = SecondsToTicks(secondsUntilRed);
			ticksUntilGreen = SecondsToTicks(secondsUntilGreen);
		}

		private int SecondsToTicks(int seconds)
		{
			int ticksInSecond = 1000 / tmrBall.Interval;
			int ticks = seconds * ticksInSecond;
			return ticks;
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
				
				// Check if ball hits the player
				if (pctPlayer.Bounds.IntersectsWith(pctBall.Bounds))
				{
					stop = true;
					if (isGreenBall)
					{
						pctPlayer.Image = Properties.Resources.sans_hit;
						lives -= 10;
						lblLives.Text = lives + "/100";
						pgbLives.Value = lives;
						if (lives <= 0)
						{
							tmrBall.Stop();
							MessageBox.Show("GAME OVER!!!");
						}
					}
					else
					{
						pctPlayer.Image = Properties.Resources.sans_hits_ball;
					}
				}
			}
			else
			{
				timesUntilResurect++;
				if (timesUntilResurect == 30)
				{
					stop = false;
					timesUntilResurect = 0;
					pctPlayer.Image = Properties.Resources.Sans;
				}
			}
			ticksUntilRed--;
			ticksUntilGreen--;
			if (ticksUntilRed == 0)
			{
				pctBall.Image = Properties.Resources.RedBall;
				isGreenBall = false;
			}
			if (ticksUntilGreen == 0)
			{
				pctBall.Image = Properties.Resources.GreenBall;
				isGreenBall = true;
				ticksUntilRed = SecondsToTicks(secondsUntilRed);
				ticksUntilGreen = SecondsToTicks(secondsUntilGreen);
			}
		}
	}
}
