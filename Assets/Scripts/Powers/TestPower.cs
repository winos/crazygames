using UnityEngine;
using System.Collections;
using CrazyGames.Interface;

/**
 * This class to execute stuff...
 * 
 * @auhtor (developer) - (email)
 * @version 1.0
 * @see CrazyGames.Interface.IPower
 * @copyright CrazyGames Inc
 */

namespace CrazyGames.Powers 
{
	public class TestPower : MonoBehaviour, IPower {
		
		// Properties
		int a;

		string b;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		/**
		 * Implement method from IPower
		 */
		public void ThrowPower() {
			// Do Something 
		}
	}
}
