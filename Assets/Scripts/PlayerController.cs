using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rigidBody;

	// Called on first frame script is active
	// Often very first frame of game
	void Start() {
		rigidBody = GetComponent<Rigidbody>();
	}

	// Called before rendering a frame 	// Most of game code will go here
	void Update() {
	
	}
	
	// Called before performing any physics calculations
	// Physics code will go here
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		rigidBody.AddForce(movement * speed);
	}
}
