using UnityEngine;
using System.Collections;

public class MeleeWeapon : MonoBehaviour {

	[SerializeField]
	private float weaponDamage;
	[SerializeField]
	private DamageManager ounDamageManager;
	private Rigidbody rigidbody;
	// Use this for initialization
	public void Start()
	{
		rigidbody = this.GetComponent<Rigidbody> ();
		rigidbody.isKinematic = true;
	}


	public void EnableCollision()
	{
		rigidbody.isKinematic = false;
	}

	public void DisableCollision()
	{
		rigidbody.isKinematic = true;
	}

	// Update is called once per frame
	public void OnCollisionEnter (Collision coll) {
		if (ounDamageManager != null &&  coll.gameObject!= ounDamageManager.gameObject) {
			ounDamageManager.CmdSendDamage (coll.gameObject, weaponDamage);
			rigidbody.isKinematic = true;
		}
	}
}
