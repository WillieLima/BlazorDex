using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDex.Util
{
	public static class PokeUtil
	{
		public const string Pokeball = "pokeball.png";
		public const string Greatball = "greatball.png";
		public const string Ultraball = "ultraball.png";
		public const string Masterball = "masterball.png";

		public static string GetRandomBall()
		{
			var pokeballArray = new string[] { Pokeball, Greatball, Ultraball, Masterball };

			var rand = new Random();
			string randomBall = pokeballArray[rand.Next(pokeballArray.Length)];

			return randomBall;
		}
		
		public static double GetPokemonHeightInMeters(int height) => Convert.ToDouble(height) / 10;
		
		
		public static double GetPokemonWeightInKilogramas(int weight) => Convert.ToDouble(weight) / 10;
		
	}
}