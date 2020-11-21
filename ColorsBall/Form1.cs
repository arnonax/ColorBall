using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsBall
{
	public partial class Form1 : Form
	{
		int dx=10, dy=10;

		public Form1()
		{
			InitializeComponent();
		}

		private void tmrBall_Tick(object sender, EventArgs e)
		{
			pctBall.Left+=dx;
			pctBall.Top+=dy;
			if (pctBall.Bottom >= pnlArena.ClientSize.Height || pctBall.Top < 0)
				dy = -dy;
			if (pctBall.Right >= pnlArena.ClientSize.Width || pctBall.Left < 0)
				dx = -dx;
		}
	}
}
