using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSync: NetworkBehaviour {

	[SerializeField]
	private float syncSpeed = 20;
	[SyncVar]
	private Vector3 syncPosition;
	[SyncVar]
	private Quaternion synkRotation;

	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		TransmitTransform ();
		LerpTransform ();
	}

	private void LerpTransform()
	{
		if (!isLocalPlayer) 
		{
			this.transform.position = Vector3.Lerp (this.transform.position, syncPosition, Time.deltaTime * syncSpeed);
			this.transform.rotation = Quaternion.Lerp (this.transform.rotation, synkRotation, Time.deltaTime * syncSpeed);
		}
	}

	[Client]
	private void TransmitTransform()
	{
		if (isLocalPlayer) 
		{
			CmdSendTransform (this.transform.position, this.transform.rotation);
		}
	}



	[Command]
	private void CmdSendTransform(Vector3 _position, Quaternion _rotation)
	{
		syncPosition = _position;
		synkRotation = _rotation;
	}
}
