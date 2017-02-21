using UnityEngine;
using System.Collections;

public class GetDamageAnimation : StateMachineBehaviour {

	public override void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.SetBool ("GetDamage", false);
		animator.SetInteger ("DagameType", 0);
	}
}
