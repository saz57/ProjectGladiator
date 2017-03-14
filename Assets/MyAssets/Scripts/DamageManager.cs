using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
public class DamageManager : NetworkBehaviour {


	public MeleeWeapon Weapon;
	private PlayerProperties ounProperties;

	public void Start()
	{
		ounProperties = this.gameObject.GetComponent<PlayerProperties> ();
	}

	[Command]
	public void CmdSendDamage (GameObject _resiver, float _damage)
	{
		if (_resiver != null) {
			(_resiver.GetComponent<IDamageble>() as IDamageble).SetDamage (_damage);
		}
	}
}
