using NAudio.Wave;
using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace ColorsBall
{
	public partial class frmMain : Form
	{
		const string backgroundMusicFile = "Toby Fox - Megalovania.mp3";

		int dx=10, dy=10;
		bool stopPlayer = false;
		bool stopBall = false;
		int timesUntilResurect = 0;
		int lives=100;
		int ticksUntilRed;
		int ticksUntilGreen;
		const int secondsUntilRed = 2;//7;
		const int secondsUntilGreen = secondsUntilRed + 3;//9;
		bool isGreenBall = true;
		WaveOutEvent backgroundMusic;

		public frmMain()
		{
			backgroundMusic = PlayMusic(backgroundMusicFile);
			backgroundMusic.PlaybackStopped += BackgroundMusic_PlaybackStopped;

			InitializeComponent();
			ticksUntilRed = SecondsToTicks(secondsUntilRed);
			ticksUntilGreen = SecondsToTicks(secondsUntilGreen);
		}

		private void BackgroundMusic_PlaybackStopped(object sender, StoppedEventArgs e)
		{
			backgroundMusic = PlayMusic(backgroundMusicFile);
			backgroundMusic.PlaybackStopped += BackgroundMusic_PlaybackStopped;
		}
		
		private void StopBackgroundMusic()
		{
			backgroundMusic.PlaybackStopped -= BackgroundMusic_PlaybackStopped;
			backgroundMusic.Stop();
		}

		private WaveOutEvent PlayMusic(string filename) 
		{
			var audioFileReader = new AudioFileReader(@"Resources\" +filename);
			var waveOutEvent = new WaveOutEvent();
			waveOutEvent.Init(audioFileReader);
			waveOutEvent.Play();
			return waveOutEvent;
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
			if (!stopBall)
			{
				pctBall.Left += dx;
				pctBall.Top += dy;
				if (pctBall.Bottom >= pnlArena.ClientSize.Height || pctBall.Top < 0)
					dy = -dy;
				if (pctBall.Right >= pnlArena.ClientSize.Width || pctBall.Left < 0)
					dx = -dx;
			}

			// Move player
			if (!stopPlayer)
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
					if (isGreenBall)
					{
						stopPlayer = true;
						pctPlayer.Image = Properties.Resources.sans_hit;
						lives -= 10;
						lblLives.Text = lives + "/100";
						pgbLives.Value = lives;
						PlayMusic("SansHit.mp3");
						if (lives <= 0)
						{
							StopBackgroundMusic();
							PlayMusic("Undertale Game Over Theme.mp3");
							tmrBall.Stop();
							MessageBox.Show("YOU LOSE!!!");
						}
					}
					else if (Keyboard.IsKeyDown(Key.Space))
					{
						pctPlayer.Image = Properties.Resources.sans_hits_ball;
						if (dx > 0)
							pctPlayer.Image.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);

						stopPlayer = true;
						stopBall = true;
						pgbBallLives.Value -= 10;
						PlayMusic("gaster_blaster_sound_effect_1.mp3");
						if (pgbBallLives.Value <= 0)
						{
							tmrBall.Stop();
							StopBackgroundMusic();
							PlayMusic("Undertale- Dogsong.mp3");
							MessageBox.Show("YOU WIN!!!");
						}
					}
				}
			}
			else // stopPlayer == true
			{
				timesUntilResurect++;
				if (timesUntilResurect == 30)
				{
					stopPlayer = false;
					stopBall = false;
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
