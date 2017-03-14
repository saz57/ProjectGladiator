using UnityEngine;
using System.Collections;

public class TestMecanim : MonoBehaviour {

	[SerializeField]
	private BlockCollision blockCollision;
//	public myMove controller;
	private Animator anim;
	// Use this for initialization
	void Start () 
	{
		//Time.timeScale = 0.5f;
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//if(Input.GetAxis("Horizontal")!=0)
		anim.SetFloat("Vertical",Input.GetAxis("Vertical"),0.1f,Time.deltaTime);
		anim.SetFloat("Horizontal",Input.GetAxis("Horizontal"),0.1f,Time.deltaTime);
		
		//if(Input.GetAxis("Vertical")!=0)
		if (Input.GetButtonDown ("Fire1") && !anim.GetBool ("HeavyAttack")) {
			
			if (anim.GetBool ("LightAttack")) {
				anim.SetInteger ("Iterations", anim.GetInteger ("Iterations") + 1);
			}

			else {
				anim.SetBool ("LightAttack", true);
			}
		}

		if (Input.GetButtonDown ("Fire2") && !anim.GetBool ("LightAttack")) {
			
			if (anim.GetBool ("HeavyAttack")) {
				anim.SetInteger ("Iterations", anim.GetInteger ("Iterations") + 1);
			}

			else {
				anim.SetBool ("HeavyAttack", true);
			}
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			anim.SetBool ("JumpAttack", true);
		}

		/*if (Input.GetKeyDown (KeyCode.Z)) {
			anim.SetBool ("GetDamage", true);
			anim.SetInteger ("DamageType", 1);
		}

		if (Input.GetKeyDown (KeyCode.X)) {
			anim.SetBool ("GetDamage", true);
			anim.SetInteger ("DamageType", 2);
		}

		if (Input.GetKeyDown (KeyCode.C)) {
			anim.SetBool ("GetDamage", true);
			anim.SetInteger ("DamageType", 3);
		}*/

		if (Input.GetButtonDown ("Block")) {
			blockCollision.EnableCollision ();
			anim.SetBool ("Block", true);
		}

		if (Input.GetButtonUp ("Block")) {
			anim.SetBool ("Block", false);
		}
	}

	public void InIdle()
	{
		blockCollision.DisableCollision ();
	}
}
