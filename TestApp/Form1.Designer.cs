
namespace TestApp
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
			this.displayPanel = new System.Windows.Forms.Panel();
			this.radiusArcAngle = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.radiusArcAngle)).BeginInit();
			this.SuspendLayout();
			// 
			// displayPanel
			// 
			this.displayPanel.BackColor = System.Drawing.Color.Black;
			this.displayPanel.Location = new System.Drawing.Point(12, 12);
			this.displayPanel.Name = "displayPanel";
			this.displayPanel.Size = new System.Drawing.Size(420, 220);
			this.displayPanel.TabIndex = 0;
			// 
			// radiusArcAngle
			// 
			this.radiusArcAngle.Location = new System.Drawing.Point(70, 238);
			this.radiusArcAngle.Maximum = new decimal(new int[] {
            220,
            0,
            0,
            0});
			this.radiusArcAngle.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.radiusArcAngle.Name = "radiusArcAngle";
			this.radiusArcAngle.Size = new System.Drawing.Size(362, 25);
			this.radiusArcAngle.TabIndex = 1;
			this.radiusArcAngle.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.radiusArcAngle.ValueChanged += new System.EventHandler(this.radiusArcAngle_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Radius:";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(444, 275);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radiusArcAngle);
			this.Controls.Add(this.displayPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			((System.ComponentModel.ISupportInitialize)(this.radiusArcAngle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel displayPanel;
		private System.Windows.Forms.NumericUpDown radiusArcAngle;
		private System.Windows.Forms.Label label1;
	}
}

