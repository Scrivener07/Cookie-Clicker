using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CookieChaos
{
	public partial class MainWindow : Form
	{
		/// <summary>
		/// The data context for the game.
		/// </summary>
		public Game Context { get; private set; }


		public MainWindow()
		{
			InitializeComponent();
			Load += OnLoad;
			FormClosing += OnClosing;

			CookieButton.Click += OnCookieClick;
			ResetButton.Click += OnResetClick;

			Context = new Game();
			Context.PropertyChanged += OnGame_PropertyChanged;
		}


		private void OnLoad(object sender, EventArgs e)
		{
			Context.Reset();
			Context.Read();
		}


		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			Context.Save();
		}


		private void OnGame_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof(Context.Score))
			{
				ScoreLabel.Text = Context.Score.ToString();
			}
			else if (e.PropertyName == nameof(Context.HighScore))
			{
				HighScoreLabel.Text = Context.HighScore.ToString();
			}
		}


		private void OnCookieClick(object sender, EventArgs e)
		{
			Context.Score += 1;
		}


		private void OnResetClick(object sender, EventArgs e)
		{
			Context.Reset();
		}


	}
}
