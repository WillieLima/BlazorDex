using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDex.Util
{
	public class PokeColor
	{
		public static string GetTypeColor(string type)
		{
			string color = type switch
			{
				"bug" => "#a8b720",
				"dragon" => "#6f38f6",
				"electric" => "#f7cf2e",
				"fairy" => "#f9aec7",
				"fighting" => "#bf3029",
				"fire" => "#ee7f30",
				"flying" => "#a98ff0",
				"grass" => "#77c850",
				"ground" => "#dfbf69",
				"ghost" => "#6e5896",
				"ice" => "#98d5d7",
				"normal" => "#a6a877",
				"poison" => "#a040a0",
				"psychic" => "#f65687",
				"rock" => "#b8a137",
				"water" => "#678fee",
				"dark" => "#725847",
				"steel" => "#b9b7cf",
				_ => "#fff"
				
				
			};

			return color;
		}
		public static string GetStatColor(string stat)
		{
			string color = stat switch
			{
				"hp" => "#FE0000",
				"attack" => "#EE7F30",
				"defense" => "#F7D02C",
				"special-attack" => "#F85687",
				"special-defense" => "#77C755",
				"speed" => "#678FEE",
				_ => "0190FF"
			};

			return color;
		}
		
	}
}