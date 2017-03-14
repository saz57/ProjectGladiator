using UnityEngine;
using System.Collections;

public class BlockCollision : MonoBehaviour, IDamageble {

	[SerializeField]
	private Animator animator;
	private Collider blockCollider;

	public void Awake()
	{
		blockCollider = this.GetComponent<Collider> ();
		DisableCollision ();
	}

	public void EnableCollision()
	{
		if (blockCollider != null) {
			blockCollider.enabled = true;
		}
	}

	public void DisableCollision()
	{
		if (blockCollider != null) {
			blockCollider.enabled = false;
		}
	}


	public void SetDamage (float _damage) {
		animator.SetBool ("GetDamage", true);
		animator.SetInteger ("DamageType", 4);
		Debug.Log ("LOL. No way =)");
	}
}
