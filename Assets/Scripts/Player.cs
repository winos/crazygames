using UnityEngine;
using System.Collections;
using CrazyGame.Utils;
using CrazyGames.Powers;

/**
 * This class management the player
 * 
 * @auhtor Dawin Ossa - dawinos@gmail.com
 * @version 1.0
 * @copyright CrazyGames Inc
 */
namespace CrazyGames.Game 
{
	public class Player : MonoBehaviour
	{
		private FirePower _firepower;

		void Start () {
			_firepower = this.GetComponent<FirePower>();
		}
		
		// Update is called once per frame
		void Update () {
			if (Input.GetKeyDown(KeyCode.P)) {
				// Bitch here is where the magic happen ;)
				Shoot.Fire(_firepower);
			}
		}
	}
}