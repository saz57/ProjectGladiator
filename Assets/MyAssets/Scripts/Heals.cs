using UnityEngine;
using System.Collections;

public class Heals: MonoBehaviour {

	private float _heals;
	private CharacterController characterController;
	private Animator animator;
	// Use this for initialization
	void Start () {
		_heals = 100;
		characterController = this.gameObject.GetComponent<CharacterController> ();
		animator = this.gameObject.GetComponent<Animator> ();
	}

	void SetDamage(float damage)
	{
		_heals -= damage;
		Debug.Log ("AUCH");
		if (_heals <= 0) {
			Destroy (this.gameObject);
		}

		/*if (animator != null && characterController != null) {
			animator.SetBool ("GetDamage", true);
			if (point.x - characterController.center.x > 0) {
				animator.SetInteger
			}
		}*/

	}
	// Update is called once per frame
	void Update () {
	
	}
}
