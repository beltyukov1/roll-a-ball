using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start() {
		// transform.position is position of the camera
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	// Runs after all items have been processed in Update()
	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}
}
