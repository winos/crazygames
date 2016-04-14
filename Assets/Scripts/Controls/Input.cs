using UnityEngine;
using System.Collections;

namespace CrazyGames.Controls {

	public class Input {

		public static bool GetKey (string key) {
			if (key.ToLower() == "A")
				return true;
			else 
				return false;
		}
	}
}
