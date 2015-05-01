/* taken from https://github.com/drfuzzyness/Hunty2 */

using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Nonplayer))]
public class NonplayerDriver : MonoBehaviour {
	Vector3 direction;
	public bool moving = false;
	public bool rotated = false;
	public float moveSpeed=2f;
	public float waitCount = 200;

	// Update is called once per frame
	void Update () {
		direction = new Vector3(0, 1, 0);
		moveNonplayer();

		if (rigidbody.velocity == Vector3.zero && rigidbody.angularVelocity == Vector3.zero) {
			moving = false;
		}

	}

	void moveNonplayer() {
		if (Mathf.Round(transform.eulerAngles.y) % 90 == 0) {
			if (!moving) {

				if (waitCount <= 0) {
					waitCount = 200;
					rigidbody.AddForce(transform.forward * moveSpeed);
					moving = true;
					rigidbody.isKinematic = false;
				} else {
					waitCount--;
				}
			} else {
				rigidbody.velocity = Vector3.zero;
			    rigidbody.angularVelocity = Vector3.zero;
			    if (rigidbody.velocity == Vector3.zero && rigidbody.angularVelocity == Vector3.zero) {
					rigidbody.isKinematic = true;
				}
			    
			}

			RaycastHit hit;

	        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
	        	if (hit.collider.gameObject.name == "WallLeft" ||
	        		hit.collider.gameObject.name == "WallRight" ||
	        		hit.collider.gameObject.name == "WallFront" ||
	        		hit.collider.gameObject.name == "WallBack") {
	        		transform.Rotate(direction);
	        	}
	        }
		} else {
			transform.Rotate(direction);
		}
	}

	void OnDrawGizmos() {
    	Gizmos.DrawRay(transform.position, transform.forward*20);
    }
}
