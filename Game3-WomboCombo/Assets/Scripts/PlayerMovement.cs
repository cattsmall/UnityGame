/* taken from https://github.com/chromeSandra/ProjectForGameStudio */

using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed=2f;
	public Rigidbody rigidbody;
	public bool moving = false;
	public float direction = 0;
	Vector3 goalPosition;

	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (moving == true) {
			rigidbody.velocity = Vector3.zero;
		    rigidbody.angularVelocity = Vector3.zero;
			rigidbody.AddForce(transform.forward * moveSpeed);

			if ((direction == 0 && transform.position.z-goalPosition.z <= 0) ||
				(direction == 1 && transform.position.z-goalPosition.z >= 0)
				){
				moving = false;
			}
		} else {
			rigidbody.velocity = Vector3.zero;
		    rigidbody.angularVelocity = Vector3.zero;
		}
	}

	public void Move( Vector3 position ){
		moving = true;
		goalPosition.z = position.z;
		
		if (transform.position.z-goalPosition.z > 0) {
			direction = 0;
		} else {
			direction = 1;
		}
	}

	public void stopMoving(){
	}
}
