using UnityEngine;
using System.Collections;

public class myCamera : MonoBehaviour {

	public float radius = 10.0f;
	public Transform player;
	private float x, y ,z;
	private float o, f;
	private float lastMouseX, lastMouseY;
	private Vector3 thisPosition;
	// Use this for initialization
	void Start () {
		lastMouseX = Input.GetAxis ("Mouse X");
		lastMouseY = Input.GetAxis ("Mouse Y");
		thisPosition = player.position;
	}

	// Update is called once per frame
	void Update () {
		o = lastMouseX - Input.GetAxis ("Mouse X");
		f = lastMouseY - Input.GetAxis ("Mouse Y");

		if (o!=0 ||f!=0) {

			lastMouseX = Input.GetAxis ("Mouse X");
			lastMouseY = Input.GetAxis ("Mouse Y");
			/*x = radius * (Mathf.Sin(o*Mathf.PI/180.0f)*Mathf.Cos(f*Mathf.PI/180.0f));
			y = radius * (Mathf.Sin(o*Mathf.PI/180.0f)*Mathf.Sin(f*Mathf.PI/180.0f));
			z = radius * Mathf.Cos(o*Mathf.PI/180.0f);*/
			x = radius * (Mathf.Sin(o)*Mathf.Cos(f));
			y = radius * (Mathf.Sin(o)*Mathf.Sin(f));
			z = radius * Mathf.Cos(o);
			//thisPosition = this.transform.position;
			this.transform.localPosition += new Vector3(x,z,y);
			this.transform.rotation.SetLookRotation(thisPosition,this.transform.position);
			thisPosition = player.position;
		}
	
	}
}
