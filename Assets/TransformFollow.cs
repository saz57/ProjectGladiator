using UnityEngine;
using System.Collections;

public class TransformFollow : MonoBehaviour {
	[SerializeField]
	private bool followPosition;
	[SerializeField]
	private bool followRotation;
	[SerializeField]
	private bool followScale;
	[SerializeField]
	private Transform followed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (followPosition) {
			this.transform.position = followed.position;
		}

		if (followRotation) {
			this.transform.rotation = followed.rotation;
		}

		if (followScale) {
			this.transform.localScale = followed.localScale;
		}
	}
}
