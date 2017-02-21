using UnityEngine;
using System.Collections;

public class MouseRotaror : MonoBehaviour {

	public float sencurity = 1;
	private Vector3 mouseRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mouseRotation = new Vector3 (0, Input.GetAxis ("Mouse X")*sencurity, 0);
		this.transform.Rotate (mouseRotation);
	}
}
