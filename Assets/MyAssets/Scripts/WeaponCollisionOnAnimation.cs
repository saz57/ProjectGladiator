using UnityEngine;
using System.Collections;

public class WeaponCollisionOnAnimation : StateMachineBehaviour {

	public override void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<DamageManager> ().Weapon.EnableCollision ();
	}

	public override void OnStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.GetComponent<DamageManager> ().Weapon.DisableCollision ();
	}
}
