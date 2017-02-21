using UnityEngine;
using System.Collections;

public class DamageOnCollision : MonoBehaviour {

	[SerializeField]
	private float _weaponDamage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision coll) {
		coll.gameObject.SendMessage ("SetDamage", _weaponDamage);
	}
}
