using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class MainWindow : Form
	{
		int ClickCount = 0;
		int HighScore = 0;
		string HighScoreFile = "HighScore.txt";


		public MainWindow()
		{
			InitializeComponent();
			Load += OnLoad;
			CookieButton.Click += OnCookieClick;
			ResetButton.Click += OnResetClick;
			Application.ApplicationExit += OnApplicationExit;
		}


		private void OnLoad(object sender, EventArgs e)
		{
			ScoreLabel.Text = ClickCount.ToString();

			// Read the high score from file when the window loads.
			if (File.Exists(HighScoreFile))
			{
				string text = File.ReadAllText(HighScoreFile);
				HighScore = int.Parse(text);
				HighScoreLabel.Text = text;
			}
			else
			{
				HighScore = 0;
				HighScoreLabel.Text = HighScore.ToString();
			}
		}


		private void OnCookieClick(object sender, EventArgs e)
		{
			// Increase cookie score.
			ClickCount += 1;

			// Check for a high score.
			if (ClickCount > HighScore)
			{
				// Set and display high score.
				HighScore = ClickCount;
				HighScoreLabel.Text = HighScore.ToString();
			}

			// Display the high score.
			ScoreLabel.Text = ClickCount.ToString();
		}


		private void OnResetClick(object sender, EventArgs e)
		{
			ClickCount = 0;
			ScoreLabel.Text = ClickCount.ToString();

			HighScore = 0;
			HighScoreLabel.Text = HighScore.ToString();
		}


		private void OnApplicationExit(object sender, EventArgs e)
		{
			// Save the high score to file before exiting.
			using (var writer = File.CreateText(HighScoreFile))
			{
				writer.Write(HighScore);
			}
		}



	}
}
