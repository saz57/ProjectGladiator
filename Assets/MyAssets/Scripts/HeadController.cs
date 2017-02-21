using UnityEngine;
using System.Collections;

public class HeadController : MonoBehaviour {
	private Vector3 anglee;
	private Quaternion lastRotation;
	// Use this for initialization
	void Start () {
		lastRotation = this.transform.rotation; 
	}
	
	// Update is called once per frame
	void LateUpdate () {
		this.transform.rotation = lastRotation;
		anglee.y = Input.GetAxis ("Mouse X");
		anglee.x = Input.GetAxis ("Mouse Y");
		Debug.Log (anglee.ToString ());
		this.transform.Rotate (anglee);
		lastRotation = this.transform.rotation;
	}
}
