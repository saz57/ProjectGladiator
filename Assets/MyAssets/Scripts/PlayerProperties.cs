using UnityEngine;
using System.Collections;

public class PlayerProperties: MonoBehaviour, IDamageble {


	private float heals;
	private Animator animator;
	private bool localPlayer = false;
	private bool isDead;
	// Use this for initialization
	public void Start () {
		isDead = false;
		heals = 100;
		animator = this.gameObject.GetComponent<Animator> ();
	}

	public void SetDamage(float _damage)
	{
		heals -= _damage;
		animator.SetBool ("GetDamage", true);
		animator.SetInteger ("DamageType", 2);
		if (heals <= 0) {
			heals = 0;
			isDead = true;

		}

		/*if (animator != null && characterController != null) {
			animator.SetBool ("GetDamage", true);
			if (point.x - characterController.center.x > 0) {
				animator.SetInteger
			}
		}*/

	}

	public void ItsLocalPlayer()
	{
		localPlayer = true;
	}

	// Update is called once per frame
	public void OnGUI () {

		if (localPlayer) {
			GUI.Box (Rect.MinMaxRect (0, 0, 100, 50), "Heals " + heals.ToString ()); 
		}

		if(isDead)
		{
			GUI.Box(Rect.MinMaxRect(Screen.width-100,0,Screen.width,50),"YOU DEFEATED!");
		}
	}
}
