
namespace CookieChaos
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.CookieButton = new System.Windows.Forms.Button();
			this.ScoreLabel = new System.Windows.Forms.Label();
			this.HighScoreLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ResetButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CookieButton
			// 
			this.CookieButton.BackColor = System.Drawing.Color.Transparent;
			this.CookieButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CookieButton.BackgroundImage")));
			this.CookieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CookieButton.FlatAppearance.BorderSize = 0;
			this.CookieButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.CookieButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.CookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CookieButton.Location = new System.Drawing.Point(112, 67);
			this.CookieButton.Name = "CookieButton";
			this.CookieButton.Size = new System.Drawing.Size(301, 284);
			this.CookieButton.TabIndex = 0;
			this.CookieButton.UseVisualStyleBackColor = false;
			// 
			// ScoreLabel
			// 
			this.ScoreLabel.AutoSize = true;
			this.ScoreLabel.Location = new System.Drawing.Point(97, 9);
			this.ScoreLabel.Name = "ScoreLabel";
			this.ScoreLabel.Size = new System.Drawing.Size(16, 13);
			this.ScoreLabel.TabIndex = 1;
			this.ScoreLabel.Text = "-1";
			// 
			// HighScoreLabel
			// 
			this.HighScoreLabel.AutoSize = true;
			this.HighScoreLabel.Location = new System.Drawing.Point(97, 33);
			this.HighScoreLabel.Name = "HighScoreLabel";
			this.HighScoreLabel.Size = new System.Drawing.Size(16, 13);
			this.HighScoreLabel.TabIndex = 2;
			this.HighScoreLabel.Text = "-1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "SCORE:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "HIGH SCORE:";
			// 
			// ResetButton
			// 
			this.ResetButton.Location = new System.Drawing.Point(12, 376);
			this.ResetButton.Name = "ResetButton";
			this.ResetButton.Size = new System.Drawing.Size(75, 23);
			this.ResetButton.TabIndex = 5;
			this.ResetButton.Text = "Reset";
			this.ResetButton.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(559, 411);
			this.Controls.Add(this.ResetButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.HighScoreLabel);
			this.Controls.Add(this.ScoreLabel);
			this.Controls.Add(this.CookieButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(575, 450);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(575, 450);
			this.Name = "MainWindow";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Cookies!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CookieButton;
		private System.Windows.Forms.Label ScoreLabel;
		private System.Windows.Forms.Label HighScoreLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button ResetButton;
	}
}

