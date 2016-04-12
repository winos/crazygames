using UnityEngine;
using System.Collections;
using CrazyGames.Interface;
/**
 * This class managment shooter in the game
 * 
 * @auhtor Dawin Ossa - dawinos@gmail.com
 * @version 1.0
 * @copyright CrazyGames Inc
 */
namespace CrazyGame.Utils 
{
	public class Shoot  {

		// direction of shoot
		public static string direction;

		public static void Fire(IPower power) {
			power.ThrowPower();
		}

		Vector3 CalculatedDirection(string direction) {

			Vector3 result = Vector3.back;

			switch (direction) {
				case "back":
					result = Vector3.back;
				break;
				case "down":
					result = Vector3.down;
				break;
				case "forward":
					result = Vector3.forward;
				break;
				case "left":
					result = Vector3.left;
				break;
				case "one":
					result = Vector3.one;
				break;
				case "right":
					result = Vector3.right;
				break;
				case "up":
					result = Vector3.up;
				break;
				case "zero":
					result = Vector3.zero;
				break;
			}
			return result;
		}
	}
}