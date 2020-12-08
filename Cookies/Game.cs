using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CookieChaos
{
	public class Game : INotifyPropertyChanged
	{
		/// <summary>
		/// Simply a text file with the ".save" extension.
		/// </summary>
		private const string SaveFile = "Game.save";


		public virtual int Score
		{
			get { return _Score; }
			set
			{
				_Score = value;
				ChangedProperty(nameof(Score));
			}
		}
		int _Score;


		public virtual int HighScore
		{
			get { return _HighScore; }
			set
			{
				_HighScore = value;
				ChangedProperty(nameof(HighScore));
			}
		}
		int _HighScore;


		// Constructor
		// ---------------------------------------------

		public Game()
		{
			_Score = -1;
			_HighScore = -1;
			PropertyChanged += OnPropertyChanged;
		}


		// Events
		// ---------------------------------------------

		/// <summary>
		/// Handles a property change event.
		/// </summary>
		private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == nameof(Score))
			{
				if (Score > HighScore)
				{
					HighScore = Score;
				}
			}
		}


		// Methods
		// ---------------------------------------------

		/// <summary>
		/// Reset the current score.
		/// </summary>
		public void Reset()
		{
			Score = 0;
		}


		/// <summary>
		/// Save all game property values into a text file.
		/// </summary>
		public void Read()
		{
			HighScore = Read(nameof(HighScore));
		}


		/// <summary>
		/// Reads the value of a property stored in a text file.
		/// The text file is formated as property / value pairs.
		/// </summary>
		/// <returns>The value for the given property.</returns>
		public int Read(string property)
		{
			VerifyPropertyName(property);
			if (File.Exists(SaveFile))
			{
				var lines = File.ReadAllLines(SaveFile);
				string text = lines.Where(line => line.StartsWith(property)).FirstOrDefault();
				string value = text.Replace(property, string.Empty).Trim();
				return int.Parse(value);
			}
			else
			{
				return 0;
			}
		}


		/// <summary>
		/// Save all game property values into a text file.
		/// </summary>
		public void Save()
		{
			Save(nameof(HighScore), HighScore);
		}


		/// <summary>
		/// Saves the value of a property into a text file.
		/// </summary>
		/// <param name="property"></param>
		public void Save(string property, int value)
		{
			using (var writer = File.CreateText(SaveFile))
			{
				writer.Write(property + " " + value);
			}
		}


		// Interfaces
		// ---------------------------------------------

		#region INotifyPropertyChanged

		/// <summary>
		/// Raised when a property on this object has a new value.
		/// </summary>
		/// <remarks>
		/// Belongs to the <see cref="INotifyPropertyChanged"/> interface implementation.
		/// </remarks>
		public event PropertyChangedEventHandler PropertyChanged;


		/// <summary>
		/// Raises this object's PropertyChanged event.
		/// </summary>
		/// <remarks>
		/// Belongs to the <see cref="INotifyPropertyChanged"/> interface implementation.
		/// </remarks>
		/// <param name="property">The property that has a new value.</param>
		protected virtual void ChangedProperty(string property)
		{
			VerifyPropertyName(property);
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				var e = new PropertyChangedEventArgs(property);
				handler(this, e);
			}
		}


		/// <summary>
		/// Verifies if this object does has a public property with the specified name.
		/// </summary>
		/// <remarks>
		/// Belongs to the <see cref="INotifyPropertyChanged"/> interface implementation.
		/// This method only exists in 'Debug' builds.
		/// </remarks>
		[Conditional("DEBUG")]
		[DebuggerStepThrough]
		public void VerifyPropertyName(string property)
		{
			if (TypeDescriptor.GetProperties(this)[property] == null)
			{
				string message = "Invalid property name: " + property;
				if (ThrowOnInvalidPropertyName)
				{
					throw new InvalidOperationException(message);
				}
				else
				{
					Debug.Fail(message);
				}
			}
		}


		/// <summary>
		/// Returns whether an exception is thrown, or if a <see cref="Debug.Fail"/> is used when an invalid property name is passed to the <see cref="VerifyPropertyName"/> method.
		/// The default value is false, but subclasses used by unit tests might override this property's getter to return true.
		/// </summary>
		/// <remarks>
		/// Belongs to the <see cref="INotifyPropertyChanged"/> interface implementation.
		/// </remarks>
		protected virtual bool ThrowOnInvalidPropertyName { get; private set; }

		#endregion


	}
}
