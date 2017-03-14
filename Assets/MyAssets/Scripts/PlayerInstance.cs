using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerInstance : NetworkBehaviour {
	[SerializeField]
	private GameObject camera;

	// Use this for initialization
	void Start () {
		
		if (isLocalPlayer) {
			GameObject.Find ("MainCamera").SetActive (false);
			camera.SetActive (true);
			GetComponent<Move> ().enabled = true;
			GetComponent<TestMecanim> ().enabled = true;
			GetComponent<MouseRotaror> ().enabled = true;
			GetComponent<PlayerProperties> ().ItsLocalPlayer ();
		}
		else 
		{
			this.GetComponent<DamageManager> ().enabled = false;		
		}
	}

}
