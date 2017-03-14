using UnityEngine;
using System.Collections;
[RequireComponent(typeof (CharacterController))]

public class Move : MonoBehaviour {
	
	public float speed = 10.0f;
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
	//public float runSpeed = 2.0f;
	public bool canMove = true;
	private Vector3 moveDirection = Vector3.zero;
	private bool grounded = false;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	#region EventSystem
	/*public void AddEventLiseners(BackToIdle animationScript) 
	{
		animationScript.OnMoveEnter += OnMoveEnter;
		animationScript.OnMoveExit += OnMoveExit;
	}

	private void OnMoveEnter() // ОБРАБОТЧИК НОМЕР РАЗ
	{
		canMove = true;
	}

	private void OnMoveExit() // ОБРАБОТЧИК НОМЕР ДВА
	{
		canMove = false;
	}*/
	#endregion

	public void InIdle(bool _inIdle)
	{
		canMove = _inIdle;
		if (!canMove) {
			moveDirection = Vector3.zero;
		}
	}

	void FixedUpdate() {
		if (canMove) {
			if (grounded) {
				// We are grounded, so recalculate movedirection directly from axes
				moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
				moveDirection = transform.TransformDirection (moveDirection);
				moveDirection *= speed;
			
				/*if (Input.GetButton ("Jump")) {
					moveDirection.y = jumpSpeed;
				} */  
			
				/*if (Input.GetButton ("run")) {
				moveDirection *= runSpeed;
			}*/
			}
		}
			// Apply gravity
			moveDirection.y -= gravity * Time.deltaTime;
		
			// Move the controller
			CharacterController controller = this.gameObject.GetComponent<CharacterController> ();
			CollisionFlags flags = controller.Move (moveDirection * Time.deltaTime);
			grounded = (flags & CollisionFlags.CollidedBelow) != 0;

	}
}
