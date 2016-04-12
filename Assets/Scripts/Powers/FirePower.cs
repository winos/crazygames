using UnityEngine;
using System.Collections;
using CrazyGames.Interface;

/**
 * This class shoot a Flame
 * 
 * @auhtor Dawin Ossa - dawinos@gmail.com
 * @version 1.0
 * @see CrazyGames.Interface.IPower
 * @copyright CrazyGames Inc
 */
namespace CrazyGames.Powers 
{
	public class FirePower : MonoBehaviour, IPower {

		public int velocity = 100;

		public GameObject prefab;

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

			GameObject clone = (GameObject) Instantiate(prefab, transform.position, Quaternion.identity);
			Rigidbody rb = clone.GetComponent<Rigidbody>();
			rb.AddForce(Vector3.right * this.velocity, ForceMode.VelocityChange);
			Debug.Log ("Fire Single Power");
		}
	}
}
