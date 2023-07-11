

namespace DieRoller
{
	/// <summary>
	/// Represents a single 6 sided die (d6 or 1 - 6)
	/// </summary>
	public class Die
	{
		/// <summary>
		/// Creates shared random object
		/// </summary>
		private static Random _random;

		/// <summary>
		/// attaches random to the die object
		/// </summary>
		static Die()
		{
			_random = new Random();
		}

		/// <summary>
		/// Creates the die and rolls it to start with a random number
		/// </summary>
        public Die()
        {
			Roll();
        }

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }
        
		/// <summary>
		/// True if the die is currently held
		/// </summary>
		public bool IsHeld { get; set; }


		/// <summary>
		/// Rolls the die and sets the <see cref="FaceValue"/> 
		/// to the new number if the die is not currently held.
		/// </summary>
		/// <returns>The <see cref="FaceValue"/></returns>
		public byte Roll()
		{
			if (!IsHeld)
			{
				// Generate random number
				byte newValue = (byte)_random.Next(1, 7);


				FaceValue = newValue;
			}
			return FaceValue;
		}
    }
}
