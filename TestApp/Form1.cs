using SharpRegion;
using System;
using System.Windows.Forms;

namespace TestApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			regionGen = RegionGen.Create(0, 0, displayPanel.Width + 1, displayPanel.Height + 1, (int)radiusArcAngle.Value);
			displayPanel.Region = regionGen.CreateRgn();
		}

		private RegionGen regionGen;

		private void radiusArcAngle_ValueChanged(object sender, EventArgs e)
		{
			regionGen = RegionGen.Create(0, 0, displayPanel.Width + 1, displayPanel.Height + 1, (int)radiusArcAngle.Value);
			displayPanel.Region = regionGen.CreateRgn();
		}
	}
}
