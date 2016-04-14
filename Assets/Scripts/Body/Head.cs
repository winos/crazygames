using UnityEngine;
using System.Collections;

/**
 * This class shoot a Flame
 * 
 * @auhtor Dawin Ossa - dawinos@gmail.com
 * @version 1.0
 * @see CrazyGames.Interface.IPower
 * @copyright CrazyGames Inc
 */

namespace CrazyGames.Body {
	

	public class Head {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		public int sumar (int a, int b) {
			return a + b;
		}

		public string PegarNovia(string parteCuerpo) {
			if (parteCuerpo == "Mano")
				return "Cabron no me vuelvas a pegar";
			else 
				return "Ay Tan Rico que no me pegastes";
		}

	}
}