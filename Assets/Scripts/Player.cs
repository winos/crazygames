using UnityEngine;
using System.Collections;
using CrazyGame.Utils;
using CrazyGames.Powers;
using CrazyGames.Body;
using Animations = CrazyGames.Animations;
using InputCrazy = CrazyGames.Controls.Input;
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
		private CrazyGames.Body.Head _head;
		private Animations.Head _headAnimation;

		void Start () {

			//_head = new CrazyGames.Body.Head();
			//_headAnimation = new Animations.Head();

			//_firepower = this.GetComponent<FirePower>();
			Debug.Log(Input.GetKey("a") + " , se presionó la tecla A en Unity");
			Debug.Log(InputCrazy.GetKey("A") + " , se presionó la tecla A en CrazyGame");
			/*string resultadoDeGolpiza = _head.PegarNovia("Pie");
			Debug.Log("Resultado de Body: "+ resultadoDeGolpiza);
			Debug.Log("Resultado de Animations:"+ _headAnimation.PegarNovia("Mano"));
			Debug.Log("Suma #1 es igual a: "+ _headAnimation.sumar(1, 5));
			Debug.Log("Suma #1 es igual a: "+ _headAnimation.sumar(12, 5));

			int resultadoSuma = _headAnimation.sumar(1, 5);
			Vector3 myVector = new Vector3(0, resultadoSuma, 0);
			Debug.Log (myVector.ToString());*/

			//Debug.Log(Animations.Head.MoverCabeza("izquierda y desnucandome!"));
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