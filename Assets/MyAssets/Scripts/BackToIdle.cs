using System;
using UnityEngine;

public class BackToIdle : StateMachineBehaviour
{

	/*public delegate void MoveAnimationDelegate();

	public event MoveAnimationDelegate OnMoveEnter;

	public event MoveAnimationDelegate OnMoveExit;


	public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
		animator.gameObject.GetComponent<Player> ().MoveAnimationScript = this;
	}*/

	public override void OnStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.SetBool ("LightAttack", false);
		animator.SetBool("HeavyAttack", false);
		animator.SetBool ("JumpAttack", false);
		animator.SetBool ("GetDamage", false);
		animator.SetInteger ("DamageType", 0);
		animator.SetInteger ("Iterations", 0);
		/*if (OnMoveEnter != null) {
			OnMoveEnter ();
		}*/
		animator.SendMessage ("InIdle", true);

	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		/*if (OnMoveExit != null) {
			OnMoveExit ();
		}*/
		animator.SendMessage ("InIdle", false);
	}
}

