using UnityEngine;
using System.Collections;

namespace CrazyGames.Animations {


	public class Head {

		
		public int sumar (int a, int b) {
			return a + b;
		}


		public static string MoverCabeza (string direction) {
			return "Moviendo mi cabeza a la: " + direction;
		}
		
		public string PegarNovia(string parteCuerpo) {
			if (parteCuerpo == "Mano")
				return "Cabron no me vuelvas a pegar";
			else 
				return "Ay Tan Rico que no me pegastes";
		}
		
	}

}
